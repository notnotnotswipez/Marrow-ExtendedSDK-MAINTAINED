using System.Collections.Generic;
using SLZ.Data;
using UnityEngine;

namespace SLZ.Interaction
{
	public class HandToGripState
	{
		public bool isIgnoreAnchorUpdate;

		public bool isStatic;

		public float dynamicFloat;

		public GripFlags gripFlags;

		public bool isActive;

		public HandPose handPose;

		public float poseRadius;

		public List<Coroutine> coroutines;

		public bool isIgnoreConnAnchorUpdate;

		public Quaternion targetRotationInBase;

		public Quaternion amplifyRotationInBase;

		public float posInFlippedBase;

		public float rotInFlippedBase;

		public float handSlideAccel;

		public float handSlideVel;

		public float lockedPosOffset;

		public float lockedRotOffset;

		public bool isSlideLocking;

		public bool hasHandleSwitchedToFree;

		public bool isZFlipped;
	}
}
