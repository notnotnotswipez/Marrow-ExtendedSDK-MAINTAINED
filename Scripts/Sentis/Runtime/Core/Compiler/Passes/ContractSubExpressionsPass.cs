using System.Linq;
using Unity.Sentis.Compiler.Analyser;
using Unity.Sentis.Layers;
using Unity.Sentis;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Unity.Sentis.Compiler.Passes.Optimization
{
    class ContractSubExpressionPass : IModelPass
    {
        Dictionary<string, Constant> modelConstants = new Dictionary<string, Constant>();
        Dictionary<string, Layer> nameToLayer = new Dictionary<string, Layer>();
        Dictionary<string, int> nameToIndex = new Dictionary<string, int>();
        Dictionary<string, List<Layer>> downstreamLayers = new Dictionary<string, List<Layer>>();
        List<Layer> layersInPattern = new List<Layer>();
        List<string> inputLayers = new List<string>();
        List<Constant> inputConstants = new List<Constant>();

        // Automatic Chain rule CAS
        // we construct a graph of successive operations by chaining operators and function calls
        //  (x + 2) / 3 + x
        // that creates a graph of INode storing each operations
        // we can call .Validate on that object and it will recursively walk the graph and check validity if layer inputs match the subgraph
        // leaf node:
        //  * constant, match if constant exists and has the expected value
        //  * input, always match
        // tree node:
        //  * check layer type matches INode type
        //  * returns true if all inputs are valid
        private abstract class INode
        {
            public static INode operator *(INode a, INode b)
            {
                return new LayerNode<Mul>(a, b);
            }
            public static INode operator *(INode a, float b)
            {
                return new LayerNode<Mul>(a, b);
            }
            public static INode operator +(INode a, INode b)
            {
                return new LayerNode<Add>(a, b);
            }
            public static INode operator +(INode a, float b)
            {
                return new LayerNode<Add>(a, b);
            }
            public static INode operator -(INode a, INode b)
            {
                return new LayerNode<Sub>(a, b);
            }
            public static INode operator /(INode a, INode b)
            {
                return new LayerNode<Div>(a, b);
            }
            public static INode operator /(INode a, float b)
            {
                return new LayerNode<Div>(a, b);
            }
            public static INode Erf(INode a)
            {
                return new LayerNode<Erf>(a);
            }
            public static INode Sigmoid(INode a)
            {
                return new LayerNode<Sigmoid>(a);
            }
            public static INode Pow(INode a, float b)
            {
                return new LayerNode<Pow>(a, b);
            }
            public static INode Sqrt(INode a)
            {
                return new LayerNode<Sqrt>(a);
            }
            public static INode ReduceMean(INode a, int b)
            {
                return new LayerNode<ReduceMean>(a, b);
            }

            public static INode ScaleBias(INode a, INode b, INode c)
            {
                return new LayerNode<ScaleBias>(a, b, c);
            }
        }

        private class InputNode : INode
        {
        }

        private class ScalarNode : INode
        {
        }

        private class ScalarMadNode : INode
        {
        }

        abstract class IConstantNode : INode
        {
            public abstract bool Validate(Constant constant);
        }

        class ScalarInt : IConstantNode
        {
            float m_Value;
            public ScalarInt(int v)
            {
                m_Value = v;
            }

            public override bool Validate(Constant constant)
            {
                if (constant.dataType != DataType.Int)
                    return false;

                return constant.length == 1 && constant.weights.Get<int>(0) == m_Value;
            }
        }

        class ScalarFloat : IConstantNode
        {
            float m_Value;
            public ScalarFloat(float v)
            {
                m_Value = v;
            }

            public override bool Validate(Constant constant)
            {
                if (constant.dataType != DataType.Float)
                    return false;

                return constant.length == 1 && constant.weights.Get<float>(0) == m_Value;
            }
        }

        abstract class ILayerNode : INode
        {
            public INode[] inputs;
            public abstract bool Validate(Layer layer);
        }

        class LayerNode<T> : ILayerNode where T : Layer
        {
            public LayerNode(INode i0)
            {
                inputs = new[] { i0 };
            }
            public LayerNode(INode i0, INode i1)
            {
                inputs = new[] { i0, i1 };
            }
            public LayerNode(INode i0, float i1)
            {
                inputs = new[] { i0, new ScalarFloat(i1) };
            }
            public LayerNode(INode i0, int i1)
            {
                inputs = new[] { i0, new ScalarInt(i1) };
            }

            public LayerNode(INode i0, INode i1, INode i2)
            {
                inputs = new[] { i0, i1, i2 };
            }

            public override bool Validate(Layer layer)
            {
                return layer is T;
            }
        }

        // remapping rules:
        // key: expression to test against
        // value: layer to spawn, layersInPattern is all the layers that match the expression
        Dictionary<Func<InputNode, INode>, Func<Layer, List<string>, List<Constant>, Layer>> remappingRules = new Dictionary<Func<InputNode, INode>, Func<Layer, List<string>, List<Constant>, Layer>>()
        {
            { x => INode.Pow(x, -1.0f),                                      (y, iLayers, iConstants) => new Reciprocal(y.name, iLayers[0]) },
            { x => INode.Pow(x, 0.5f),                                       (y, iLayers, iConstants) => new Sqrt(y.name, iLayers[0]) },
            { x => INode.Pow(x, 1.0f),                                       (y, iLayers, iConstants) => new Identity(y.name, iLayers[0]) },
            { x => INode.Pow(x, 2.0f),                                       (y, iLayers, iConstants) => new Square(y.name, iLayers[0]) },
            { x => (x * INode.Sigmoid(x)),                                   (y, iLayers, iConstants) => new Swish(y.name, iLayers[0]) },
            { x => (x * (INode.Erf((x / Mathf.Sqrt(2.0f))) + 1.0f)) * 0.5f,  (y, iLayers, iConstants) => new Gelu(y.name, iLayers[0]) },
            { x => {
                var mean = INode.ReduceMean(x, -1);
                var y = x - mean;
                var variance = INode.ReduceMean(INode.Pow(y, 2.0f), -1);
                var epsilon = new ScalarNode();
                var v = y / INode.Sqrt(variance + epsilon);
                var scale = new InputNode();
                var bias = new InputNode();
                return v * scale + bias; },                                  (y, iLayers, iConstants) => { float epsilon = iConstants[0].weights.Get<float>(0);
                                                                                                           return new LayerNormalization(y.name, iLayers[iLayers.Count - 1], iLayers[1], iLayers[0], epsilon);
                }
             },
            {x => x + new ScalarMadNode(), (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], 1.0f, iConstants[0].weights.Get<float>(0)) },
            {x => new ScalarMadNode() + x, (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], 1.0f, iConstants[0].weights.Get<float>(0)) },
            {x => x - new ScalarMadNode(), (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], 1.0f, -iConstants[0].weights.Get<float>(0)) },
            {x => new ScalarMadNode() - x, (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], -1.0f, iConstants[0].weights.Get<float>(0)) },
            {x => x * new ScalarMadNode(), (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], iConstants[0].weights.Get<float>(0), 0) },
            {x => new ScalarMadNode() * x, (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], iConstants[0].weights.Get<float>(0), 0) },
            {x => x / new ScalarMadNode(), (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], 1.0f / iConstants[0].weights.Get<float>(0), 0) },
            {x =>  INode.ScaleBias(x, new ScalarMadNode(), new ScalarMadNode()), (y, iLayers, iConstants) => new ScalarMad(y.name, iLayers[0], iConstants[0].weights.Get<float>(0), iConstants[1].weights.Get<float>(0)) },
        };

        bool Validate(INode root, Layer input)
        {
            Stack<string> layerStack = new Stack<string>();
            Stack<INode> nodeStack = new Stack<INode>();

            nodeStack.Push(root);
            layerStack.Push(input.name);
            while (nodeStack.Count != 0)
            {
                INode node = nodeStack.Pop();
                string name = layerStack.Pop();

                if (node is IConstantNode cNode)
                {
                    if (!modelConstants.TryGetValue(name, out Constant constant))
                        return false;

                    if (!cNode.Validate(constant))
                        return false;
                }
                else if (node is ILayerNode lNode)
                {
                    if (!nameToLayer.TryGetValue(name, out Layer layer))
                        return false;

                    if (!lNode.Validate(layer))
                        return false;

                    layersInPattern.Add(layer);
                    for (int i = 0; i < layer.inputs.Length; i++)
                    {
                        layerStack.Push(layer.inputs[i]);
                        nodeStack.Push(lNode.inputs[i]);
                    }
                }
                else if (node is InputNode)
                {
                    inputLayers.Add(name);
                }
                else if (node is ScalarNode)
                {
                    if (!modelConstants.TryGetValue(name, out Constant constant))
                        return false;
                    inputConstants.Add(constant);
                }

                else if (node is ScalarMadNode)
                {
                    if (!modelConstants.TryGetValue(name, out Constant constant))
                        return false;
                    if (constant.length != 1 || constant.dataType != DataType.Float || constant.shape.rank > 1)
                        return false;
                    inputConstants.Add(constant);
                }
            }

            return true;
        }

        // Pattern is said to be fully included if
        // foreach layer in subgraph
        // * all input are in the subGraph or inputs of root layer
        // * all downstream layers are in the subGraph or downstream of root layer
        bool CheckGraphFullInclusion(Layer root, List<Layer> subGraph, out string patternInput)
        {
            patternInput = null;
            HashSet<string> layersInSubGraph = new HashSet<string>();
            foreach (var layer in subGraph)
            {
                layersInSubGraph.Add(layer.name);
                foreach (var input in layer.inputs)
                {
                    layersInSubGraph.Add(input);
                }
                foreach (var downStream in downstreamLayers[layer.name])
                {
                    if (downStream != null)
                        layersInSubGraph.Add(downStream.name);
                }
            }

            foreach (var layer in layersInPattern)
            {
                layersInSubGraph.Remove(layer.name);
                foreach (var input in layer.inputs)
                {
                    if (modelConstants.ContainsKey(input))
                        layersInSubGraph.Remove(input);
                }
            }

            foreach (var downStream in downstreamLayers[root.name])
            {
                if (downStream == null)
                    continue;
                if (!layersInSubGraph.Contains(downStream.name))
                    return false;
                layersInSubGraph.Remove(downStream.name);
            }

            if (layersInSubGraph.Count != 1)
                return false;

            patternInput = layersInSubGraph.ElementAt(0);

            return true;
        }

        public void Run(ref Model model)
        {
            HashSet<string> layersToRemove = new HashSet<string>();

            // build static helpers:
            // - name -> constant
            // - name -> layer index
            modelConstants = new Dictionary<string, Constant>();
            foreach (var c in model.constants)
                modelConstants.Add(c.name, c);

            nameToLayer = new Dictionary<string, Layer>();
            nameToIndex = new Dictionary<string, int>();
            downstreamLayers = new Dictionary<string, List<Layer>>();
            var outputs = new HashSet<string>();
            foreach (var o in model.outputs)
                outputs.Add(o);
            for (int l = 0; l < model.layers.Count; ++l)
            {
                Layer layer = model.layers[l];
                nameToLayer.Add(layer.name, layer);
                nameToIndex.Add(layer.name, l);

                foreach (var input in layer.inputs)
                {
                    if (downstreamLayers.ContainsKey(input))
                        downstreamLayers[input].Add(layer);
                    else
                        downstreamLayers[input] = new List<Layer> { layer };
                }

                if (outputs.Contains(layer.name))
                {
                    downstreamLayers[layer.name] = new List<Layer> { null };
                }
            }

            var x = new InputNode();
            layersInPattern = new List<Layer>();
            inputLayers = new List<string>();
            inputConstants = new List<Constant>();

            // Algorithm:
            // foreach layers
            //  foreach pattern
            //      check if pattern is matched walking up model inputs
            //      if matched, check if subgraph is fully enclosed
            //      insert new merged layer
            for (int l = 0; l < model.layers.Count; ++l)
            {
                Layer layer = model.layers[l];

                foreach (var item in remappingRules)
                {
                    layersInPattern.Clear();
                    inputLayers.Clear();
                    inputConstants.Clear();

                    var pattern = item.Key(x);
                    if (!Validate(pattern, layer))
                        continue;

                    if (!CheckGraphFullInclusion(layer, layersInPattern, out string input))
                        continue;

                    var remapping = item.Value;
                    var remapLayer = remapping(layer, inputLayers, inputConstants);

                    bool unconnectedOutputs = false;
                    foreach (var layerToDelete in layersInPattern)
                    {
                        unconnectedOutputs |= (remapLayer.name != layerToDelete.name) && outputs.Contains(layerToDelete.name);
                    }
                    if (unconnectedOutputs)
                        break;


                    model.layers[nameToIndex[remapLayer.name]] = remapLayer;

                    foreach (var layerToDelete in layersInPattern)
                    {
                        if (remapLayer.name != layerToDelete.name)
                            layersToRemove.Add(layerToDelete.name);
                    }

                    break;
                }
            }

            model.layers.RemoveAll(l => layersToRemove.Contains(l.name));
        }
    }
}
