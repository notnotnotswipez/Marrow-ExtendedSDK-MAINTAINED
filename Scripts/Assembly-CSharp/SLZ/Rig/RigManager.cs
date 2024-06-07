using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Player;
using SLZ.VRMK;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Rig
{
	[SelectionBase]
	public class RigManager : MonoBehaviour
	{
		private enum LeashType
		{
			Circle = 0,
			Rectangle = 1
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatarCrate_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public string barcode;

			public Action<bool> callback;

			public bool cache;

			public RigManager _003C_003E4__this;

			private SLZ.VRMK.Avatar _003CavatarToSwapTo_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			private UniTask.Awaiter _003C_003Eu__3;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<RigManager> _cache;

		[HideInInspector]
		public MarrowEntity marrowEntity;

		[Header("Control")]
		public ControllerRig controllerRig;

		[Header("Remap")]
		public bool remapEnabled;

		public RemapRig remapHeptaRig;

		public AnimationRig animationRig;

		public InterpRig interpRig;

		public GameWorldSkeletonRig virtualHeptaRig;

		[Header("Physics")]
		public PhysicsRig physicsRig;

		[Header("Modules")]
		public Inventory inventory;

		public Health health;

		public Seat activeSeat;

		[ReadOnly(false)]
		[Tooltip("Readonly field, to change which avatar is used in a scene, use \"Avatar Override\"")]
		[Header("Avatar")]
		[SerializeField]
		private SLZ.VRMK.Avatar _avatar;

		private SLZ.VRMK.Avatar _avatarOnDeck;

		private bool _avatarDirty;

		private string _avatarID;

		[SerializeField]
		[Tooltip("Overrides the avatar for the scene (overrides the loaded avatar)")]
		private AvatarCrateReference _avatarCrate;

		[SerializeField]
		private SLZ.VRMK.Avatar _calibrationAvatar;

		private string calibrationAvatarBarcode;

		public BonelabSerializableDictionaries.StringAvatarDictionary _avatarCache;

		[HideInInspector]
		public WorldGrip worldGrip;

		public HandPose worldGripHandPose;

		[FormerlySerializedAs("inputRigs")]
		public Rig[] remapRigs;

		private bool _fixedRan;

		private bool _reEnable;

		public Action onAvatarSwapped;

		public Action<string> onAvatarSwapped2;

		public Action OnPreAvatarEarlyUpdate;

		public Action OnPostLateUpdate;

		public Vector3 checkpointPosition;

		public Vector3 checkpointFwd;

		private SimpleTransform _queuedDestination;

		private bool _teleportQueued;

		private bool _zeroVelocity;

		private bool _leashed;

		private Vector3 _leashPositionWorld;

		private Quaternion _leashRotationWorld;

		private Vector2 _maxBounds;

		private Vector2 _minBounds;

		private ConfigurableJoint _leashJoint1;

		private ConfigurableJoint _leashJoint2;

		private LeashType _type;

		public static ComponentCache<RigManager> Cache => null;

		public ControllerRig ControllerRig => null;

		public SLZ.VRMK.Avatar avatar
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string avatarID => null;

		public bool HasInitialAvatar
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

		public AvatarCrateReference AvatarCrate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SLZ.VRMK.Avatar CalibrationAvatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLeashed => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void EarlyUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public Rig GetPhysInputRig()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSwapAvatarCrate_003Ed__60))]
		public UniTask<bool> SwapAvatarCrate(string barcode, bool cache = false, Action<bool> callback = null)
		{
			return default(UniTask<bool>);
		}

		public void SwapAvatar(SLZ.VRMK.Avatar newAvatar)
		{
		}

		private bool SwitchAvatar(SLZ.VRMK.Avatar newAvatar)
		{
			return false;
		}

		public void TeleportEvent(Transform trans)
		{
		}

		public bool Teleport(Vector3 feetDestinationWorld, bool zeroVelocity = true)
		{
			return false;
		}

		public bool Teleport(Vector3 feetDestinationWorld, Vector3 fwdSnap, bool zeroVelocity = true)
		{
			return false;
		}

		public bool Teleport(Transform destination, bool zeroVelocity = true)
		{
			return false;
		}

		private void InternalTeleport()
		{
		}

		public bool TeleportToPose(Vector3 feetDestinationWorld, Vector3 fwdSnap, bool zeroVelocity = true)
		{
			return false;
		}

		public bool LeashPlayerCircle(Vector3 positionWorld, float minRadius, float maxRadius)
		{
			return false;
		}

		public Vector3 UpdateLeashCircle(Vector3 headDelta)
		{
			return default(Vector3);
		}

		public Vector2 UpdateLeashCircle(Vector2 headDelta)
		{
			return default(Vector2);
		}

		public void UnleashPlayer()
		{
		}
	}
}
