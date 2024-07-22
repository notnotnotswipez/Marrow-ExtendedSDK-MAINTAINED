using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class BigGachaPlacer : SpawnDecorator
	{
		[SerializeField]
		[Space(10f)]
		[Header("Requires Crate Spawner to be in Manual Mode")]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		private BonelabAvatarLevelGameControl gameControl;

		private static PlayerUnlocks u => null;

		private static PlayerProgression p => null;

	}
}
