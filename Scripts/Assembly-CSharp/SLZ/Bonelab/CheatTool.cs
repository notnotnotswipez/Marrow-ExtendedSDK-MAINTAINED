using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CheatTool : MonoBehaviour
	{
		public static bool isDeveloperBuild;

		public GameObject[] DebugObjects;

		public SpawnableCrateReference[] crates;

		public Transform spawnLocation;

		public AudioClip unlockAudioClip;

		private void Start()
		{
		}

		private void EnableDebugMenu()
		{
		}

		private void SpawnDebugObjects()
		{
		}

		public static bool GetKey(KeyCode code)
		{
			return false;
		}

		public static bool GetKeyDown(KeyCode code)
		{
			return false;
		}

		public static bool GetKeyUp(KeyCode code)
		{
			return false;
		}
	}
}
