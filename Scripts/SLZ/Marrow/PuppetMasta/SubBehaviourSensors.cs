using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class SubBehaviourSensors : SubBehaviourBase
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00007384 File Offset: 0x00005584
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00003DD3 File Offset: 0x00001FD3
		public Vector3 GroundVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00003DD5 File Offset: 0x00001FD5
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00003DDC File Offset: 0x00001FDC
		public float totalSupported
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00003DDE File Offset: 0x00001FDE
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00003DE1 File Offset: 0x00001FE1
		public bool isGrounded
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00003DE3 File Offset: 0x00001FE3
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00003DEA File Offset: 0x00001FEA
		public float visionFovCos
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00003DEC File Offset: 0x00001FEC
		public float TotalMass
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00003DF3 File Offset: 0x00001FF3
		public List<TriggerRefProxy> TrpList
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00003DF6 File Offset: 0x00001FF6
		public void Initiate(BehaviourBase b)
		{
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public void Respawn()
		{
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00003DFA File Offset: 0x00001FFA
		public bool AddThreat(TriggerRefProxy trp, float threat)
		{
			return false;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00003DFD File Offset: 0x00001FFD
		public bool RemoveTarget(TriggerRefProxy trp)
		{
			return false;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00003E00 File Offset: 0x00002000
		public void ClearTargets()
		{
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00003E02 File Offset: 0x00002002
		public void CheckTarget()
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00003E04 File Offset: 0x00002004
		public void SetAgro(TriggerRefProxy trp)
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00003E06 File Offset: 0x00002006
		public void SetEngaged(TriggerRefProxy trp)
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00003E08 File Offset: 0x00002008
		private ulong GetId(TriggerRefProxy trp)
		{
			return (ulong)0;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00003E0C File Offset: 0x0000200C
		private float InitialThreat(TriggerRefProxy trp)
		{
			return 0f;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00003E13 File Offset: 0x00002013
		public void UpdateGrounded(float deltaT)
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00003E15 File Offset: 0x00002015
		public void ReadPoses()
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00003E17 File Offset: 0x00002017
		public void SetVisionSphere(float radius, bool enabled = true, bool noOffset = false)
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00003E19 File Offset: 0x00002019
		public void SetEnableAnimatorSphere(float radius, bool enabled = true)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0000739C File Offset: 0x0000559C
		public Vector3 GetVelocity(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000073B4 File Offset: 0x000055B4
		public Vector3 GetCenterOfMass(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000073CC File Offset: 0x000055CC
		public Vector3 GetFeetCentroid(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00003E1B File Offset: 0x0000201B
		public float GetBalanceTangent()
		{
			return 0f;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00003E22 File Offset: 0x00002022
		public float GetBalanceTangent(out Vector3 worldDirection)
		{
			worldDirection = default(Vector3);
			return 0f;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00003E30 File Offset: 0x00002030
		public bool IsProne()
		{
			return false;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00003E33 File Offset: 0x00002033
		public float ProneFloat()
		{
			return 0f;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000073E4 File Offset: 0x000055E4
		public Vector3 HipsUpWorld()
		{
			return default(Vector3);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000073FC File Offset: 0x000055FC
		public Vector3 HipsForwardWorld()
		{
			return default(Vector3);
		}

		// Token: 0x040004E2 RID: 1250
		[Header("Vision")]
		public LayerMask blockVisionRaycast;

		// Token: 0x040004E3 RID: 1251
		public float visionFov;

		// Token: 0x040004E4 RID: 1252
		[Header("Touch")]
		public MuscleCollisionBroadcasterSensor[] forceSensorsFeet;

		// Token: 0x040004E5 RID: 1253
		public MuscleCollisionBroadcasterSensor[] forceSensorsHands;

		// Token: 0x040004E6 RID: 1254
		public MuscleCollisionBroadcasterSensor[] forceSensorsBody;

		// Token: 0x040004E7 RID: 1255
		public float additionalMass;

		// Token: 0x040004E8 RID: 1256
		public float footSupported;

		// Token: 0x040004E9 RID: 1257
		public float handSupported;

		// Token: 0x040004EA RID: 1258
		public float bodySupported;

		// Token: 0x040004EC RID: 1260
		[Header("Targets")]
		public TriggerRefProxy target;

		// Token: 0x040004ED RID: 1261
		public TriggerRefProxy selfTrp;

		// Token: 0x040004F1 RID: 1265
		private float _totalMass;

		// Token: 0x040004F2 RID: 1266
		private SphereCollider _visionSphere;

		// Token: 0x040004F3 RID: 1267
		private Vector3 _hipsForward;

		// Token: 0x040004F4 RID: 1268
		private Vector3 _hipsUp;

		// Token: 0x040004F5 RID: 1269
		private List<TriggerRefProxy> _trpList;

		// Token: 0x040004F6 RID: 1270
		private Dictionary<TriggerRefProxy, SubBehaviourSensors.TargetInfo> _trpTargets;

		// Token: 0x040004F7 RID: 1271
		private float _getVelocityDue;

		// Token: 0x040004F8 RID: 1272
		private Vector3 _storedComVel;

		// Token: 0x040004F9 RID: 1273
		private float _getCenterOfMassDue;

		// Token: 0x040004FA RID: 1274
		private Vector3 _storedCom;

		// Token: 0x040004FB RID: 1275
		private float _getFeetCentroidDue;

		// Token: 0x040004FC RID: 1276
		private Vector3 _storedSum;

		// Token: 0x02000245 RID: 581
		public struct TargetInfo
		{

			// Token: 0x04000ED1 RID: 3793
			public float threat;

			// Token: 0x04000ED2 RID: 3794
			public float timeAdded;

			// Token: 0x04000ED3 RID: 3795
			public ulong id;
		}
	}
}
