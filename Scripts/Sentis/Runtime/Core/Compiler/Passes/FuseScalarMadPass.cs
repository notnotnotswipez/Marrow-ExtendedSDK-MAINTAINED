using System.Collections.Generic;

namespace Unity.Sentis.Compiler.Passes.Optimization
{
    class FuseScalarMadPass : IModelPass
    {
        public void Run(ref Model model)
        {
            var scalarMadLayers = new Dictionary<string, Layers.ScalarMad>();
            for (int l = 0; l < model.layers.Count; ++l)
            {
                Layers.Layer layer = model.layers[l];

                if (layer is not Layers.ScalarMad)
                    continue;

                if (scalarMadLayers.TryGetValue(layer.inputs[0], out var previousLayer))
                {
                    var madLayer = layer as Layers.ScalarMad;
                    model.layers[l] = new Layers.ScalarMad(madLayer.name, previousLayer.inputs[0], previousLayer.s * madLayer.s, madLayer.s * previousLayer.b + madLayer.b);
                }
                scalarMadLayers[layer.name] = model.layers[l] as Layers.ScalarMad;

            }
        }
    }
}
