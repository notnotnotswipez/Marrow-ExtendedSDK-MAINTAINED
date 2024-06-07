using System;
using SLZ.Data;
using SLZ.Marrow.AI;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class NPC_Data
	{
		public Zone zone;

		public ProfileSpawner profileSpawner;

		public AIBrain aiBrain;

		public AgentLinkControl agentLinkControl;

		public TriggerRefProxy myProxy;

		public TriggerRefProxy targetProxy;

		public EnemyProfile enemyProfile;

		public NPC_Objective NPC_objective;

		public int spawnOrder;

		public bool isDead;

		public bool isDespawned;

		public bool isFriendly;

		public bool isKing;

		public GameObject crownObj;

		public FixedJoint crownJoint;

		public Texture iconImage;

		public Vector3 _position;

		public float deathTime;
	}
}
