using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UltEvents;
using UnityEngine;

public class SpawnerEvents : MonoBehaviour, ISpawnListenable
{
	[SerializeField]
	private CrateSpawner[] crateSpawners;

	[SerializeField]
	private AudioClip killAllClip;

	[SerializeField]
	private int deadCount;

	public TMP_Text deadText;

	public TMP_Text totalText;

	[SerializeField]
	private UltEvent OnKilledAll;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void OnSpawn(GameObject go)
	{
	}

	public void OnDeath(AIBrain brain)
	{
	}

	public void OnDespawn(GameObject go)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
