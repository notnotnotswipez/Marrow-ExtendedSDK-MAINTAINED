using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class OnlyPlaceIfUnlocked : MonoBehaviour
	{
		public CrateSpawner crateSpawner;

		private static PlayerUnlocks u => null;

		private void Awake()
		{
		}

		private bool ShouldSpawn()
		{
			return false;
		}
	}
}
