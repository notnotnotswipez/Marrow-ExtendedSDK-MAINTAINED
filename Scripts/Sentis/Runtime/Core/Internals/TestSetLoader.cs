using System;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using System.IO.Compression;


namespace Unity.Sentis {

/// <summary>
/// Test set loading utility
/// </summary>
class TestSet
{
    JSONTestSet jsonTestSet;

    /// <summary>
    /// Create with JSON test set
    /// </summary>
    /// <param name="jsonTestSet">JSON test set</param>
    public TestSet(JSONTestSet jsonTestSet)
    {
        this.jsonTestSet = jsonTestSet;
    }

    /// <summary>
    /// Create `TestSet`
    /// </summary>
    public TestSet() { }

    /// <summary>
    /// Get output tensor count
    /// </summary>
    /// <returns></returns>
    public int GetOutputCount()
    {
        return jsonTestSet.outputs.Length;
    }

    /// <summary>
    /// Get output tensor data
    /// </summary>
    /// <param name="idx">tensor index</param>
    /// <returns>tensor data</returns>
    public byte[] GetOutputData(int idx = 0)
    {
        return jsonTestSet.outputs[idx].data;
    }

    /// <summary>
    /// Get output tensor dataType
    /// </summary>
    public DataType GetOutputDataType(int idx = 0)
    {
        return (DataType)jsonTestSet.outputs[idx].dataType;
    }

    /// <summary>
    /// Get output tensor name
    /// </summary>
    /// <param name="idx">tensor index</param>
    /// <returns>tensor name</returns>
    public string GetOutputName(int idx = 0)
    {
        string name = jsonTestSet.outputs[idx].name;
        return name.EndsWith(":0") ? name.Remove(name.Length - 2) : name;
    }

    /// <summary>
    /// Get input tensor count
    /// </summary>
    /// <returns></returns>
    public int GetInputCount()
    {
        return jsonTestSet.inputs.Length;
    }

    /// <summary>
    /// Get input tensor name
    /// </summary>
    /// <param name="idx">input tensor index</param>
    /// <returns>tensor name</returns>
    public string GetInputName(int idx = 0)
    {
        string name = jsonTestSet.inputs[idx].name;
        return name.EndsWith(":0") ? name.Remove(name.Length - 2) : name;
    }

    /// <summary>
    /// Get input tensor data
    /// </summary>
    /// <param name="idx">input tensor index</param>
    /// <returns>tensor data</returns>
    public byte[] GetInputData(int idx = 0)
    {
        return jsonTestSet.inputs[idx].data;
    }

    /// <summary>
    /// Get input tensor dataType
    /// </summary>
    public DataType GetInputDataType(int idx = 0)
    {
        return (DataType)jsonTestSet.inputs[idx].dataType;
    }

    /// <summary>
    /// Get input shape
    /// </summary>
    /// <param name="idx">input tensor index</param>
    /// <returns>input shape</returns>
    public TensorShape GetInputShape(int idx = 0)
    {
        return new TensorShape(jsonTestSet.inputs[idx].shape);
    }

    /// <summary>
    /// Get output tensor shape
    /// </summary>
    /// <param name="idx">output tensor index</param>
    /// <returns>tensor shape</returns>
    public TensorShape GetOutputShape(int idx = 0)
    {
        return new TensorShape(jsonTestSet.outputs[idx].shape);
    }

    /// <summary>
    /// Get inputs as `Tensor` dictionary
    /// </summary>
    /// <param name="inputs">dictionary to store results</param>
    /// <param name="batchCount">max batch count</param>
    /// <param name="fromBatch">start from batch</param>
    /// <returns>dictionary with input tensors</returns>
    public Dictionary<string, Tensor> GetInputsAsTensorDictionary(Dictionary<string, Tensor> inputs = null)
    {
        if (inputs == null)
            inputs = new Dictionary<string, Tensor>();

        for (var i = 0; i < GetInputCount(); i++)
            inputs[GetInputName(i)] = GetInputAsTensor(i);

        return inputs;
    }

    /// <summary>
    /// Get outputs as `Tensor` dictionary
    /// </summary>
    /// <param name="outputs">dictionary to store results</param>
    /// <param name="batchCount">max batch count</param>
    /// <param name="fromBatch">start from batch</param>
    /// <returns>dictionary with input tensors</returns>
    /// <exception cref="Exception">thrown if called on raw test set (only JSON test set is supported)</exception>
    public Dictionary<string, Tensor> GetOutputsAsTensorDictionary(Dictionary<string, Tensor> outputs = null)
    {
        if (outputs == null)
            outputs = new Dictionary<string, Tensor>();

        for (var i = 0; i < GetOutputCount(); i++)
            outputs[GetOutputName(i)] = GetOutputAsTensor(i);

        return outputs;
    }

