using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class GachaPlacer : SpawnDecorator
	{
		[Header("Requires Crate Spawner to be in Manual Mode")]
		[Space(10f)]
		[SerializeField]
		private GenericCrateReference unlockCrate;

		public bool onlyPlaceIfBeatGame;

		private static PlayerUnlocks u => null;

		private static PlayerProgression p => null;

		private void Awake()
		{
		}

		private void OnPersistentLoad()
		{
		}

		private bool ShouldSpawn()
		{
			return false;
		}

		public override void OnSpawn(GameObject go)
		{
		}
	}
}
