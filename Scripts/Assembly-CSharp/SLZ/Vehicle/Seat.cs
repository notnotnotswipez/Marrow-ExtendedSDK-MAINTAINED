using System;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Vehicle
{
	public class Seat : MonoBehaviour
	{
		private enum SeatState
		{
			Ingress = 0,
			Seated = 1,
			Egress = 2
		}

		private enum AxisAssignment
		{
			LeanFwdBack = 0,
			LeanLeftRight = 1,
			TurnLeftRight = 2,
			UpDownInSeat = 3,
			None = 4
		}

		private const float maxTwistViaInput = 45f;

		public Rigidbody seatRb;

		public Transform footLf;

		public Transform footRt;

		public Vector3 minSeatBounds;

		public Vector3 maxSeatBounds;

		public bool frontIngress;

		public bool leftIngress;

		public bool rightIngress;

		public bool blockUnseatAction;

		[Tooltip("x = flexion, y = rotation, z = lateral flexion, w = extension")]
		public Vector4 spineRom;

		[SerializeField]
		[HideInInspector]
		private AxisAssignment primaryUpDown;

		[HideInInspector]
		[SerializeField]
		private AxisAssignment primaryLeftRight;

		[SerializeField]
		[HideInInspector]
		private AxisAssignment secondaryUpDown;

		[SerializeField]
		[HideInInspector]
		private AxisAssignment secondaryLeftRight;

		private RigManager _rig;

		private ConfigurableJoint _buttJoint;

		private ConfigurableJoint _footJoint;

		private bool _ingressAligned;

		private bool _avatarSwitchedThisPhysStep;

		private float _egressVelocity;

		private Vector2 _primaryAxis;

		private Vector2 _secondaryAxis;

		private Vector3 _ingressReelVelocity;

		private Vector3 _physicalSpineDisplaceInWorld;

		private Vector3 _buttOffset;

		private Vector3 _neutralThorLumbar;

		private Vector3 _locoOffsetInSeat;

		private Vector3 _locoTargetInSeat;

		private Vector3 _locoVelocity;

		private Vector3 _lastPostSpineOffsetWorld;

		private Vector3 _lastPostSpineFeetPosWorld;

		private Vector3 _lastPreSpineInSeat;

		private float _twistOffset;

		private float _twistTarget;

		private float _twistVelocity;

		private float _twistCorrection;

		private float _ingressSmoothTime;

		private Quaternion _initialRotation;

		private Quaternion _eyeNeutralInVrRoot;

		private SimpleTransform _buttInSeat;

		private SimpleTransform _ingressReelInSeat;

		private SimpleTransform _footLfInSeat;

		private SimpleTransform _footRtInSeat;

		private SimpleTransform _lastSeat;

		private VirtualControllerOverride _activeIngressVc1;

		private VirtualControllerOverride _activeIngressVc2;

		private bool _sameFrameHold;

		private SeatState seatState;

		private const float kEpsilon = 1E-06f;

		public float ingressSmoothTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float seatedPercent
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

		public RigManager rigManager => null;

		public ConfigurableJoint buttJoint => null;

		public Vector3 buttTargetInWorld => default(Vector3);

		public Vector3 physicalSpineDisplaceInWorld => default(Vector3);

		public bool seated => false;

		public event Action RegisteredEvent
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

		public event Action DeRegisteredEvent
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

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleSeatLock(bool locked)
		{
		}

		public void IngressRig(RigManager rigManager)
		{
		}

		public void EgressRig(bool immediate)
		{
		}

		public bool TeleportRigToSeat(RigManager rigManager)
		{
			return false;
		}

		private void Register(RigManager rM)
		{
		}

		protected virtual void DeRegister()
		{
		}

		public void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public virtual void OnPlayerEarlyUpdate()
		{
		}

		public virtual bool OnPlayerAbstractInput(Vector2 primaryAxis, Vector2 secondaryAxis)
		{
			return false;
		}

		public virtual Vector3 OnPlayerPreSpine(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, float deltaTime, out SimpleTransform pelvisTarget)
		{
			pelvisTarget = default(SimpleTransform);
			return default(Vector3);
		}

		public virtual Vector3 OnPlayerPostSpine(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, float deltaTime, ref SimpleTransform feet)
		{
			return default(Vector3);
		}

		public virtual void OnBeingFixedUpdate(SimpleTransform pelvis, float deltaTime)
		{
		}

		public virtual void OnPlayerAfterFixedUpdate()
		{
		}

		public virtual void OnPlayerUpdate()
		{
		}

		public virtual (SimpleTransform, SimpleTransform) OnPlayerPreArt()
		{
			return default((SimpleTransform, SimpleTransform));
		}

		private Vector3 IngressBlend(float deltaTime)
		{
			return default(Vector3);
		}

		private bool EgressBlend(float deltaTime, out Vector3 egressDelta)
		{
			egressDelta = default(Vector3);
			return false;
		}

		private Vector3 TetherVector3(Vector3 delta, Vector3 position, Vector3 minBound, Vector3 maxBound)
		{
			return default(Vector3);
		}

		private float TetherFloat(float delta, float position, float minBound, float maxBound)
		{
			return 0f;
		}

		private float GetSwingRom(Vector2 axisNormed, out Vector2 xzLimits)
		{
			xzLimits = default(Vector2);
			return 0f;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
