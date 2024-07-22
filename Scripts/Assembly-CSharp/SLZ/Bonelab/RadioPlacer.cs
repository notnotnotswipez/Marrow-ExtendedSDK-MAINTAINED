using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class RadioPlacer : SpawnDecorator
	{
		[SerializeField]
		private RadioSong overrideClip;

		[SerializeField]
		private RadioStation selectedStation;

	}
}
