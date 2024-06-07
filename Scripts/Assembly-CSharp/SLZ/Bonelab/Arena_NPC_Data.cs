using System;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class Arena_NPC_Data
	{
		public AIBrain brain;

		public AgentLinkControl agentLinkControl;

		public TriggerRefProxy myProxy;

		public bool isDead;

		public bool isDespawned;

		public bool isFriendly;

		public bool isKing;

		public GameObject crownObj;

		public FixedJoint crownJoint;
	}
}
