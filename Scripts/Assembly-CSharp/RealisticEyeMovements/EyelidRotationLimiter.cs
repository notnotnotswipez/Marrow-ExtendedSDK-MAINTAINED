using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class EyelidRotationLimiter
	{
		[Serializable]
		public class EyelidRotationLimiterForExport
		{
			public string transformPath;

			public SerializableQuaternion defaultQ;

			public SerializableQuaternion closedQ;

			public SerializableQuaternion lookUpQ;

			public SerializableQuaternion lookDownQ;

			public float eyeMaxDownAngle;

			public float eyeMaxUpAngle;

			public SerializableVector3 defaultPos;

			public SerializableVector3 closedPos;

			public SerializableVector3 lookUpPos;

			public SerializableVector3 lookDownPos;

			public bool isLookUpSet;

			public bool isLookDownSet;

			public bool isDefaultPosSet;

			public bool isClosedPosSet;

			public bool isLookUpPosSet;

			public bool isLookDownPosSet;
		}

		[SerializeField]
		private Transform transform;

		[SerializeField]
		private Quaternion defaultQ;

		[SerializeField]
		private Quaternion closedQ;

		[SerializeField]
		private Quaternion lookUpQ;

		[SerializeField]
		private Quaternion lookDownQ;

		[SerializeField]
		private float eyeMaxDownAngle;

		[SerializeField]
		private float eyeMaxUpAngle;

		[SerializeField]
		private Vector3 defaultPos;

		[SerializeField]
		private Vector3 closedPos;

		[SerializeField]
		private Vector3 lookUpPos;

		[SerializeField]
		private Vector3 lookDownPos;

		[SerializeField]
		private bool isLookUpSet;

		[SerializeField]
		private bool isLookDownSet;

		[SerializeField]
		private bool isDefaultPosSet;

		[SerializeField]
		private bool isClosedPosSet;

		[SerializeField]
		private bool isLookUpPosSet;

		[SerializeField]
		private bool isLookDownPosSet;

		public bool CanImport(EyelidRotationLimiterForExport import, Transform startXform)
		{
			return false;
		}

		public EyelidRotationLimiterForExport GetExport(Transform startXform)
		{
			return null;
		}

		public void GetRotationAndPosition(float eyeAngle, float blink01, float eyeWidenOrSquint, bool isUpper, out Quaternion rotation, ref Vector3 position, ControlData.EyelidBoneMode eyelidBoneMode)
		{
			rotation = default(Quaternion);
		}

		public void Import(EyelidRotationLimiterForExport import, Transform startXform)
		{
		}

		public void RestoreClosed(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		public void RestoreDefault(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		public void RestoreLookDown(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		public void RestoreLookUp(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		public void SaveClosed()
		{
		}

		public void SaveDefault(Transform t)
		{
		}

		public void SaveLookDown(float eyeMaxDownAngle)
		{
		}

		public void SaveLookUp(float eyeMaxUpAngle)
		{
		}
	}
}
