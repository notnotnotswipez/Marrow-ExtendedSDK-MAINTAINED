using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class InventoryAmmoReceiver : InventoryHandReceiver
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGrabMagAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Hand hand;

			public InventoryAmmoReceiver _003C_003E4__this;

			public CartridgeData cartridge;

			public int ammoCount;

			private Magazine _003Cmagazine_003E5__2;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwitchMagazineAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Spawnable spawnable;

			public InventoryAmmoReceiver _003C_003E4__this;

			public CartridgeData cartridgeData;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnAndPlaceMagazineAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public InventoryAmmoReceiver _003C_003E4__this;

			public Spawnable spawnable;

			public CartridgeData cartridgeData;

			private Transform[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private Transform _003CartTarget_003E5__4;

			private Magazine _003Cmagazine_003E5__5;

			private InteractableHost _003Chost_003E5__6;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Range(0f, 10f)]
		public float priority;

		public Transform validateTarget;

		[Header("References")]
		public AudioClip[] grabClips;

		public RigManager rigManager;

		public MagazineData defaultLightMag;

		public CartridgeData defaultLightCart;

		public MagazineData defaultMediumMag;

		public CartridgeData defaultMediumCart;

		public MagazineData defaultHeavyMag;

		public CartridgeData defaultHeavyCart;

		[SerializeField]
		private Transform[] _ammoArtTargets;

		private CartridgeData _selectedCartridgeData;

		private MagazineData _selectedMagazineData;

		private List<MagazineData> _platformStack;

		private List<CartridgeData> _cartridgeStack;

		private AmmoInventory _AmmoInventory;

		private List<Magazine> _activeMagazines;

		private List<Magazine> _magazineArts;

		private int _curMagIdx;

		private Spawnable _nextMagazine;

		private bool _isSwitching;

		private bool _hasMagazineInQueue;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnHandGrab(Hand hand)
		{
		}

		[AsyncStateMachine(typeof(_003CGrabMagAsync_003Ed__21))]
		private UniTaskVoid GrabMagAsync(Hand hand, CartridgeData cartridge, int ammoCount)
		{
			return default(UniTaskVoid);
		}

		public override void OnHandDrop(IGrippable host)
		{
		}

		public override float Validate(Hand hand)
		{
			return 0f;
		}

		public void RegisterMagazine(Magazine magazine)
		{
		}

		public void UnregisterMagazine(Magazine magazine)
		{
		}

		public void OnHandItemSlotRemoved(InventorySlot slot)
		{
		}

		private void OnHandItemSlot(InventorySlot slot)
		{
		}

		public void SwitchMagazine(MagazineData magazineData, CartridgeData cartridgeData)
		{
		}

		[AsyncStateMachine(typeof(_003CSwitchMagazineAsync_003Ed__34))]
		private UniTaskVoid SwitchMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnAndPlaceMagazineAsync_003Ed__35))]
		private UniTask SpawnAndPlaceMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTask);
		}

		private void UpdateAmmoArt()
		{
		}
	}
}
