using SLZ.MLAgents;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

public class QuadDrone_Moonbase_Controller : MonoBehaviour, ISpawnListenable
{
	public CrateSpawner droneSpawner;

	public RoamArea[] roamAreas;

	private BehaviourQuadDrone _quadDrone;

	private void Awake()
	{
	}

	protected void OnDisable()
	{
	}

	[ContextMenu("Test Pass 0")]
	public void TestPass()
	{
	}

	public void PassPowerZoneReference(int zoneInd)
	{
	}

	public void OnSpawn(GameObject go)
	{
	}

	public void OnDespawn(GameObject go)
	{
	}
}
