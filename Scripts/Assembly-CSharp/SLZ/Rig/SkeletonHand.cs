using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class SkeletonHand : MonoBehaviour
	{
		private const float maxHoverDisplaceArmLengths = 0.18f;

		private const float maxHoverDegreesDisplace = 10f;

		private const float softLimitArmLengths = 0.18f;

		private const float hardLimitArmLengths = 0.58f;

		private const float softLimitDegrees = 16f;

		private const float hardLimitDegrees = 142f;

		[HideInInspector]
		public HandPoseAnimator animator;

		public Handedness handedness;

		private SimpleTransform _lastHandInChest;

		private Quaternion _lastChestRot;

		private SimpleTransform _overrideTransform;

		private SimpleTransform _overrideHoverTransform;

		private SimpleTransform _offsetHoverTransform;

		private float _offsetBlend;

		private float _artificialDelta;

		private float _artDelVelocity;

		private float _artificialDeltaAng;

		private float _artDelAngVelocity;

		private SimpleTransform _offsetTransform;

		private bool _isOffsetDirty;

		private bool _isOffsetOverride;

		private bool _isHoverDirty;

		[SerializeField]
		private GameWorldSkeletonRig virtualHeptaRig;

		private const float passiveHoverArmlengths = 0.036f;

		private const float passiveHoverDegreesAdded = 8f;

		private const float maxSnatchArmlengths = 0.45f;

		private const float reelHandSizeYs = 0.88f;

		private const float maxSnatchDegreeOffset = 45f;

		private bool _isMovingToTarget;

		private HandGripPair _movePair;

		private bool _isHovering;

		private HandGripPair _hoverPair;

		private bool _isGrabbingOnHover;

		private SimpleTransform _handTarget;

		private Vector3 _lastRelPos;

		private float _perc;

		private float _jerk;

		private float _accel;

		private float _pSpeed;

		private float _distance;

		private float _rSpeed;

		private bool _syncHold;

		private float _syncTimer;

		private float _syncDistance;

		private bool _isSynced;

		private float _forwardProjectSeconds;

		public SimpleTransform OffsetTransform => default(SimpleTransform);

		public void OverrideHoverTranform(Vector3 position, Quaternion rotation)
		{
		}

		public void AddArtificialDelta(float artificialDelta, float artificialDeltaAng)
		{
		}

		public void SetArtificialDelta(float artificialDelta, float artificialDeltaAng, float artificialDeltaVelocity, float artificialDeltaAngVelocity)
		{
		}

		public void SetArtificialDeltaVelocity(float artDelVel)
		{
		}

		public void OverrideTransform(Vector3 position, Quaternion rotation, float perc = 1f)
		{
		}

		public void ProcessTransform(Vector3 position, Quaternion rotation, SimpleTransform relativeTran, float deltaTime)
		{
		}

		public float CalculateDelta(Vector3 position, Quaternion rotation, ref SimpleTransform lastTransform, out float rotDelta)
		{
			rotDelta = default(float);
			return 0f;
		}

		public SimpleTransform LimitOffset(SimpleTransform delta, float posSoftLimit, float posHardLimit, float angSoftLimit, float angHardLimit, ref float artificialDelta, ref float artificialAngDelta, ref float artificialDeltaVel, ref float artificialDeltaAngVel)
		{
			return default(SimpleTransform);
		}

		public bool IsSnatching()
		{
			return false;
		}

		public void StartMoveHandToTarget(Hand hand, Grip grip)
		{
		}

		public void StopMoveHandToTarget()
		{
		}

		private void MoveHandToTarget()
		{
		}

		private bool ReelInJoint(Hand hand, Grip grip, SimpleTransform gripTarget, SLZ.VRMK.Avatar avatar)
		{
			return false;
		}

		public void OnGripHoverStart(Hand hand, Grip grip)
		{
		}

		public void OnGripHoverBlend()
		{
		}

		public void OnGripHoverEnd()
		{
		}
	}
}
