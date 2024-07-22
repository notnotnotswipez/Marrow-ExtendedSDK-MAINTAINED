using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnableSaver : MonoBehaviour
	{
		public enum SpawnerItemType
		{
			UNKNOWN = 0,
			AMMO_CRATE = 1,
			AMMO_BOX = 2,
			PICKUP = 3
		}

		[Tooltip("This field is intentionally LOST after the initial spawn. It is serialized for an initial-load backreference, but should not otherwise be preserved.")]
		public CrateSpawner AssignedSpawner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BonelabGameControl GameControl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SpawnerItemType ItemType
		{
			[CompilerGenerated]
			get
			{
				return default(SpawnerItemType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Saveable Saveable
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Object ItemComponent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private bool ShouldSpawn()
		{
			return false;
		}

		public void OnSpawned(CrateSpawner spawner, GameObject go)
		{
		}

		private void OnAmmoCrateLootSpawned(ObjectDestructible ammoCrate, Spawnable ammoBoxSpawnable, GameObject ammoBox)
		{
		}

		private void OnAmmoBoxCollected()
		{
		}

		private void UpdateSave()
		{
		}
	}
}
