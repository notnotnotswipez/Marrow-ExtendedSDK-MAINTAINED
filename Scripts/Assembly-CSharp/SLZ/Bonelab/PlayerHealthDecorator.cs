using SLZ.Marrow;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Zones;
using UltEvents;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerHealthDecorator : MonoBehaviour, ISpawnListenable
	{
		[SerializeField]
		[Header("This is a stop gap script. Should be rolled into a player marker manager eventually \n \nThe player by Default is Mortal and Level Reloads on Death \nAlso rotates the player to the correct orientation\n")]
		private PlayerMarker _playerMarker;

		[SerializeField]
		private bool _reloadLevelOnDeath;

		[SerializeField]
		private Health.HealthMode _healthMode;

		[Tooltip("Time player has (in seconds) to score damage after health reaches 0, if no attack is scored player dies")]
		[SerializeField]
		private float deathTime;

		[SerializeField]
		private UltEvent OnPlayerDeath;

		public PlayerMarker PlayerMarker => null;

		private void Reset()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public void PlayerDeath()
		{
		}
	}
}
