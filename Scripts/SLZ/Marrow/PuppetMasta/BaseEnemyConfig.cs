using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000D5 RID: 213
	[CreateAssetMenu(fileName = "Base Enemy Config", menuName = "StressLevelZero/Base Enemy Config", order = 1)]
	public class BaseEnemyConfig : ScriptableObject
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x00003C16 File Offset: 0x00001E16
		public void ApplyTo(BehaviourBaseNav b)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00003C18 File Offset: 0x00001E18
		public void ApplyFrom(BehaviourBaseNav b)
		{
		}

		// Token: 0x040003D7 RID: 983
		public string defaultSavePath;

		// Token: 0x040003D8 RID: 984
		public PuppetMaster.State puppetState;

		// Token: 0x040003D9 RID: 985
		[Range(0f, 16f)]
		[Header("Resting State")]
		public float restingRange;

		// Token: 0x040003DA RID: 986
		public bool freezeWhileResting;

		// Token: 0x040003DB RID: 987
		public bool homeIsPost;

		// Token: 0x040003DC RID: 988
		[Header("Roam State")]
		[Range(1f, 16f)]
		public float activeRange;

		// Token: 0x040003DD RID: 989
		public float roamSpeed;

		// Token: 0x040003DE RID: 990
		public Vector2 roamRange;

		// Token: 0x040003DF RID: 991
		public float roamAngSpeed;

		// Token: 0x040003E0 RID: 992
		[Range(0f, 1f)]
		public float roamFrequency;

		// Token: 0x040003E1 RID: 993
		public bool roamWanders;

		// Token: 0x040003E2 RID: 994
		[Header("Investigate State")]
		[Range(4f, 16f)]
		public float investigateRange;

		// Token: 0x040003E3 RID: 995
		[Header("Agro State General")]
		public float breakAgroTargetDistance;

		// Token: 0x040003E4 RID: 996
		public float breakAgroHomeDistance;

		// Token: 0x040003E5 RID: 997
		public float agroedSpeed;

		// Token: 0x040003E6 RID: 998
		public float agroedAngSpeed;

		// Token: 0x040003E7 RID: 999
		public LayerMask meleeAttackMask;

		// Token: 0x040003E8 RID: 1000
		public bool enableThrowAttack;

		// Token: 0x040003E9 RID: 1001
		public float throwMaxRange;

		// Token: 0x040003EA RID: 1002
		public float throwMinRange;

		// Token: 0x040003EB RID: 1003
		public float throwCooldown;

		// Token: 0x040003EC RID: 1004
		public float throwVelocity;

		// Token: 0x040003ED RID: 1005
		public float gunRange;

		// Token: 0x040003EE RID: 1006
		public float gunCooldown;

		// Token: 0x040003EF RID: 1007
		[Range(0f, 10f)]
		public float accuracy;

		// Token: 0x040003F0 RID: 1008
		public float reloadTime;

		// Token: 0x040003F1 RID: 1009
		[Range(1f, 60f)]
		public int clipSize;

		// Token: 0x040003F2 RID: 1010
		[Range(1f, 20f)]
		public int burstSize;

		// Token: 0x040003F3 RID: 1011
		public float desiredGunDistance;

		// Token: 0x040003F4 RID: 1012
		[ColorUsage(true, true)]
		public Color baseColor;

		// Token: 0x040003F5 RID: 1013
		[ColorUsage(true, true)]
		public Color agroColor;

		// Token: 0x040003F6 RID: 1014
		public float fwdThresh;

		// Token: 0x040003F7 RID: 1015
		public bool forcePath;

		// Token: 0x040003F8 RID: 1016
		public BaseEnemyConfig.SensorSettings sensorSettings;

		// Token: 0x040003F9 RID: 1017
		public BaseEnemyConfig.HealthSettings healthSettings;

		// Token: 0x040003FA RID: 1018
		public SubBehaviourHealth.UsageSettings restingUsage;

		// Token: 0x040003FB RID: 1019
		public SubBehaviourHealth.UsageSettings roamUsage;

		// Token: 0x040003FC RID: 1020
		public SubBehaviourHealth.UsageSettings investigateUsage;

		// Token: 0x040003FD RID: 1021
		public SubBehaviourHealth.UsageSettings engagedUsage;

		// Token: 0x040003FE RID: 1022
		public SubBehaviourHealth.UsageSettings agroedUsage;

		// Token: 0x040003FF RID: 1023
		public BehaviourBaseNav.LocoState locoState;

		// Token: 0x0200022D RID: 557
		[Serializable]
		public class SensorSettings
		{
			// Token: 0x04000E5D RID: 3677
			[Header("Vision")]
			public LayerMask blockVisionRaycast;

			// Token: 0x04000E5E RID: 3678
			public float visionFov;
		}

		// Token: 0x0200022E RID: 558
		[Serializable]
		public class HealthSettings
		{
			// Token: 0x04000E5F RID: 3679
			[Header("Health")]
			public float maxHitPoints;

			// Token: 0x04000E60 RID: 3680
			public float maxAppendageHp;

			// Token: 0x04000E61 RID: 3681
			public float stunRecovery;

			// Token: 0x04000E62 RID: 3682
			public float maxStunSeconds;

			// Token: 0x04000E63 RID: 3683
			public float minHeadImpact;

			// Token: 0x04000E64 RID: 3684
			public float minSpineImpact;

			// Token: 0x04000E65 RID: 3685
			public float minLimbImpact;

			// Token: 0x04000E66 RID: 3686
			[Range(0f, 1f)]
			[Header("Disposition")]
			public float aggression;

			// Token: 0x04000E67 RID: 3687
			[Range(0f, 10f)]
			public float irritability;

			// Token: 0x04000E68 RID: 3688
			[Range(0f, 10f)]
			public float placability;

			// Token: 0x04000E69 RID: 3689
			[Range(0f, 10f)]
			public float vengefulness;
		}

		// Token: 0x0200022F RID: 559
		public enum LocoState
		{
			// Token: 0x04000E6B RID: 3691
			Standing,
			// Token: 0x04000E6C RID: 3692
			Walking,
			// Token: 0x04000E6D RID: 3693
			Fallen,
			// Token: 0x04000E6E RID: 3694
			GetUp,
			// Token: 0x04000E6F RID: 3695
			Jumping,
			// Token: 0x04000E70 RID: 3696
			InAir
		}
	}
}
