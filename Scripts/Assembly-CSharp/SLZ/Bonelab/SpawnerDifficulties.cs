using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(SpawnAISettings))]
	public class SpawnerDifficulties : MonoBehaviour
	{
		[SerializeField]
		[Header("SPAWNER DATA")]
		private CrateSpawner crateSpawner;

		[SerializeField]
		private SpawnAISettings spawnAISettings;

		[SerializeField]
		private SpawnAgro spawnAgro;

		[SerializeField]
		private int currentDifficulty;

		[Header("Easy Data")]
		public Spawnable easySpawnable;

		public BaseEnemyConfig easyBaseConfig;

		public bool easyHomeIsPost;

		public Transform easySpawnPoint;

		public bool easyAgro;

		[Header("Medium Data")]
		public Spawnable mediumSpawnable;

		public BaseEnemyConfig mediumBaseConfig;

		public bool mediumHomeIsPost;

		public Transform mediumSpawnPoint;

		public bool mediumAgro;

		[Header("Hard Data")]
		public Spawnable hardSpawnable;

		public BaseEnemyConfig hardBaseConfig;

		public bool hardHomeIsPost;

		public Transform hardSpawnPoint;

		public bool hardAgro;

		[ContextMenu("GetSpawnerData")]
		public void GetZoneData()
		{
		}

		public void ApplyDifficulty(int diff)
		{
		}

		[ContextMenu("SpawnCrate")]
		public void SpawnCrate()
		{
		}
	}
}
