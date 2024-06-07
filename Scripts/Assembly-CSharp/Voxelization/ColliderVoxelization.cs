using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voxelization
{
	public class ColliderVoxelization
	{
		public float voxelSize;

		public int gridSize;

		public Collider collider;

		public ulong subNodes;

		public ulong testNodes;

		private Vector3 _newCenter;

		private Vector3 _bottomLeftCenterPos;

		private int _counter;

		public ColliderVoxelization(int gSize, float vSize, Collider colliderRef)
		{
		}

		public ColliderVoxelization(int gSize, float vSize, Vector3 position, Collider[] colliders)
		{
		}

		[MethodImpl(256)]
		public static bool IsBitSet(ulong bits, int ind)
		{
			return false;
		}

		public void VoxelizeAtPosition(Vector3 position)
		{
		}

		public void TestBitField()
		{
		}
	}
}
