using UnityEngine;

namespace ECE
{
	public class EasyColliderData
	{
		public CREATE_COLLIDER_TYPE ColliderType;

		public bool IsValid;

		public Matrix4x4 Matrix;

		public void Clone(EasyColliderData data)
		{
		}
	}
}
