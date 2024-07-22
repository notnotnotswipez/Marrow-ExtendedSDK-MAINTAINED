using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class GachaPlacer : SpawnDecorator
	{
		[SerializeField]
		[Space(10f)]
		[Header("Requires Crate Spawner to be in Manual Mode")]
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

	}
}
