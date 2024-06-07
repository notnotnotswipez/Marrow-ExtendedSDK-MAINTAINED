using System.Collections.Generic;

namespace Trees
{
	public class MinHashHeap : MinHeap
	{
		private readonly Dictionary<uint, int> _hash;

		public MinHashHeap(int heapSize)
			: base(0)
		{
		}

		public override void Add(uint key, float val)
		{
		}

		public override void Remove(float val)
		{
		}

		public override bool FindKey(uint key)
		{
			return false;
		}

		public override uint Poll()
		{
			return 0u;
		}

		protected override void BubbleUp(int checkInd)
		{
		}

		protected override void BubbleDown(int checkInd)
		{
		}

		private void HandleBubbling(int atInd)
		{
		}

		private static int GetParentInd(int ind)
		{
			return 0;
		}

		private static int GetLeftChildInd(int parentInd)
		{
			return 0;
		}

		private static int GetRightChildInd(int parentInd)
		{
			return 0;
		}

		public override void Clear()
		{
		}
	}
}
