using UnityEngine;

namespace SLZ.MLAgents
{
	public class TurretAreaSelfPlay : TurretArea
	{
		public TurretAgentSelfPlay agent_1;

		public TurretAgentSelfPlay agent_2;

		public GameObject area_1;

		public GameObject area_2;

		private float min_rot;

		private float max_rot;

		[HideInInspector]
		public Quaternion currentRotation;

		[HideInInspector]
		public bool reset_me;

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

		private void EnemyActivator(ref GameObject temp_enemy)
		{
		}

		private void SpawnAtZone(ref GameObject temp_enemy, GameObject temp_area)
		{
		}

		private void ActivateEnemies_SP()
		{
		}

		private Quaternion getRotation()
		{
			return default(Quaternion);
		}

		public void ResetArea_SP(TurretAgentSelfPlay agent)
		{
		}

		public void EnemyMissed(GameObject shooter)
		{
		}

		public override void EnemyKilled(GameObject shooter)
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
