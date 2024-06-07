using System;
using UnityEngine;

namespace Unity.Sentis
{

/// <summary>
/// Provides extension methods for tensors.
/// </summary>
public static class TensorExtensions
{
    /// <summary>
    /// Returns the tensor data as a string.
    /// </summary>
    /// <param name="size">The number of elements to limit the data to.</param>
    static string DataToString(this Tensor X, int size = 32)
    {
        var str = "";
        switch (X)
        {
            case TensorFloat xFloat:
            {
                for (int i = 0; i < X.shape.length && i < size; ++i)
                {
                    str += xFloat[i];
                    str += " ";
                }

                break;
            }
            case TensorInt xInt:
            {
                for (int i = 0; i < X.shape.length && i < size; ++i)
                {
                    str += xInt[i];
                    str += " ";
                }

                break;
            }
        }
        if (X.shape.length > size)
            str += "...";
        return str;
    }

    /// <summary>
    /// Logs tensor data to the Console window.
    /// </summary>
    /// <param name="size">The number of elements to limit the data to.</param>
    public static void PrintDataPart(this Tensor X, int size, string msg = "")
    {
        if (msg.Length > 0)
            msg += " ";
        D.Log($"{msg} {X.DataToString(size)}");
    }
}
} // namespace Unity.Sentis
