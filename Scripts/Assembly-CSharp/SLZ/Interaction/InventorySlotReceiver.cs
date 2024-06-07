using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class InventorySlotReceiver : InventoryHandReceiver
	{
		[CompilerGenerated]
		private sealed class _003CCoWaitLockMagazine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InventorySlotReceiver _003C_003E4__this;

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
			public _003CCoWaitLockMagazine_003Ed__22(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnInSlotAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public Barcode barcode;

			public InventorySlotReceiver _003C_003E4__this;

			private Spawnable _003Cspawnable_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__2;

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

		private WeaponSlot _slottedWeapon;

		private IGrippable _weaponHost;

		[EnumFlags]
		public SlotType slotType;

		private bool isInUIMode;

		public Vector3 primaryAxis;

		public bool isFlipped;

		public bool useOffset;

		public UnityEvent OnSlotActivate;

		public UnityEvent OnSlotDeactivate;

		private bool _isSlotActive;

		private HashSet<Hand> _hands;

		public static HashSet<IGrippable> ClaimedHosts
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

		public IGrippable GetHost()
		{
			return null;
		}

		[ContextMenu("Despawn Contents")]
		private void DespawnContents()
		{
		}

		[ContextMenu("Respawn Contents")]
		private void RespawnContents()
		{
		}

		[ContextMenu("Destroy Contents")]
		private void DestroyContents()
		{
		}

		public void ReturnFromUI()
		{
		}

		public void SendToUI()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitLockMagazine_003Ed__22))]
		private IEnumerator CoWaitLockMagazine()
		{
			return null;
		}

		private void OnDespawnSlotted(GameObject spawnObject)
		{
		}

		public void DropWeapon()
		{
		}

		private void MakeStatic()
		{
		}

		private void MakeDynamic()
		{
		}

		public void UpdateTransform()
		{
		}

		public override void OnHandGrab(Hand hand)
		{
		}

		public override void OnHandDrop(IGrippable host)
		{
		}

		public override float Validate(Hand hand)
		{
			return 0f;
		}

		private float ValidateGrab(Hand hand)
		{
			return 0f;
		}

		private float ValidateDrop(Hand hand)
		{
			return 0f;
		}

		[AsyncStateMachine(typeof(_003CSpawnInSlotAsync_003Ed__33))]
		public UniTask<bool> SpawnInSlotAsync(Barcode barcode)
		{
			return default(UniTask<bool>);
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		public bool InsertInSlot(InteractableHost host)
		{
			return false;
		}
	}
}
