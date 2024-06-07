using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableHost : MarrowBehaviour, IGrippable
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckForSleep_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InteractableHost _003C_003E4__this;

			private WaitForFixedUpdate _003Cwffu_003E5__2;

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
			public _003CCoCheckForSleep_003Ed__79(int _003C_003E1__state)
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

		private static ComponentCache<InteractableHost> _cache;

		public InteractableHostManager manager;

		public bool ignoreBodyOnGrab;

		private MarrowBody _marrowBody;

		private ConfigurableJoint _monofootJoint;

		private ConfigurableJoint _pelvisJoint;

		private ConfigurableJoint _spineJoint;

		private ConfigurableJoint _chestJoint;

		private ConfigurableJoint _neckJoint;

		private ConfigurableJoint _headJoint;

		private readonly List<Hand> _hands;

		private Hand _lastHand;

		private readonly List<Grip> _grips;

		private readonly List<ForcePullGrip> _fpGrips;

		public Action<InteractableHost, Hand> onHandAttachedDelegate;

		public Action<InteractableHost, Hand> onHandDetachedDelegate;

		private Coroutine checkForSleepCoroutine;

		public static ComponentCache<InteractableHost> Cache => null;

		public VirtualController VirtualController
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

		public TriggerRefProxy LastGrabbedProxy
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

		public Collider[] Colliders => null;

		public bool IsInteractionDisabled
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

		public bool IsFarHoverEnabled
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

		public bool IsStatic
		{
			[MethodImpl(256)]
			[CompilerGenerated]
			get
			{
				return false;
			}
			[MethodImpl(256)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool HasRigidbody
		{
			[MethodImpl(256)]
			get
			{
				return false;
			}
		}

		public MarrowBody Body
		{
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		public Rigidbody Rb => null;

		public bool IsAttached => false;

		public bool IsPulling => false;

		private void Reset()
		{
		}

		public SimpleTransform GetHostTransform()
		{
			return default(SimpleTransform);
		}

		public Transform GetTransform()
		{
			return null;
		}

		public GameObject GetHostGameObject()
		{
			return null;
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void DecorateHostOnChildGrips(Transform t)
		{
		}

		public void OnDestroy()
		{
		}

		public void RemoveProxy()
		{
		}

		public void SetProxy(GameObject proxyObject)
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		public void DisableInteraction()
		{
		}

		public void DisableFarHover()
		{
		}

		public void EnableFarHover()
		{
		}

		public void EnableInteraction()
		{
		}

		public void DestroyJoints()
		{
		}

		public void Freeze()
		{
		}

		public void Unfreeze()
		{
		}

		public void AttachHand(Hand hand)
		{
		}

		public void DetachHand(Hand hand)
		{
		}

		public Hand GetHand(int idx = 0)
		{
			return null;
		}

		public void ClearAttachedHandsForDespawn()
		{
		}

		public Hand GetLastHand()
		{
			return null;
		}

		public int HandCount()
		{
			return 0;
		}

		public void ForceDetach(bool isQuick = false)
		{
		}

		public Grip GetGrip()
		{
			return null;
		}

		public ForcePullGrip GetForcePullGrip()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckForSleep_003Ed__79))]
		private IEnumerator CoCheckForSleep()
		{
			return null;
		}
	}
}
