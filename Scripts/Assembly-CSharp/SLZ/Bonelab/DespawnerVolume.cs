using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DespawnerVolume : ZoneItem
	{
		[Header("Untested in other use cases")]
		[Header("This script is a component script of Weapon Spawner.")]
		[Space(20f)]
		[Space(20f)]
		public WeaponSpawner weaponSpawner;

		protected void OnEnter(MarrowEntity entity)
		{
		}
	}
}
