using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TurretArea : MonoBehaviour
	{
		public bool useTimer;

		public float maxTime;

		[HideInInspector]
		public float currentTime;

		public TurretAgent agent;

		public int totalActiveEnemies;

		public GameObject enemy_prefab;

		public ObjectPool EnemyPool;

		public GameObject[] npc_spawns;

		public float car_speed;

		public int nb_enemies;

		public float spawn_min;

		public float spawn_max;

		public float spawn_height;

		public GameObject geo_parent;

		public float area_scale;

		[HideInInspector]
		public int currentActiveEnemies;

		[HideInInspector]
		public int nb_misses;

		[HideInInspector]
		public int nb_hits;

		public StatsRecorder statsRecorder;

		private void Start()
		{
		}

		private Vector3 GetAreaLayout()
		{
			return default(Vector3);
		}

		private void SetAreaScale(Vector3 new_scale)
		{
		}

		private void DeactivateEnemies()
		{
		}

		private GameObject GetRandomSpawn(ref GameObject[] spawn_array)
		{
			return null;
		}

		private void ActivateEnemies()
		{
		}

		public virtual void ResetArea()
		{
		}

		public virtual void EnemyKilled(GameObject shooter)
		{
		}

		private void CheckActiveEnemies()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
