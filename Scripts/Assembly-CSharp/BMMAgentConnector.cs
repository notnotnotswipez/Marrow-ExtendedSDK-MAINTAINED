using SLZ.MLAgents;
using SLZ.Marrow.Zones;
using UnityEngine;
using Barracuda;

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
}
