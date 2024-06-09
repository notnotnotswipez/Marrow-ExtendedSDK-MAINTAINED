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
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public TriggerRefProxy LastGrabbedProxy
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Collider[] Colliders => null;

		public bool IsInteractionDisabled
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsFarHoverEnabled
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsStatic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HasRigidbody
		{
			get
			{
				return false;
			}
		}

		public MarrowBody Body
		{
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

		private IEnumerator CoCheckForSleep()
		{
			return null;
		}
	}
}
