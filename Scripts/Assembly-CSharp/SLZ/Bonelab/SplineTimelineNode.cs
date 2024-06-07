using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[Serializable]
	public class SplineTimelineNode
	{
		public string name;

		public Color color;

		public bool oneShot;

		public UnityEvent nodeEvent;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
