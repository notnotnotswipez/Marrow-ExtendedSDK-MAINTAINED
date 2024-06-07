using System;
using System.Collections.Generic;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Splines;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C3 RID: 451
	public class SpawnAISettings : SpawnDecorator
	{
		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000541F File Offset: 0x0000361F
		private void Awake()
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00005421 File Offset: 0x00003621
		private void GetAIBrain()
		{
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00005423 File Offset: 0x00003623
		public override void OnSpawn(GameObject go)
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00005425 File Offset: 0x00003625
		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00005427 File Offset: 0x00003627
		public void OnDeath(AIBrain brain)
		{
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00005429 File Offset: 0x00003629
		public void CreateRoamArea()
		{
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0000542B File Offset: 0x0000362B
		[ContextMenu("ResetZoneRoamArea")]
		public void GetZoneArea()
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0000542D File Offset: 0x0000362D
		[ContextMenu("ResetZoneRoamArea3D")]
		public void GetZoneArea3D()
		{
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0000542F File Offset: 0x0000362F
		[ContextMenu("CreateWaypointList")]
		public void CreateListFromSpline()
		{
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00005431 File Offset: 0x00003631
		[ContextMenu("GetClosestWaypoint")]
		public void GetStartIndexByDist()
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00005433 File Offset: 0x00003633
		private int GetClosestWaypoint()
		{
			return 0;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00005436 File Offset: 0x00003636
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x04000BA4 RID: 2980
		[FormerlySerializedAs("baseConfig")]
		public BaseEnemyConfig overrideConfig;

		// Token: 0x04000BA5 RID: 2981
		public Transform homeTransform;

		// Token: 0x04000BA6 RID: 2982
		public bool homeIsPost;

		// Token: 0x04000BA7 RID: 2983
		public bool isSoundAggroWhenInSecondaryZone;

		// Token: 0x04000BA8 RID: 2984
		public float investigateTimeout;

		// Token: 0x04000BA9 RID: 2985
		public RoamArea roamArea;

		// Token: 0x04000BAA RID: 2986
		public bool overrideRoam;

		// Token: 0x04000BAB RID: 2987
		public Vector2 roamXz;

		// Token: 0x04000BAC RID: 2988
		public Vector3 roamXyz;

		// Token: 0x04000BAD RID: 2989
		public Vector2 roamOffset;

		// Token: 0x04000BAE RID: 2990
		public Vector3 roamOffset3D;

		// Token: 0x04000BAF RID: 2991
		[Tooltip("Defaults: LegBehaviours:1.35, Omni:2.5, Crablet:1")]
		public float roamSpeed;

		// Token: 0x04000BB0 RID: 2992
		public float wpWaitDuration;

		// Token: 0x04000BB1 RID: 2993
		public float waypointMinTime;

		// Token: 0x04000BB2 RID: 2994
		public int startWaypointIndex;

		// Token: 0x04000BB3 RID: 2995
		public Vector2 spawnerOffset;

		// Token: 0x04000BB4 RID: 2996
		public Vector3 spawnerOffset3D;

		// Token: 0x04000BB5 RID: 2997
		public BehaviourBaseNav.RoamMode roamMode;

		// Token: 0x04000BB6 RID: 2998
		public BehaviourBaseNav.WaypointEvalMode waypointEvalMode;

		// Token: 0x04000BB7 RID: 2999
		public SplineContainer roamSpline;

		// Token: 0x04000BB8 RID: 3000
		public GameObject[] objectPoints;

		// Token: 0x04000BB9 RID: 3001
		public Zone zone;

		// Token: 0x04000BBA RID: 3002
		public List<Vector3> orderedWaypointList;

		// Token: 0x04000BBB RID: 3003
		private GameObject _playerObject;

		// Token: 0x04000BBC RID: 3004
		private List<BehaviourBaseNav> _behaviours;

		// Token: 0x04000BBD RID: 3005
		[HideInInspector]
		public static bool spawnAIPasted;
	}
}
