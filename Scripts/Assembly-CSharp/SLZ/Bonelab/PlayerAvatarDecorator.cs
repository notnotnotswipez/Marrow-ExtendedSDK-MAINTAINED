using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(PlayerMarker))]
	public class PlayerAvatarDecorator : MonoBehaviour, ISpawnListenable
	{
		[Header("Use this to force player into an avatar at the start of a level")]
		[SerializeField]
		private PlayerMarker _playerMarker;

		private bool _hasSpawned;

		public AvatarCrateReference overrideAvatar;

		[HideInInspector]
		public bool preventSwap;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		private void OnLevelLoad()
		{
		}

		private void SwapAvatar()
		{
		}
	}
}
