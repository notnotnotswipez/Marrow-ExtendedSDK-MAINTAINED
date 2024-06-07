using System;
using Unity.Collections;
using UnityEngine;

namespace Unity.Sentis {
/// <summary>
/// An interface that represents a device-dependent representation of the data in a tensor.
/// </summary>
public interface ITensorData : IDisposable
{
    /// <summary>
    /// Reserves memory for `count` elements.
    /// </summary>
    void Reserve(int count);

    /// <summary>
    /// Uploads the tensor data to internal storage.
    /// </summary>
    void Upload<T>(NativeArray<T> data, int srcCount, int srcOffset = 0) where T : unmanaged;

    /// <summary>
    /// Checks if asynchronous readback request it done.
    /// 
    /// Returns true if async readback is successful.
    /// </summary>
    bool IsAsyncReadbackRequestDone();

    /// <summary>
    /// Schedules asynchronous readback of the internal data.
    /// 
    /// Invokes callback when async readback is finished.
    /// 
    /// Boolean indicates if async readback is successful.
    /// </summary>
    void AsyncReadbackRequest(Action<bool> callback = null);

    /// <summary>
    /// Blocking call to make sure that internal data is correctly written to and available for CPU read back.
    /// </summary>
    void CompleteAllPendingOperations();

    /// <summary>
    /// Returns data from internal storage.
    /// </summary>
    NativeArray<T> Download<T>(int dstCount, int srcOffset = 0) where T : unmanaged;

    /// <summary>
    /// Returns a deep copy of the internal storage.
    /// </summary>
    ITensorData Clone();

    /// <summary>
    /// The maximum count of the stored data elements.
    /// </summary>
    int maxCapacity { get; }

    /// <summary>
    /// On what device backend are the data elements stored.
    /// </summary>
    DeviceType deviceType { get; }
}

public interface IReadableTensorData
{
    /// <summary>
    /// Returns a data element at `index`.
    /// </summary>
    T Get<T>(int index) where T : unmanaged;

    /// <summary>
    /// Sets `value` data element at `index`.
    /// </summary>
    void Set<T>(int index, T value) where T : unmanaged;

    /// <summary>
    /// Returns a ReadOnlySpan on the linear memory data.
    /// </summary>
    ReadOnlySpan<T> ToReadOnlySpan<T>(int dstCount, int srcOffset = 0) where T : unmanaged;

    /// <summary>
    /// Returns a ReadOnlyNativeArray handle on the linear memory data.
    /// </summary>
    NativeArray<T>.ReadOnly GetReadOnlyNativeArrayHandle<T>(int dstCount, int srcOffset = 0) where T : unmanaged;

    /// <summary>
    /// Returns a array that is a copy of the linear memory data.
    /// </summary>
    T[] ToArray<T>(int dstCount, int srcOffset = 0) where T : unmanaged;
}

} // namespace Unity.Sentis
