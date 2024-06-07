using UnityEngine;

namespace SLZ.Utilities
{
	public static class PhysicsExtensions
	{
		public static void ToWorldSpaceBox(this BoxCollider box, out Vector3 center, out Vector3 halfExtents, out Quaternion orientation)
		{
			center = default(Vector3);
			halfExtents = default(Vector3);
			orientation = default(Quaternion);
		}

		private static Vector3 AbsVec3(Vector3 v)
		{
			return default(Vector3);
		}
	}
}
