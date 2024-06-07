using System;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace SLZ.Rig
{
	public class OpenControllerRig : ControllerRig
	{
		private enum TrackedState
		{
			Untracked = 0,
			Tracked = 1,
			BlendingToUntracked = 2,
			BlendingToTracked = 3
		}

		public enum DirectionMode
		{
			Controller = 0,
			Head = 1,
			Custom = 2
		}

		public enum CurveMode
		{
			Linear = 0,
			Poles = 1,
			GenesisDpad = 2,
			Dpad = 3,
			SmoothGenesis = 4,
			SmoothDpad = 5
		}

		public enum VrVertState
		{
			Stand = 0,
			Crouch = 1,
			Sit = 2,
			Kneel = 3,
			Prone = 4
		}

		public bool drawDebugBodyBones;

		protected bool _hasAssignedOffsets;

		private Vector3 _averageSkullLocal;

		[Header("Tracked Points")]
		public Transform headset;

		public Transform trackedChest;

		public Transform trackedShoulderLf;

		public Transform trackedShoulderRt;

		public Transform trackedElbowLf;

		public Transform trackedElbowRt;

		public Transform trackedPelvis;

		public Transform trackedKneeLf;

		public Transform trackedKneeRt;

		public Transform trackedFootLf;

		public Transform trackedFootRt;

		public Transform vrRoot;

		[Header("Trackers")]
		public Transform trackerChest;

		public Transform trackerUpperArmLf;

		public Transform trackerUpperArmRt;

		public Transform trackerLowerArmLf;

		public Transform trackerLowerArmRt;

		public Transform trackerPelvis;

		public Transform trackerKneeLf;

		public Transform trackerKneeRt;

		public Transform trackerFootLf;

		public Transform trackerFootRt;

		public bool isRightHanded;

		public bool quickmenuEnabled;

		public Camera[] cameras;

		public UnityEvent OnLastCameraUpdate;

		private readonly SimpleTransform OculusHandOffsetLf;

		private readonly SimpleTransform OculusHandOffsetRt;

		private bool _hasLeftHandOffset;

		private SimpleTransform leftHandOffset;

		private bool _hasRightHandOffset;

		private SimpleTransform rightHandOffset;

		private bool _isPlatformPaused;

		private SimpleTransform _lastHmdLocal;

		private SimpleTransform _lastContLfLocal;

		private SimpleTransform _lastContRtLocal;

		private SimpleTransform _contLfOffset;

		private SimpleTransform _contRtOffset;

		private SimpleTransform _headsetOffset;

		private float _contLfBlend;

		private float _contRtBlend;

		private float _headsetBlend;

		private float _contLfVelocity;

		private float _contRtVelocity;

		private float _headsetVelocity;

		private float _contLfTime;

		private float _contRtTime;

		private float _headsetTime;

		private Vector3 _lastHmdInput;

		private Vector3 _hmdVel;

		private Vector3 _hmdAccel;

		private Vector3 _hmdGimbalOffset;

		private Quaternion _swungHeadLerp;

		private TrackedState _contLfState;

		private TrackedState _contRtState;

		private TrackedState _headsetState;

		private float _jogCoolTime;

		public Vector3 testOffsetDir;

		public float frequencyMult;

		public static Action<bool> OnPauseStateChange;

		[Header("Steam Vars")]
		public AnimationCurve curve_Linear;

		public AnimationCurve curve_Poles;

		public AnimationCurve curve_Genesis;

		public AnimationCurve curve_Dpad;

		public AnimationCurve curve_SmoothGenesis;

		public AnimationCurve curve_SmoothDpad;

		protected AnimationCurve touchPadCurve;

		[Space(10f)]
		public float degreesPerSnap;

		public int snapDegreesPerFrame;

		public VrVertState vrVertState;

		public DirectionMode directionMode;

		public CurveMode curveMode;

		public Transform CustomDirection;

		protected Transform directionMasterTransform;

		private Vector2 _doubleFlickMem;

		private float _lastFlickTime;

		private bool _wasOverFlickThresh;

		private float _turnVel;

		private float _smoothInput;

		private bool _lockViveJump;

		private double _lastFixedTime;

		private Vector3 _lastHeadVel;

		private Vector3 _lastHeadFwd;

		private float _lastTwistVel;

		private int leftAdjustMode;

		private int leftAdjustDir;

		private SimpleTransform leftOffsetBuffer;

		private int rightAdjustMode;

		private int rightAdjustDir;

		private SimpleTransform rightOffsetBuffer;

		private SimpleTransform lPointerInPalmOffset;

		private SimpleTransform rPointerInPalmOffset;

		private float _timeInputTimer;

		private bool _timeInput;

		public AudioClip decelTime;

		public AudioClip accelTime;

		private bool _secondaryFlickReady;

		private float _twistDebt;

		private float _twistDebtVel;

		[Header("RealHeptaRig")]
		[SerializeField]
		private RealHeptaAvatar _player;

		private float _adaptiveY;

		private float _adaptiveJuice;

		private SimpleTransform _trackedChestOffset;

		private SimpleTransform _trackedPelvisOffset;

		private SimpleTransform _trackedFootLfOffset;

		private SimpleTransform _trackedFootRtOffset;

		private Vector3 _lastChest;

		private Vector3 _chestGimbalVel;

		private Vector3 _chestGimbleAccel;

		private Vector3 _chestGimbalOffset;

		private Vector3 _lastPelvis;

		private Vector3 _pelvisGimbalVel;

		private Vector3 _pelvisGimbleAccel;

		private Vector3 _pelvisGimbalOffset;

		private Vector3 _lastFootLf;

		private Vector3 _footLfGimbalVel;

		private Vector3 _footLfGimbleAccel;

		private Vector3 _footLfGimbalOffset;

		private Vector3 _lastFootRt;

		private Vector3 _footRtGimbalVel;

		private Vector3 _footRtGimbleAccel;

		private Vector3 _footRtGimbalOffset;

		protected bool CooledJogTog => false;

		public SimpleTransform lastHmdLocal
		{
			get
			{
				return default(SimpleTransform);
			}
			set
			{
			}
		}

		public RealHeptaAvatar player => null;

		[ContextMenu("Assign Pucks -> Capture Offsets")]
		public void AssignTrackingPucks()
		{
		}

		private void RefreshBodyTrack()
		{
		}

		public void CaptureTrackedOffsets()
		{
		}

		public override void OnAwake()
		{
		}

		private void OnMarrowReady()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		private bool CheckHeadsetLimits()
		{
			return false;
		}

		private void ProcessTrackedBlend(Transform output, SimpleTransform target, bool tracked, ref TrackedState state, ref SimpleTransform offset, ref float blend, ref float velocity, ref float time)
		{
		}

		private (SimpleTransform, float, float, float) SnapshotOffset(SimpleTransform target, Transform output)
		{
			return default((SimpleTransform, float, float, float));
		}

		private void BlendOffset(Transform output, SimpleTransform target, float time, SimpleTransform offset, ref float blend, ref float velocity)
		{
		}

		private void ProcessesWristOffset()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
		{
		}

		private void OnDestroy()
		{
		}

		private void TimeInput(bool down, bool up, bool touch)
		{
		}

		private bool MagnitudeRemapAxis(Vector2 axis, float minLerp, float maxLerp, out Vector2 axisProcessed)
		{
			axisProcessed = default(Vector2);
			return false;
		}

		private bool CheckDoubleFlick(Vector2 axis, float time, ref Vector2 doubleFlickMem, ref float lastFlickTime, ref bool wasOverFlickThresh)
		{
			return false;
		}

		private void ProcessSecondaryTouchpad(Vector2 axis, out Vector2 secondaryAxis, out bool secondaryAButtonHold)
		{
			secondaryAxis = default(Vector2);
			secondaryAButtonHold = default(bool);
		}

		private Vector2 TouchPadCurve(Vector2 axis, AnimationCurve curve)
		{
			return default(Vector2);
		}

		public void SetDirectionMasterTransform(DirectionMode directionMode)
		{
		}

		public void SetTouchPadCurve(CurveMode curveMode)
		{
		}

		private void KnollFilter(Transform filter, Vector3 trackedPos, Quaternion trackedRot, float maxMillimeters, float maxDegreesSwing)
		{
		}

		private void SnapRotate(bool inputPressed, float deltaTime, float x = 0f)
		{
		}

		private void SmoothRotate(float input, float deltaTime)
		{
		}

		private (float, float, bool) ProcessSecondaryThumbstick(Vector2 axis, float deltaTime)
		{
			return default((float, float, bool));
		}

		public override void Reset()
		{
		}

		private void OnRealHeptaAwake()
		{
		}

		private void OnRealHeptaEarlyUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		private void UpdateHeptaBody(float deltaTime)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}
	}
}
