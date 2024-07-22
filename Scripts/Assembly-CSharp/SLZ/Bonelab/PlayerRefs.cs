using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerRefs : MonoBehaviour
	{
		public Action OnRefsComplete;

		[SerializeField]
		public GameObject[] _enableWhenReadyObjects;

		[SerializeField]
		private BodyVitals _bodyVitals;

		[SerializeField]
		private PlayerAvatarManager _avatarManager;

		public static PlayerRefs Instance
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

		public bool HasRefs
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

		public RigManager PlayerRigManager
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

		public InventoryAmmoReceiver PlayerInvAmmoReceiver
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

		public PhysicsRig PlayerPhysicsRig
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

		public OpenControllerRig OpenControllerRig
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

		public BodyVitals PlayerBodyVitals => null;

		public PlayerAvatarManager playerAvatarManager => null;

		private void Awake()
		{
		}

		private void OnPersistentLoad()
		{
		}
	}
}
