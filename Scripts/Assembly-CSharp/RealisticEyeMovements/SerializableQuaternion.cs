using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public struct SerializableQuaternion
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public SerializableQuaternion(float rX, float rY, float rZ, float rW)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Quaternion(SerializableQuaternion rValue)
		{
			return default(Quaternion);
		}

		public static implicit operator SerializableQuaternion(Quaternion rValue)
		{
			return default(SerializableQuaternion);
		}
	}
}
