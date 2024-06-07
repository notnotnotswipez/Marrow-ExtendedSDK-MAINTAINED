using System;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Trial_SpawnerEvents : MonoBehaviour, ISpawnListenable
	{
		public CrateSpawner[] crateSpawners;

		public int deadCount;

		public int totalCount;

		public int spawnerCount;

		public float requiredPerc;

		[Tooltip("Use the spawner count to set req kill count rather than required perc for each gate")]
		public bool useSpawnerTotal;

		[SerializeField]
		private AudioClip killAllClip;

		public bool sendTotalEvents;

		private bool sentKillEvent;

		public UnityEvent OnKilledAll;

		public static Action<int> OnTotalKillCalc;

		public TMP_Text deadText;

		public TMP_Text totalText;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public void OnDeath(AIBrain brain)
		{
		}

		private void Start()
		{
		}

		public void OnSpawnerDeath()
		{
		}

		[ContextMenu("GetTotalCountFromPerc")]
		public void GetTotalCountFromPerc()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
