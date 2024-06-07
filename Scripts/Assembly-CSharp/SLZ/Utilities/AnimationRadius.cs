using System;
using UnityEngine;

namespace SLZ.Utilities
{
	[Serializable]
	public struct AnimationRadius
	{
		public float radius;

		public AnimationClip neutral;

		public AnimationClip[] pitchPositive;

		public AnimationClip[] pitchNegative;

		public AnimationClip[] rollPositive;

		public AnimationClip[] rollNegative;

		public AnimationClip[] yawPositive;

		public AnimationClip[] yawNegative;
	}
}
