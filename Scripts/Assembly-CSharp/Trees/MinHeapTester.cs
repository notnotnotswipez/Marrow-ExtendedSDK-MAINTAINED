using UnityEngine;

namespace Trees
{
	public class MinHeapTester : MonoBehaviour
	{
		public float[] testData;

		public float[] heapData;

		public int removeIndex;

		public float removeValue;

		public MinHeap heap;

		[ContextMenu("Start MinHeap")]
		public void UseMinHeap()
		{
		}

		[ContextMenu("Poll MinHeap")]
		public void PollMinHeap()
		{
		}

		[ContextMenu("Clear MinHeap")]
		public void ClearMinHeap()
		{
		}

		[ContextMenu("Remove at Index")]
		public void RmvInd()
		{
		}

		private void RemoveAtIndex(int ind)
		{
		}

		[ContextMenu("Remove at Value")]
		public void RmvVal()
		{
		}

		private void RemoveAtValue(float value)
		{
		}
	}
}