    /// <summary>
    /// Get input as `Tensor`
    /// </summary>
    /// <param name="idx">input index</param>
    /// <param name="batchCount">max batch count</param>
    /// <param name="fromBatch">start from batch</param>
    /// <returns>`Tensor`</returns>
    /// <exception cref="Exception">thrown if called on raw test set (only JSON test set is supported)</exception>
    public Tensor GetInputAsTensor(int idx = 0)
    {
        TensorShape shape = GetInputShape(idx);
        var array = GetInputData(idx);

        DataType dataType = GetInputDataType(idx);

        var data = new ArrayTensorData(shape);
        NativeTensorArray.Copy(array, data.array, shape.length);

        switch (dataType)
        {
            case DataType.Float:
            {
                return new TensorFloat(shape, data);
            }
            case DataType.Int:
            {
                return new TensorInt(shape, data);
            }
            default:
                throw new NotImplementedException($"DataType {dataType} not supported");
        }
    }

    /// <summary>
    /// Get output as `Tensor`
    /// </summary>
    /// <param name="idx">output index</param>
    /// <param name="batchCount">max batch count</param>
    /// <param name="fromBatch">start from batch</param>
    /// <returns>`Tensor`</returns>
    /// <exception cref="Exception">thrown if called on raw test set (only JSON test set is supported)</exception>
    public Tensor GetOutputAsTensor(int idx = 0)
    {
        TensorShape shape = GetOutputShape(idx);
        var array = GetOutputData(idx);

        DataType dataType = GetOutputDataType(idx);

        var data = new ArrayTensorData(shape);
        NativeTensorArray.Copy(array, data.array, shape.length);

        switch (dataType)
        {
            case DataType.Float:
            {
                return new TensorFloat(shape, data);
            }
            case DataType.Int:
            {
                return new TensorInt(shape, data);
            }
            default:
                throw new NotImplementedException($"DataType {dataType} not supported");
        }
    }
}

/// <summary>
/// JSON test structure
/// </summary>
[Serializable]
class JSONTestSet
{
    /// <summary>
    /// Inputs
    /// </summary>
    public JSONTensor[] inputs;

    /// <summary>
    /// Outputs
    /// </summary>
    public JSONTensor[] outputs;
}

/// <summary>
/// JSON tensor
/// </summary>
[Serializable]
class JSONTensor
{
    /// <summary>
    /// Name
    /// </summary>
    public string name;

    /// <summary>
    /// dataType
    /// </summary>
    public int dataType;

    /// <summary>
    /// Shape
    /// </summary>
    public int[] shape;

    /// <summary>
    /// Tensor type
    /// </summary>
    public string type;

    /// <summary>
    /// Tensor data
    /// </summary>
    public byte[] data;
}

/// <summary>
/// Test set loader
/// </summary>
class TestSetLoader
{
    /// <summary>
    /// Load test set from file
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>`TestSet`</returns>
    public static TestSet Load(string filename)
    {
        if (filename.ToLower().EndsWith(".gz"))
            return LoadGZ(filename);

        return LoadJSON(filename);
    }

    /// <summary>
    /// Load GZ
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>`TestSet`</returns>
    public static TestSet LoadGZ(string filename)
    {
        var jsonFileName = filename.Substring(0, filename.Length - 3);
        var sourceArchiveFileName = Path.Combine(Application.streamingAssetsPath, "TestSet", filename);
        var destinationDirectoryName = sourceArchiveFileName.Substring(0, sourceArchiveFileName.Length - 3);

        FileInfo fileToDecompress = new FileInfo(sourceArchiveFileName);
        using (FileStream originalFileStream = fileToDecompress.OpenRead())
        {
            using (FileStream decompressedFileStream = File.Create(destinationDirectoryName))
            {
                using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
        }

        return LoadJSON(jsonFileName);
    }

    /// <summary>
    /// Load JSON
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>`TestSet`</returns>
    public static TestSet LoadJSON(string filename)
    {
        string json = "";

        if (filename.EndsWith(".json"))
            json = File.ReadAllText(Path.Combine(Application.streamingAssetsPath, "TestSet", filename));
        else
            json = Resources.Load<TextAsset>($"TestSet/{filename}").text;

        TestSet result = new TestSet(JsonUtility.FromJson<JSONTestSet>(json));
        return result;
    }

    /// <summary>
    /// Load image
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>`Texture`</returns>
    public static Texture LoadImage(string filename)
    {
        string fullpath = Path.Combine(Application.streamingAssetsPath, "TestSet", filename);

        var bytes = File.ReadAllBytes(fullpath);
        var tex = new Texture2D(2, 2);
        ImageConversion.LoadImage(tex, bytes, false); // LoadImage will auto-resize the texture dimensions
        tex.wrapMode = TextureWrapMode.Clamp;
        return tex;
    }

    /// <summary>
    /// Load float array
    /// </summary>
    /// <param name="file">binary file reader</param>
    /// <returns>float array</returns>
    public static float[] LoadFloatArray(BinaryReader file)
    {
        Int64 dataLength = file.ReadInt64();
        float[] array = new float[dataLength];
        byte[] bytes = file.ReadBytes(Convert.ToInt32(dataLength * sizeof(float))); // @TODO: support larger than MaxInt32 data blocks
        Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);

        return array;
    }

    /// <summary>
    /// Open file with binary reader
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>`BinaryReader`</returns>
    static BinaryReader Open(string filename)
    {
        return new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
    }
}


} // namespace Unity.Sentis
