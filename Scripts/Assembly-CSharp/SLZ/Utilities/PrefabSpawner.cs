using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class PrefabSpawner : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Spawnable")]
		private Spawnable spawnable;

		private void Awake()
		{
		}

		public void SpawnPrefab()
		{
		}
	}
}
