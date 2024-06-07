using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "New Hand Pose", menuName = "StressLevelZero/HandPose")]
	public class HandPose : ScriptableObject
	{
		[Serializable]
		public struct PoseDataGroup
		{
			public float radius;

			public PoseData[] poseArray;
		}

		[Serializable]
		public struct PoseData
		{
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
		}

		public Vector3 primaryAxis;

		public Vector3 secondaryAxis;

		public Vector3 wristOffset;

		public float swingRotationLimit;

		public float twistRotationLimit;

		public PoseDataGroup[] poseData;

		[SerializeField]
		public Quaternion leftOffsetRotation;

		[SerializeField]
		public Quaternion rightOffsetRotation;

		public static Quaternion leftArtToRigSpace;

		public static Quaternion rightArtToRigSpace;

		public Quaternion HandleSpace => default(Quaternion);
	}
}
