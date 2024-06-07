using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RealisticEyeMovements
{
	public class EyeAndHeadAnimator : MonoBehaviour
	{
		private enum HeadControl
		{
			None = 0,
			Mecanim = 1,
			FinalIK = 2,
			Transform = 3
		}

		private enum HeadTweenMethod
		{
			SmoothDamping = 0,
			CriticalDamping = 1
		}

		private enum BlinkState
		{
			Idle = 0,
			Closing = 1,
			KeepingClosed = 2,
			Opening = 3
		}

		public enum HeadSpeed
		{
			Slow = 0,
			Fast = 1
		}

		public enum EyeDelay
		{
			Simultaneous = 0,
			EyesFirst = 1,
			HeadFirst = 2
		}

		private enum LookTarget
		{
			None = 0,
			StraightAhead = 1,
			ClearingTargetPhase1 = 2,
			ClearingTargetPhase2 = 3,
			GeneralDirection = 4,
			LookingAroundIdly = 5,
			SpecificThing = 6,
			Face = 7
		}

		private enum FaceLookTarget
		{
			EyesCenter = 0,
			LeftEye = 1,
			RightEye = 2,
			Mouth = 3
		}

		private const float kMaxLimitedHorizontalHeadAngle = 80f;

		private const float kMaxLimitedVerticalHeadAngle = 40f;

		private const float kMaxHorizViewAngle = 100f;

		private const float kMaxVertViewAngle = 60f;

		[HideInInspector]
		public float headSpeedModifier;

		[HideInInspector]
		public float headWeight;

		[HideInInspector]
		public Transform headBoneNonMecanimXform;

		private Quaternion headBoneNonMecanimFromRootQ;

		private const float kHeadJitterFrequency = 0.2f;

		private const float kHeadJitterAmount = 1f;

		private Vector3 headJitterRotationComponents;

		private const int kHeadJitterOctave = 3;

		private float headJitterTime;

		private Vector2[] headJitterNoiseVectors;

		private HeadControl headControl;

		private HeadTweenMethod headTweenMethod;

		public bool useMicroSaccades;

		public bool useMacroSaccades;

		public bool useHeadJitter;

		public bool kDrawSightlinesInEditor;

		public bool areUpdatedControlledExternally;

		[HideInInspector]
		public ControlData controlData;

		[Tooltip("Minimum seconds until next blink")]
		public float kMinNextBlinkTime;

		[Tooltip("Maximum seconds until next blink")]
		public float kMaxNextBlinkTime;

		[Range(0.1f, 3f)]
		[Tooltip("The blinking speed. Default is 1.")]
		public float blinkSpeed;

		[Tooltip("Whether the eyelids move up a bit when looking up and down when looking down.")]
		public bool eyelidsFollowEyesVertically;

		private bool useUpperEyelids;

		private bool useLowerEyelids;

		private float timeOfNextBlink;

		private BlinkState blinkState;

		private float blinkStateTime;

		private float blinkDuration;

		private bool isShortBlink;

		private const float kBlinkCloseTimeShort = 0.036f;

		private const float kBlinkOpenTimeShort = 0.072f;

		private const float kBlinkCloseTimeLong = 0.072f;

		private const float kBlinkOpenTimeLong = 0.144f;

		private const float kBlinkKeepingClosedTime = 0.008f;

		[Tooltip("Maximum horizontal eye angle (away from nose)")]
		public float maxEyeHorizAngle;

		[Tooltip("Maximum horizontal eye angle towards nose")]
		public float maxEyeHorizAngleTowardsNose;

		[Range(0f, 5f)]
		[Tooltip("Cross eye correction factor")]
		public float crossEyeCorrection;

		[Tooltip("The more nervous, the more often you do micro-and macrosaccades.")]
		[Range(0f, 10f)]
		public float nervousness;

		[Tooltip("Limits the angle for the head movement")]
		[Range(0f, 1f)]
		public float limitHeadAngle;

		private Transform leftEyeAnchor;

		private Transform rightEyeAnchor;

		private float leftMaxSpeedHoriz;

		private float leftHorizDuration;

		private float leftMaxSpeedVert;

		private float leftVertDuration;

		private float leftCurrentSpeedX;

		private float leftCurrentSpeedY;

		private float rightMaxSpeedHoriz;

		private float rightHorizDuration;

		private float rightMaxSpeedVert;

		private float rightVertDuration;

		private float rightCurrentSpeedX;

		private float rightCurrentSpeedY;

		private float startLeftEyeHorizDuration;

		private float startLeftEyeVertDuration;

		private float startLeftEyeMaxSpeedHoriz;

		private float startLeftEyeMaxSpeedVert;

		private float startRightEyeHorizDuration;

		private float startRightEyeVertDuration;

		private float startRightEyeMaxSpeedHoriz;

		private float startRightEyeMaxSpeedVert;

		private float timeOfEyeMovementStart;

		private float timeOfHeadMovementStart;

		private float headMaxSpeedHoriz;

		private float headMaxSpeedVert;

		private float headHorizDuration;

		private float headVertDuration;

		private float startHeadHorizDuration;

		private float startHeadVertDuration;

		private float startHeadMaxSpeedHoriz;

		private float startHeadMaxSpeedVert;

		private float currentHeadHorizSpeed;

		private float currentHeadVertSpeed;

		private float currentHeadZSpeed;

		private const float kMaxHeadVelocity = 2f;

		private const float kHeadOmega = 3.5f;

		private CritDampTweenQuaternion critDampTween;

		private Vector3 headEulerSpeed;

		private Vector3 lastHeadEuler;

		private float maxHeadHorizSpeedSinceSaccadeStart;

		private float maxHeadVertSpeedSinceSaccadeStart;

		private bool isHeadTracking;

		private float headTrackingFactor;

		private float headLatency;

		private float eyeLatency;

		private float ikWeight;

		private Animator animator;

		private bool hasLateUpdateRunThisFrame;

		private bool hasCheckedIdleLookTargetsThisFrame;

		private bool placeNewIdleLookTargetsAtNextOpportunity;

		private Transform currentHeadTargetPOI;

		private Transform currentEyeTargetPOI;

		private Transform nextHeadTargetPOI;

		private Transform nextEyeTargetPOI;

		private Transform currentTargetLeftEyeXform;

		private Transform currentTargetRightEyeXform;

		private Transform nextTargetLeftEyeXform;

		private Transform nextTargetRightEyeXform;

		private readonly Transform[] createdTargetXforms;

		private int createdTargetXformIndex;

		private Transform headTargetPivotXform;

		private Transform headXform;

		private Quaternion leftEyeRootFromAnchorQ;

		private Quaternion rightEyeRootFromAnchorQ;

		private Quaternion leftAnchorFromEyeRootQ;

		private Quaternion rightAnchorFromEyeRootQ;

		private Vector3 currentLeftEyeLocalEuler;

		private Vector3 currentRightEyeLocalEuler;

		private Quaternion originalLeftEyeLocalQ;

		private Quaternion originalRightEyeLocalQ;

		private Quaternion lastLeftEyeLocalRotation;

		private Quaternion lastRightEyeLocalQ;

		private Quaternion headBoneInAvatarQ;

		private Vector3 macroSaccadeTargetLocal;

		private Vector3 microSaccadeTargetLocal;

		private float timeOfEnteringClearingPhase;

		private float timeOfLastMacroSaccade;

		private float timeToMicroSaccade;

		private float timeToMacroSaccade;

		private bool isInitialized;

		private int lastFrameOfUpdate1;

		private int lastFrameOfUpdate2;

		private HeadSpeed headSpeed;

		private LookTarget lookTarget;

		private FaceLookTarget faceLookTarget;

		public float blink01
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float eyeDistance
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float eyeDistanceScale
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform eyesRootXform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform headParentXform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event Action OnCannotGetTargetIntoView
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnTargetDestroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnTargetOutOfSight
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnUpdate2Finished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void Blink(bool isShortBlink = true)
		{
		}

		public bool CanGetIntoView(Vector3 point)
		{
			return false;
		}

		public bool CanChangePointOfAttention()
		{
			return false;
		}

		public bool CanImportFromFile(string filename)
		{
			return false;
		}

		private void CheckIdleLookTargets()
		{
		}

		private void CheckLatencies()
		{
		}

		private void CheckMacroSaccades()
		{
		}

		private void CheckMicroSaccades()
		{
		}

		private float ClampLeftHorizEyeAngle(float angle)
		{
			return 0f;
		}

		private float ClampRightHorizEyeAngle(float angle)
		{
			return 0f;
		}

		public void ClearLookTarget()
		{
		}

		private void DrawSightlinesInEditor()
		{
		}

		public void ExportToFile(string filename)
		{
		}

		private Vector3 GetCurrentEyeTargetPos()
		{
			return default(Vector3);
		}

		private Vector3 GetCurrentHeadTargetPos()
		{
			return default(Vector3);
		}

		public Vector3 GetHeadDirection()
		{
			return default(Vector3);
		}

		public Vector3 GetLeftEyeDirection()
		{
			return default(Vector3);
		}

		private Vector3 GetLookTargetPosForSocialTriangle(FaceLookTarget playerFaceLookTarget)
		{
			return default(Vector3);
		}

		public Vector3 GetOwnEyeCenter()
		{
			return default(Vector3);
		}

		public Transform GetOwnEyeCenterXform()
		{
			return null;
		}

		private Vector3 GetOwnLookDirection()
		{
			return default(Vector3);
		}

		public Vector3 GetRightEyeDirection()
		{
			return default(Vector3);
		}

		public float GetStareAngleMeAtTarget(Vector3 target)
		{
			return 0f;
		}

		public float GetStareAngleTargetAtMe(Transform targetXform)
		{
			return 0f;
		}

		public void ImportFromFile(string filename)
		{
		}

		public void Initialize()
		{
		}

		public bool IsInView(Vector3 target)
		{
			return false;
		}

		public bool IsLookingAtFace()
		{
			return false;
		}

		private void LateUpdate()
		{
		}

		private float LimitHorizontalHeadAngle(float headAngle)
		{
			return 0f;
		}

		private float LimitVerticalHeadAngle(float headAngle)
		{
			return 0f;
		}

		public void LookAtFace(Transform eyeCenterXform, float headLatency = 0.075f)
		{
		}

		public void LookAtFace(Transform leftEyeXform, Transform rightEyeXform, Transform eyesCenterXform, float headLatency = 0.075f)
		{
		}

		public void LookAtSpecificThing(Transform poi, float headLatency = 0.075f)
		{
		}

		public void LookAtSpecificThing(Vector3 point, float headLatency = 0.075f)
		{
		}

		public void LookAroundIdly()
		{
		}

		public void LookAtAreaAround(Transform poi)
		{
		}

		public void LookAtAreaAround(Vector3 point)
		{
		}

		private void OnAnimatorIK()
		{
		}

		private void OnCreatedXformDestroyed(DestroyNotifier destroyNotifer)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void SetMacroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
		}

		private void SetMicroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
		}

		private void Start()
		{
		}

		private void StartEyeMovement(Transform targetXform = null, bool blinkIfEyesMoveEnough = true)
		{
		}

		private void StartHeadMovement(Transform targetXform = null)
		{
		}

		private void Update()
		{
		}

		public void Update1()
		{
		}

		public void Update2()
		{
		}

		private void UpdateBlinking()
		{
		}

		private void UpdateEyelids()
		{
		}

		private void UpdateEyeMovement()
		{
		}

		private void UpdateHeadMovement()
		{
		}
	}
}
