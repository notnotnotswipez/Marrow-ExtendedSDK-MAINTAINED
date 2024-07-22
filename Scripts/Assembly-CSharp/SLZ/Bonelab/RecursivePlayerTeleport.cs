using UnityEngine;

namespace SLZ.Bonelab
{
	public class RecursivePlayerTeleport : MonoBehaviour
	{
		private Transform spawnLocation;

		public Transform tempSpawn;

		public Vector3 max_bounds;

		public Vector3 min_bounds;

		public void OnTriggerEnter(Collider other)
		{
		}

		public void Teleport()
		{
		}
	}
}
