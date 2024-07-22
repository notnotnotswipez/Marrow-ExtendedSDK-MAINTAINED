using SLZ.Marrow;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(PlayerMarker))]
	public class PlayerLeasher : MonoBehaviour, ISpawnListenable
	{
		[SerializeField]
		private PlayerMarker _playerMarker;

		public float min_leash;

		public float max_leash;

		private RigManager _rM;

		private bool _hasSpawned;

		private bool _hasLeashed;

		private void Reset()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void LEASH()
		{
		}

		public void UNLEASH()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}
	}
}
