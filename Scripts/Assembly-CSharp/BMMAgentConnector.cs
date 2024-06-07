using SLZ.MLAgents;
using SLZ.Marrow.Zones;
using Barracuda;
using UnityEngine;

public class BMMAgentConnector : SpawnDecorator
{
	public BarracudaModelManager BMM;

	private ulong _pooleeId;

	public bool searchWithModel;

	public NNModel searchModel;

	private void Awake()
	{
	}

	private void SearchForBMM()
	{
	}

	public override void OnSpawn(GameObject go)
	{
	}

	public override void OnDespawn(GameObject go)
	{
	}
}
