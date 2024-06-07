using UnityEngine;

namespace SLZ.MLAgents
{
	public class SpawnController : MonoBehaviour
	{
		public bool carInZone;

		public int spawnCount;

		private Transform parentTrans;

		private bool startSpawning;

		public GameObject carPrefab;

		public GameObject despawnCarArea;

		private float nb_cars;

		private float carSpeed;

		public void SpawnCar(float count, float speed, Transform parent)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
