using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class WeaponSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoSpawnDefaultPack_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WeaponSpawner _003C_003E4__this;

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
			public _003CCoSpawnDefaultPack_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CCoSpawnAllWeaponPacks_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public WeaponSpawner _003C_003E4__this;

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
			public _003CCoSpawnAllWeaponPacks_003Ed__35(int _003C_003E1__state)
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

		[SerializeField]
		private bool spawnDefAtStart;

		[SerializeField]
		private bool isSpawningAllowed;

		[SerializeField]
		private bool visDebug;

		[SerializeField]
		private float initSpawnDelay;

		[SerializeField]
		private List<WeaponPack> weaponPackList;

		[SerializeField]
		private GameObject lightAmmoSpawnTarg;

		[SerializeField]
		private GameObject medAmmoSpawnTarg;

		[SerializeField]
		private GameObject heavyAmmoSpawnTarg;

		[SerializeField]
		private Poolee lightAmmoPoolee;

		[SerializeField]
		private Poolee medAmmoPoolee;

		[SerializeField]
		private Poolee heavyAmmoPoolee;

		[SerializeField]
		private SpawnablePack defaultSpawnablePack;

		public Dictionary<Barcode, WeaponPack> weaponPackMap;

		public Transform defSpawn;

		[SerializeField]
		private int weaponLimit;

		public Transform[] limitedSpawns;

		[SerializeField]
		private AudioClip overLimitClip;

		private Dictionary<GameObject, Poolee> pooleeDict;

		public static Action<Vector2> OnCountUpdated;

		public static Action<bool> IsSpawningAllowed;

		[SerializeField]
		private AudioClip spawnClip;

		[SerializeField]
		private AudioClip despawnClip;

		[SerializeField]
		private Spawnable spawnFXSpawnable;

		[SerializeField]
		private Spawnable despawnFXSpawnable;

		[SerializeField]
		private InventorySlotReceiver[] inventorySlotRecievers;

		[SerializeField]
		private List<Spawnable> specialWeaponsList;

		[SerializeField]
		private Transform specialWepSpawnPoint;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		[ContextMenu("Spawn all WeaponPacks")]
		public void SpawnAllWeaponPacks()
		{
		}

		[ContextMenu("Despawn All WeaponPacks")]
		public void DespawnAllWeaponPacks()
		{
		}

		private void DespawnPack(WeaponPack pack)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSpawnDefaultPack_003Ed__33))]
		private IEnumerator CoSpawnDefaultPack()
		{
			return null;
		}

		private void SpawnDefaultSpawnablePack()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSpawnAllWeaponPacks_003Ed__35))]
		private IEnumerator CoSpawnAllWeaponPacks(float delay)
		{
			return null;
		}

		private void SpawnWeaponPack(WeaponPack pack)
		{
		}

		private void OnPackGrabbed(WeaponPack pack)
		{
		}

		public void ToggleWeaponSpawning(bool enable)
		{
		}

		public void SpawnDefaultAmmo()
		{
		}

		[ContextMenu("Despawn All Ammo")]
		private void DespawnAllAmmo()
		{
		}

		private void CreateSpawnDictionary()
		{
		}

		public void OnWeaponSelected(SpawnableCrateReference scr)
		{
		}

		[ContextMenu("GetWeaponSlots")]
		public void GetWeaponSlots()
		{
		}

		public void DropAndDespawnInventory(GameObject playerObject = null)
		{
		}

		[ContextMenu("Despawn All Weapons")]
		public void DespawnAllWeapons()
		{
		}

		public void DespawnCountUpdate(GameObject rootObj, Poolee poolee)
		{
		}

		private void UpdateSpawn(Transform spawnPoint)
		{
		}

		public void SpawnPackByIndex(int id)
		{
		}

		[ContextMenu("SpawnRandSpecialWep")]
		public void SpawnRandSpecialWep()
		{
		}
	}
}
