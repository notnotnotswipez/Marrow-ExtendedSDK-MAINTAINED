using PuppetMasta;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

[RequireComponent(typeof(CrateSpawner))]
public class NPCFaceAudio : SpawnDecorator
{
	private AIBrain aiBrain;

	private BehaviourPowerLegs powerLegBehaviour;

	public override void OnSpawn(GameObject go)
	{
	}

	public void TriggerGreeting(int greet = -1)
	{
	}

	public void TriggerGesture(int gest)
	{
	}
}
