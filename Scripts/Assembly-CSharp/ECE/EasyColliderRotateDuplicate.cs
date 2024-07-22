using System;
using UnityEngine;

namespace ECE
{
	[Serializable]
	public class EasyColliderRotateDuplicate
	{
		public enum ROTATE_AXIS
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		public bool enabled;

		public ROTATE_AXIS axis;

		public int NumberOfDuplications;

		public float StartRotation;

		public float EndRotation;

		public GameObject pivot;

		public GameObject attachTo;
	}
}
