using System.Runtime.CompilerServices;

namespace BitOperators
{
	public static class BinaryOps
	{
		[MethodImpl(256)]
		public static bool IsBitSet(ulong bits, int ind)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsBitSet(uint bits, int ind)
		{
			return false;
		}

		[MethodImpl(256)]
		public static ulong SetBit(ulong bits, int ind)
		{
			return 0uL;
		}

		[MethodImpl(256)]
		public static ulong ClearBit(ulong bits, int ind)
		{
			return 0uL;
		}

		[MethodImpl(256)]
		public static uint StripLeastSigBits(uint bits, int nbBits)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint PadLeastSigBits(uint bits, int nbBits)
		{
			return 0u;
		}

		public static int FlipBitsInRange(ref int num, int start, int end)
		{
			return 0;
		}

		public static uint FlipBitsInRange(ref uint num, int start, int end)
		{
			return 0u;
		}

		public static uint UnsetBitsInRange(uint num, int start, int end)
		{
			return 0u;
		}
	}
}
