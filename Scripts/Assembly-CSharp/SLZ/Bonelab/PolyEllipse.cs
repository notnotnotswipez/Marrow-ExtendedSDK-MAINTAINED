using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class PolyEllipse
	{
		public Transform root;

		public Transform front;

		public Transform back;

		public Transform left;

		public Transform leftFront;

		public Transform leftBack;

		public Transform right;

		public Transform rightFront;

		public Transform rightBack;

		public Vector3 frontOrigin;

		public Vector3 backOrigin;

		public Vector3 leftOrigin;

		public Vector3 rightOrigin;

		public void SetOrigin()
		{
		}
	}
}
