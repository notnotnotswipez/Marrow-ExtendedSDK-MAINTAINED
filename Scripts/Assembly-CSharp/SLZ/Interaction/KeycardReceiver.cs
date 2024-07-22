using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class KeycardReceiver : InteractionReciever
	{
		[Flags]
		public enum Code
		{
			CODE_A = 1,
			CODE_B = 2,
			CODE_C = 4,
			CODE_D = 8,
			CODE_E = 0x10,
			CODE_F = 0x20,
			CODE_G = 0x40,
			CODE_H = 0x80,
			CODE_I = 0x100,
			CODE_J = 0x200,
			CODE_K = 0x400
		}

		private enum _States
		{
			EMPTY = 0,
			SWITCHING = 1,
			EJECTING = 2,
			HOVERING = 3,
			INSERTED = 4,
			SLIDING = 5
		}

		[CompilerGenerated]
		private sealed class _003CCoEjectMagazine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KeycardReceiver _003C_003E4__this;

			public Action callback;

			private SimpleTransform _003CinsertToHost_003E5__2;

			private SimpleTransform _003ClocalStart_003E5__3;

			private SimpleTransform _003ClocalEnd_003E5__4;

			private Vector3 _003CendToStart_003E5__5;

			private float _003CsqrDistance_003E5__6;

			private float _003Cacceleration_003E5__7;

			private float _003Cspeed_003E5__8;

			private SimpleTransform _003Ctarget_003E5__9;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoEjectMagazine_003Ed__47(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoWaitLockMagazine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KeycardReceiver _003C_003E4__this;

			private float _003Cspeed_003E5__2;

			private float _003Cacceleration_003E5__3;

			private SimpleTransform _003CinsertToHost_003E5__4;

			private SimpleTransform _003ClocalStart_003E5__5;

			private SimpleTransform _003ClocalEnd_003E5__6;

			private SimpleTransform _003Ctarget_003E5__7;

			private float _003CsqrDistance_003E5__8;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoWaitLockMagazine_003Ed__48(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoSelfDestructJoint_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Rigidbody target;

			public GameObject source;

			public float time;

			private ConfigurableJoint _003Cjoint_003E5__2;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoSelfDestructJoint_003Ed__49(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[Header("References")]
		public MarrowEntity marrowEntity;

		public Transform startInsertTarget;

		public Transform endInsertTarget;

		public MeshRenderer MeshLight;

		[ColorUsage(true, true)]
		public Color LockedColor;

		[ColorUsage(true, true)]
		public Color UnlockedColor;

		public AudioClip[] insertClipsReject;

		public AudioClip[] insertClipsAccept;

		public AudioClip[] ejectClips;

		public Code code;

		[Tooltip("Keep the key in the reciever after it has been inserted")]
		public bool isKeyConsumed;

		public UnityEvent onUnlock;

		public UnityEvent onLock;

		[HideInInspector]
		public Action<Keycard> OnInserted;

		public Action OnRemoved;

		public Action<Keycard> OnKeyRemoved;

		private float _sqInsertDistance;

		private _States _State;

		private SphereCollider _sphereCollider;

		private HandJointConfiguration _handJointConfig;

		private InteractableHost _keyHost;

		private Keycard _key;

		private ConfigurableJoint _CartridgeJoint;

		private float _MovingPerc;

		private float _PercVelocity;

		private bool _isActive;

		private int newMask;

		private SimpleTransform _InsertTargetToHand;

		private SimpleTransform _HandToInsertTarget;

		private SimpleTransform _HandTargetTransform;

		private bool _WasMagazineGrabbed;

		private float _CartridgeGrabbedTime;

		private Keycard data;

		private bool _IsHoverEject;

		private float _ActivePerc;

		private float _ActivePercVel;

		public static HashSet<InteractableHost> ClaimedHosts
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

		public bool hasCartridge => false;

		public InteractableHost GetHost()
		{
			return null;
		}

		private void CalculateMagazineRig(Transform insert, InteractableHost host)
		{
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnAttachedHandDelegate(Hand hand)
		{
		}

		private void OnDetachedHandDelegate(Hand hand)
		{
		}

		private void UpdateMagazineGrab(Hand hand)
		{
		}

		private void CreateJointConfig()
		{
		}

		public void SetHoverEject()
		{
		}

		[IteratorStateMachine(typeof(_003CCoEjectMagazine_003Ed__47))]
		private IEnumerator CoEjectMagazine(Action callback = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWaitLockMagazine_003Ed__48))]
		private IEnumerator CoWaitLockMagazine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSelfDestructJoint_003Ed__49))]
		private IEnumerator CoSelfDestructJoint(GameObject source, Rigidbody target, float time)
		{
			return null;
		}

		private void DestroyJoint()
		{
		}

		private void CreateJoint(Rigidbody rb)
		{
		}

		private void OnPreRealtimeRig()
		{
		}

		public override void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public override void OnInteractableHostExit(InteractableHost host)
		{
		}

		public override void OnInteractableHostStay(InteractableHost host)
		{
		}

		private void MoveTowardsStartInsertTarget()
		{
		}

		private void SlideTowardsEndInsertTarget()
		{
		}

		private void MakeStatic()
		{
		}

		private void OnMagazineLocked()
		{
		}

		public void Release(Action callback)
		{
		}

		public void Release()
		{
		}

		private void OnMagazineGrabbed(InteractableHost host, Hand hand)
		{
		}

		private void OnMagazineUnlocked()
		{
		}

		private void MakeDynamic()
		{
		}
	}
}
