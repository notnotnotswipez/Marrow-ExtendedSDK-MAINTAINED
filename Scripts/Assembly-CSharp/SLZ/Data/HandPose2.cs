using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "NewHandPose2", menuName = "StressLevelZero/HandPose2")]
	public class HandPose2 : ScriptableObject
	{
		[Serializable]
		public struct PoseDataGroup
		{
			public float radius;

			public PoseData neutral;

			public PoseData[] pitchPositive;

			public PoseData[] pitchNegative;

			public PoseData[] rollPositive;

			public PoseData[] rollNegative;

			public PoseData[] yawPositive;

			public PoseData[] yawNegative;

			public PoseData[] poseArray;
		}

		[Serializable]
		public struct PoseData
		{
			public float angle;

			public Vector3 nativePry;

			public Quaternion thumb1;

			public Quaternion index1;

			public Quaternion middle1;

			public Quaternion ring1;

			public Quaternion pinky1;

			public float thumb2;

			public float thumb3;

			public float index2;

			public float index3;

			public float middle2;

			public float middle3;

			public float ring2;

			public float ring3;

			public float pinky2;

			public float pinky3;

			public float cup;

			[SerializeField]
			public SimpleTransform leftHandle;

			[SerializeField]
			public SimpleTransform invLeftHandle;

			[SerializeField]
			public SimpleTransform rightHandle;

			[SerializeField]
			public SimpleTransform invRightHandle;

			[SerializeField]
			public SimpleTransform leftArtHandle;

			[SerializeField]
			public SimpleTransform rightArtHandle;

			[SerializeField]
			public SimpleTransform invLeftArtHandle;

			[SerializeField]
			public SimpleTransform invRightArtHandle;
		}

		public static Quaternion leftArtToRigSpace;

		public static Quaternion rightArtToRigSpace;

		public Vector3 wristOffset;

		public Vector3 primaryAxis;

		public float swingRotationLimit;

		public Vector3 secondaryAxis;

		public float twistRotationLimit;

		public PoseDataGroup[] poseData;

		public Quaternion LeftOffsetRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Quaternion RightOffsetRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void OnEnable()
		{
		}
	}
}
