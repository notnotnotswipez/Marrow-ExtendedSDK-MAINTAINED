using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class ControlData
	{
		[Serializable]
		public class ControlDataForExport
		{
			public EyeControl eyeControl;

			public EyelidBoneMode eyelidBoneMode;

			public string leftEyePath;

			public string rightEyePath;

			public float maxEyeUpBoneAngle;

			public float maxEyeDownBoneAngle;

			public float maxEyeUpEyeballAngle;

			public float maxEyeDownEyeballAngle;

			public bool isEyeBallDefaultSet;

			public bool isEyeBoneDefaultSet;

			public bool isEyeBallLookUpSet;

			public bool isEyeBoneLookUpSet;

			public bool isEyeBallLookDownSet;

			public bool isEyeBoneLookDownSet;

			public EyeRotationLimiter.EyeRotationLimiterForExport leftBoneEyeRotationLimiter;

			public EyeRotationLimiter.EyeRotationLimiterForExport rightBoneEyeRotationLimiter;

			public EyeRotationLimiter.EyeRotationLimiterForExport leftEyeballEyeRotationLimiter;

			public EyeRotationLimiter.EyeRotationLimiterForExport rightEyeballEyeRotationLimiter;

			public EyelidControl eyelidControl;

			public bool eyelidsFollowEyesVertically;

			public string upperEyeLidLeftPath;

			public string upperEyeLidRightPath;

			public string lowerEyeLidLeftPath;

			public string lowerEyeLidRightPath;

			public bool isEyelidBonesDefaultSet;

			public bool isEyelidBonesClosedSet;

			public bool isEyelidBonesLookUpSet;

			public bool isEyelidBonesLookDownSet;

			public EyelidRotationLimiter.EyelidRotationLimiterForExport upperLeftLimiter;

			public EyelidRotationLimiter.EyelidRotationLimiterForExport upperRightLimiter;

			public EyelidRotationLimiter.EyelidRotationLimiterForExport lowerLeftLimiter;

			public EyelidRotationLimiter.EyelidRotationLimiterForExport lowerRightLimiter;

			public float eyeWidenOrSquint;

			public EyelidPositionBlendshapeForExport[] blendshapesForBlinking;

			public EyelidPositionBlendshapeForExport[] blendshapesForLookingUp;

			public EyelidPositionBlendshapeForExport[] blendshapesForLookingDown;

			public BlendshapesConfigForExport[] blendshapesConfigs;

			public bool isEyelidBlendshapeDefaultSet;

			public bool isEyelidBlendshapeClosedSet;

			public bool isEyelidBlendshapeLookUpSet;

			public bool isEyelidBlendshapeLookDownSet;
		}

		public enum EyeControl
		{
			None = 0,
			MecanimEyeBones = 1,
			SelectedObjects = 2
		}

		public enum EyelidControl
		{
			None = 0,
			Bones = 1,
			Blendshapes = 2,
			MCS_Blendshapes = 3
		}

		public enum EyelidBoneMode
		{
			RotationAndPosition = 0,
			Rotation = 1,
			Position = 2
		}

		[Serializable]
		public class EyelidPositionBlendshapeForExport
		{
			public string skinnedMeshRendererPath;

			public float defaultWeight;

			public float positionWeight;

			public int index;

			public string name;

			public bool isUsedInEalierConfig;
		}

		[Serializable]
		public class EyelidPositionBlendshape
		{
			public SkinnedMeshRenderer skinnedMeshRenderer;

			public float defaultWeight;

			public float positionWeight;

			public int index;

			public string name;

			public bool isUsedInEalierConfig;

			public static bool CanImport(EyelidPositionBlendshapeForExport import, Transform startXform, EyelidControl eyelidControl)
			{
				return false;
			}

			public EyelidPositionBlendshapeForExport GetExport(Transform startXform)
			{
				return null;
			}

			public void Import(EyelidPositionBlendshapeForExport export, Transform startXform)
			{
			}
		}

		[Serializable]
		public class BlendshapesConfigForExport
		{
			public string skinnedMeshRendererPath;

			public int blendShapeCount;

			public string[] blendshapeNames;

			public float[] blendshapeWeights;
		}

		[Serializable]
		public class BlendshapesConfig
		{
			public SkinnedMeshRenderer skinnedMeshRenderer;

			public int blendShapeCount;

			public string[] blendshapeNames;

			public float[] blendshapeWeights;

			public static bool CanImport(BlendshapesConfigForExport import, Transform startXform)
			{
				return false;
			}

			public BlendshapesConfigForExport GetExport(Transform startXform)
			{
				return null;
			}

			public void Import(Transform startXform, BlendshapesConfigForExport import)
			{
			}
		}

		public EyeControl eyeControl;

		public Transform leftEye;

		public Transform rightEye;

		public float maxEyeUpBoneAngle;

		public float maxEyeDownBoneAngle;

		public float maxEyeUpEyeballAngle;

		public float maxEyeDownEyeballAngle;

		public bool isEyeBallDefaultSet;

		public bool isEyeBoneDefaultSet;

		public bool isEyeBallLookUpSet;

		public bool isEyeBoneLookUpSet;

		public bool isEyeBallLookDownSet;

		public bool isEyeBoneLookDownSet;

		[SerializeField]
		private EyeRotationLimiter leftBoneEyeRotationLimiter;

		[SerializeField]
		private EyeRotationLimiter rightBoneEyeRotationLimiter;

		[SerializeField]
		private EyeRotationLimiter leftEyeballEyeRotationLimiter;

		[SerializeField]
		private EyeRotationLimiter rightEyeballEyeRotationLimiter;

		public EyelidControl eyelidControl;

		public EyelidBoneMode eyelidBoneMode;

		public bool eyelidsFollowEyesVertically;

		public Transform upperEyeLidLeft;

		public Transform upperEyeLidRight;

		public Transform lowerEyeLidLeft;

		public Transform lowerEyeLidRight;

		public bool isEyelidBonesDefaultSet;

		public bool isEyelidBonesClosedSet;

		public bool isEyelidBonesLookUpSet;

		public bool isEyelidBonesLookDownSet;

		[SerializeField]
		private EyelidRotationLimiter upperLeftLimiter;

		[SerializeField]
		private EyelidRotationLimiter upperRightLimiter;

		[SerializeField]
		private EyelidRotationLimiter lowerLeftLimiter;

		[SerializeField]
		private EyelidRotationLimiter lowerRightLimiter;

		[Range(-1f, 1f)]
		[Tooltip("0: normal. 1: max widened, -1: max squint")]
		public float eyeWidenOrSquint;

		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForBlinking;

		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForLookingUp;

		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForLookingDown;

		[SerializeField]
		private BlendshapesConfig[] blendshapesConfigs;

		public bool isEyelidBlendshapeDefaultSet;

		public bool isEyelidBlendshapeClosedSet;

		public bool isEyelidBlendshapeLookUpSet;

		public bool isEyelidBlendshapeLookDownSet;

		public bool CanImport(ControlDataForExport import, Transform startXform)
		{
			return false;
		}

		public void CheckConsistency(Animator animator, EyeAndHeadAnimator eyeAndHeadAnimator)
		{
		}

		public float ClampLeftVertEyeAngle(float angle)
		{
			return 0f;
		}

		public float ClampRightVertEyeAngle(float angle)
		{
			return 0f;
		}

		public ControlDataForExport GetExport(Transform startXform)
		{
			return null;
		}

		public void Import(ControlDataForExport import, Transform startXform)
		{
		}

		public void Initialize(Transform startXform)
		{
		}

		private void LerpBlendshapeConfig(EyelidPositionBlendshape[] blendshapes, float lerpValue, bool relativeToCurrentValueIfUsedInOtherConfig = false)
		{
		}

		public bool NeedsSaveDefaultBlendshapeConfig()
		{
			return false;
		}

		public void OnDestroy()
		{
		}

		private void ResetBlendshapeConfig(EyelidPositionBlendshape[] blendshapes)
		{
		}

		private void ResetAllBlendshapesToDefault()
		{
		}

		public void RestoreClosed()
		{
		}

		public void RestoreDefault(bool withEyelids = true)
		{
		}

		public void RestoreLookDown()
		{
		}

		public void RestoreLookUp()
		{
		}

		private void SaveBlendshapesForEyelidPosition(ref EyelidPositionBlendshape[] blendshapesForPosition, UnityEngine.Object rootObject, string positionName)
		{
		}

		public void SaveClosed(UnityEngine.Object rootObject)
		{
		}

		public void SaveDefault(UnityEngine.Object rootObject)
		{
		}

		public void SaveLookDown(UnityEngine.Object rootObject)
		{
		}

		public void SaveLookUp(UnityEngine.Object rootObject)
		{
		}

		public void UpdateEyelids(float leftEyeAngle, float rightEyeAngle, float blink01, bool eyelidsFollowEyesVertically)
		{
		}
	}
}
