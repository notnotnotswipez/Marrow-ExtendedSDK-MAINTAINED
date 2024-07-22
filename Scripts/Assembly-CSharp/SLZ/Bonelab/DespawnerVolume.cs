using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DespawnerVolume : ZoneItem
	{
		[Space(20f)]
		[Header("This script is a component script of Weapon Spawner.")]
		[Header("Untested in other use cases")]
		[Space(20f)]
		public WeaponSpawner weaponSpawner;

	}
}
