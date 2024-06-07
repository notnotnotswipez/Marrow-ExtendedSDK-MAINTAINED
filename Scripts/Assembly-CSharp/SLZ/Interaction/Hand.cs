using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Hand : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Hand _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__68(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoDelayDestroyJoint_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isQuick;

			public Hand _003C_003E4__this;

			public Grip lastGrip;

			public ConfigurableJoint myJoint;

			private WaitForFixedUpdate _003Cwait_003E5__2;

			private JointDrive _003Cdrive_003E5__3;

			private float _003Ctime_003E5__4;

			private float _003Cduration_003E5__5;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoDelayDestroyJoint_003Ed__75(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoJointBreakCooldown_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Hand _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoJointBreakCooldown_003Ed__101(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		private static ComponentCache<Hand> _cache;

		public Action<HandReciever> onRecieverAttached;

		public Action<HandReciever> onRecieverDetached;

		public Action<HandReciever> onRecieverHoverBegin;

		public Action<HandReciever> onRecieverHoverEnd;

		public Action onRTSkeleFixedUpdateDelegate;

		public Action<Hand, Vector3> onAnchorUpdate;

		public Action<Hand, Vector3> onConnectedAnchorUpdate;

		private HandReciever _mHoveringReceiver;

		private HandReciever m_FarHoveringReciever;

		private GameObject m_CurrentAttachedGO;

		private const int m_ColliderArraySize = 128;

		private Collider[] m_OverlappingColliders;

		[SerializeField]
		private Collider[] m_HandColliders;

		private List<Collider> m_IgnoredColliders;

		private bool m_IsWarmup;

		public Collider collider;

		[HideInInspector]
		public Quaternion jointStartRotation;

		public ConfigurableJoint joint;

		public ConfigurableJoint tempJoint;

		[HideInInspector]
		public Rigidbody rb;

		[HideInInspector]
		public PhysHand physHand;

		[HideInInspector]
		public RigManager manager;

		public GameObject triggerRefProxyObject;

		public Handedness handedness;

		public Hand otherHand;

		public Transform palmPositionTransform;

		public LayerMask hoverLayerMask;

		public LayerMask farHoverLayerMask;

		public LayerMask playerLayerMask;

		public bool farHoverEnabled;

		private float _hoverSphereRadius;

		public HashSet<HandReciever> ignoredRecievers;

		private BaseController _controller;

		private SkeletonHand _skeleton;

		private HandPoseAnimator _animator;

		public InventorySlot slot;

		private ConfigurableJoint _forearmJoint;

		private ConfigurableJoint _upperarmJoint;

		private bool _isTriggerPulledOnAttach;

		private bool _indexButtonDown;

		private bool _indexButtonUp;

		private bool _indexButton;

		private float _indexTriggerAxis;

		public static ComponentCache<Hand> Cache => null;

		public float HoverSphereRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public BaseController Controller => null;

		public SkeletonHand Skeleton => null;

		public HandPoseAnimator Animator => null;

		public bool hoverLocked
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HandReciever AttachedReceiver
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

		public HandReciever HoveringReceiver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HandReciever farHoveringReciever
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool GrabLock
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__68))]
		private IEnumerator Start()
		{
			return null;
		}

		public void SetManager(RigManager m)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetGrabLock()
		{
		}

		public void AttachObject(GameObject objectToAttach)
		{
		}

		public void DetachJoint(bool isQuick = false, Grip lastGrip = null)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayDestroyJoint_003Ed__75))]
		private IEnumerator CoDelayDestroyJoint(ConfigurableJoint myJoint, bool isQuick, Grip lastGrip)
		{
			return null;
		}

		public void SetGripStrength(float perc)
		{
		}

		public SimpleTransform GetGripInHand()
		{
			return default(SimpleTransform);
		}

		public void UnignoreHostColliders(Grip grip)
		{
		}

		public void IgnoreHostColliders(Grip grip)
		{
		}

		public void PrepareJoint(GameObject objectToAttach, bool isSilent = false, Action OnBeforeAttach = null)
		{
		}

		public void AttachJoint(GameObject objectToAttach)
		{
		}

		public void AttachIgnoreBodyJoints(GameObject objectToAttach)
		{
		}

		public void DetachIgnoreBodyJoints()
		{
		}

		public void DisableCollider()
		{
		}

		public void EnableCollider()
		{
		}

		public void OnRTSkeleFixedUpdate()
		{
		}

		public void OnPhysRigEarlyUpdate()
		{
		}

		public void OnPhysRigUpdate()
		{
		}

		private static Quaternion SynthesizeRotation(Vector3 right, Vector3 up)
		{
			return default(Quaternion);
		}

		public float WristToForearmAngle()
		{
			return 0f;
		}

		public void DetachObject()
		{
		}

		private void UpdateHovering()
		{
		}

		public SimpleTransform GetHandleInWorld()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerWristTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(HandPose handPose, bool useSkeleOffset = false)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public bool HasAttachedObject()
		{
			return false;
		}

		public void HoverLock()
		{
		}

		public void HoverUnlock()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		[IteratorStateMachine(typeof(_003CCoJointBreakCooldown_003Ed__101))]
		private IEnumerator CoJointBreakCooldown()
		{
			return null;
		}

		private void CreateConfigurableJoint()
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3), ConfigurableJoint j = null)
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3))
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3), ConfigurableJoint j = null)
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3))
		{
		}

		private void EarlyUpdateHeldObjectInputs()
		{
		}

		private void SetIndexButtonAndTrigger()
		{
		}

		public bool GetIndexButtonDown()
		{
			return false;
		}

		public bool GetIndexButtonUp()
		{
			return false;
		}

		public bool GetIndexButton()
		{
			return false;
		}

		public float GetIndexTriggerAxis()
		{
			return 0f;
		}
	}
}
