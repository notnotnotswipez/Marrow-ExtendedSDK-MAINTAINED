using UnityEngine;

namespace ECE
{
	public class BoxColliderData : EasyColliderData
	{
		public Vector3 Center;

		public Vector3 Size;

		public void Clone(BoxColliderData data)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
