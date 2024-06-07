using System;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.PuppetMasta;

[Serializable]
public class NPC_Tracker_Data : IMarrowEntityCullable
{
	public enum NPC_State
	{
		ALIVE = 0,
		DEAD = 1,
		DESPAWNED = 2
	}

	public enum ALIVE_State
	{
		AWAKE = 0,
		FROZEN = 1,
		HIBERNATED = 2
	}

	public AIBrain brain;

	public BehaviourBaseNav baseNav;

	public PuppetMaster puppet;

	public MarrowEntity entity;

	public NPC_State npcState;

	public ALIVE_State aliveState;

	public void OnEntityCull()
	{
	}

	public void OnEntityUncull()
	{
	}

	public void OnPuppetDeath()
	{
	}

	public void OnPuppetFreeze()
	{
	}

	public void OnPuppetUnFreeze()
	{
	}
}
