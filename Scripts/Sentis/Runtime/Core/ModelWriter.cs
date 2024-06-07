using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Profiling;

namespace Unity.Sentis
{
    /// <summary>
    /// Provides methods for saving models.
    /// </summary>
    public static class ModelWriter
    {
        /// <summary>
        /// Saves the model description and weights to a file.
        /// </summary>
        public static void Save(string fileName, Model model)
        {
            using FileStream fileStream = File.Create(fileName);
            var descStream = new MemoryStream();
            SaveModelDesc(descStream, model);
            var descData = descStream.ToArray();
            fileStream.Write(descData, 0, descData.Length);
            descStream.Dispose();

            var weightStreams = new List<MemoryStream>();
            SaveModelWeights(weightStreams, model);

            foreach (var stream in weightStreams)
            {
                descData = stream.ToArray();
                fileStream.Write(descData, 0, descData.Length);
                stream.Dispose();
            }
        }

        internal static void SaveModelDesc(MemoryStream stream, Model model)
        {
            Profiler.BeginSample("Sentis.ModelWriter.SaveModelDesc");

            Write(stream, Model.Version);

            // Write inputs
            Write(stream, model.inputs.Count);
            foreach (var input in model.inputs)
            {
                WriteObject(stream, input);
            }

            // Write outputs
            WriteObject(stream, model.outputs);

            // Write layers
            Write(stream, model.layers.Count);
            foreach (var layer in model.layers)
            {
                WriteObject(stream, layer);
            }

            long offsetFromModelStartToLayer = 0;
            Write(stream, model.constants.Count);
            foreach (var constant in model.constants)
            {
                if (offsetFromModelStartToLayer * sizeof(float) + (long)(constant.length * sizeof(float)) >= (long)Int32.MaxValue)
                {
                    offsetFromModelStartToLayer = 0;
                }

                WriteObject<string>(stream, constant.name);
                WriteObject<TensorShape>(stream, constant.shape);
                Write(stream, (int)constant.dataType);
                Write(stream, offsetFromModelStartToLayer);

                // Recalculate all offsets to be global inside the model
                // this way weights can be stored in one block at the end of the file
                Write(stream, constant.length);
                offsetFromModelStartToLayer += constant.length;
            }

            WriteObject<string>(stream, model.IrSource);
            Write(stream, model.IrVersion);
            WriteObject<string>(stream, model.ProducerName);
            Write(stream, model.DefaultOpsetVersion);

            int numOpsetVersions = model.OpsetDescriptions.Count;
            Write(stream, numOpsetVersions);
            for (var i = 0; i < numOpsetVersions; ++i)
            {
                WriteObject<string>(stream, model.OpsetDescriptions[i].domain);
                Write(stream, model.OpsetDescriptions[i].version);
            }

            int numWarnings = model.Warnings.Count;
            Write(stream, numWarnings);
            for (var i = 0; i < numWarnings; ++i)
            {
                WriteObject<string>(stream, model.Warnings[i].LayerName);
                Write(stream, (int)model.Warnings[i].MessageSeverity);
                WriteObject<string>(stream, model.Warnings[i].Message);
            }

            int numMetadataProps = model.Metadata.Count;
            Write(stream, numMetadataProps);
            foreach (KeyValuePair<string, string> kvp in model.Metadata)
            {
                WriteObject<string>(stream, kvp.Key);
                WriteObject<string>(stream, kvp.Value);
            }

            int numParamDims = model.RemapNamedDims.Count;
            Write(stream, numParamDims);
            foreach (KeyValuePair<char, string> kvp in model.RemapNamedDims)
            {
                Write(stream, kvp.Key);
                WriteObject<string>(stream, kvp.Value);
            }

            Write(stream, model.LayerCPUFallback.Count);
            foreach (var name in model.LayerCPUFallback)
            {
                WriteObject<string>(stream, name);
            }

            Profiler.EndSample();
        }

        internal static void SaveModelWeights(List<MemoryStream> streams, Model model)
        {
            Profiler.BeginSample("Sentis.ModelWriter.SaveModelWeights");
            streams.Clear();
            streams.Add(new MemoryStream());

            int streamIndex = 0;
            MemoryStream stream = streams[streamIndex];

            long writtenLength = 0;
            // write constant data
            for (var l = 0; l < model.constants.Count; ++l)
            {
                var constant = model.constants[l];
                if (constant.weights == null)
                    continue;
                var sizeOfDataItem = constant.weights.SizeOfType;
                int memorySize = constant.length * sizeOfDataItem;
                if (writtenLength + (long)memorySize >= (long)Int32.MaxValue)
                {
                    streams.Add(new MemoryStream());
                    streamIndex++;
                    stream = streams[streamIndex];
                    writtenLength = 0;
                }
                writtenLength += memorySize;
                unsafe
                {
                    var src = model.constants[l].weights.AddressAt<byte>(constant.offset * sizeOfDataItem);
                    Span<byte> span = new Span<byte>(src, memorySize);
                    stream.Write(span);
                }
            }

            Profiler.EndSample();
        }

        static void Write<T>(MemoryStream memoryStream, T value) where T : unmanaged
        {
            unsafe
            {
                T* src = &value;
                Span<byte> arr = stackalloc byte[sizeof(T)]; // todo move out
                fixed (byte* dst = &arr[0])
                {
                    Buffer.MemoryCopy(src, dst, sizeof(T), sizeof(T));
                }
                memoryStream.Write(arr);
            }
        }

        static void WriteObject<T>(MemoryStream memoryStream, T obj)
        {
            var bf = new BinaryFormatter();
            bf.Serialize(memoryStream, obj);
        }
    }
} // namespace Unity.Sentis
