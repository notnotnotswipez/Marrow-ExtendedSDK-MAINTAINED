using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlatformDescrimationDecorator : SpawnDecorator
	{
		[Header("Spawn crate depending on platform, Null = Don't Spawn")]
		public SpawnableCrateReference PC_Spawnable;

		public SpawnableCrateReference Android_Spawnable;

		private void Start()
		{
		}

		private void SpawnCrate(SpawnableCrateReference crate)
		{
		}
	}
}
