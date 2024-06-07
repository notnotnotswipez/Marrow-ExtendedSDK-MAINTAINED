using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class SubBehaviourHealth : SubBehaviourBase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000802 RID: 2050 RVA: 0x00003D9A File Offset: 0x00001F9A
		// (remove) Token: 0x06000803 RID: 2051 RVA: 0x00003D9C File Offset: 0x00001F9C
		public static event SubBehaviourHealth.NPCDamageRecieved OnNPCDamage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00003D9E File Offset: 0x00001F9E
		public void Initiate(BehaviourBase b)
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public void Resurrect()
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public void Kill()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public void SetUsage(float hips, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00003DA6 File Offset: 0x00001FA6
		public void SetUsage(SubBehaviourHealth.UsageSettings s)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public void UpdateMuscleStates(float footSupported)
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00003DAA File Offset: 0x00001FAA
		public float Stun(int m, float stun)
		{
			return 0f;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00003DB1 File Offset: 0x00001FB1
		public float TakeDamage(int m, Attack attack)
		{
			return 0f;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00003DB8 File Offset: 0x00001FB8
		private void DamageScore(int m, float damage)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00003DBA File Offset: 0x00001FBA
		public bool UpdateStun()
		{
			return false;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00003DBD File Offset: 0x00001FBD
		public float GetStun(int m, out float health)
		{
			health = 0f;
			return 0f;
		}

		// Token: 0x040004BE RID: 1214
		[Header("Health")]
		public float maxHitPoints;

		// Token: 0x040004BF RID: 1215
		public float maxAppendageHp;

		// Token: 0x040004C0 RID: 1216
		public float stunRecovery;

		// Token: 0x040004C1 RID: 1217
		public float maxStunSeconds;

		// Token: 0x040004C2 RID: 1218
		public float minHeadImpact;

		// Token: 0x040004C3 RID: 1219
		public float minSpineImpact;

		// Token: 0x040004C4 RID: 1220
		public float minLimbImpact;

		// Token: 0x040004C5 RID: 1221
		public bool isOrganic;

		// Token: 0x040004C6 RID: 1222
		public bool stunActive;

		// Token: 0x040004C7 RID: 1223
		public float bluntMult;

		// Token: 0x040004C8 RID: 1224
		public float stabMult;

		// Token: 0x040004C9 RID: 1225
		public float pierceMult;

		// Token: 0x040004CA RID: 1226
		public SubBehaviourHealth.StunGroup[] muscles;

		// Token: 0x040004CB RID: 1227
		[Range(0f, 1f)]
		public float cur_hp;

		// Token: 0x040004CC RID: 1228
		[Range(0f, 1f)]
		public float cur_arm_lf;

		// Token: 0x040004CD RID: 1229
		[Range(0f, 1f)]
		public float cur_arm_rt;

		// Token: 0x040004CE RID: 1230
		[Range(0f, 1f)]
		public float cur_leg_lf;

		// Token: 0x040004CF RID: 1231
		[Range(0f, 1f)]
		public float cur_leg_rt;

		// Token: 0x040004D0 RID: 1232
		public float stun_spine;

		// Token: 0x040004D1 RID: 1233
		public float stun_arm_lf;

		// Token: 0x040004D2 RID: 1234
		public float stun_arm_rt;

		// Token: 0x040004D3 RID: 1235
		public float stun_leg_lf;

		// Token: 0x040004D4 RID: 1236
		public float stun_leg_rt;

		// Token: 0x040004D5 RID: 1237
		public float usage_hips;

		// Token: 0x040004D6 RID: 1238
		public float usage_spine;

		// Token: 0x040004D7 RID: 1239
		public float usage_arm_lf;

		// Token: 0x040004D8 RID: 1240
		public float usage_arm_rt;

		// Token: 0x040004D9 RID: 1241
		public float usage_leg_lf;

		// Token: 0x040004DA RID: 1242
		public float usage_leg_rt;

		// Token: 0x040004DB RID: 1243
		[Tooltip("Current state of agro, will move up and down based on damage received / dealt")]
		[Header("Disposition")]
		[Range(0f, 1f)]
		public float aggression;

		// Token: 0x040004DC RID: 1244
		[Tooltip("Nonfunctioning")]
		[Range(0f, 10f)]
		public float irritability;

		// Token: 0x040004DD RID: 1245
		[Tooltip("Multiplier, Decreases aggression based on damage dealt")]
		[Range(0f, 10f)]
		public float placability;

		// Token: 0x040004DE RID: 1246
		[Tooltip("Multiplier, Increases aggression based on damage received")]
		[Range(0f, 10f)]
		public float vengefulness;

		// Token: 0x040004DF RID: 1247
		[HideInInspector]
		public int damageScore;

		// Token: 0x040004E1 RID: 1249
		public static Action OnHeadShot;

		// Token: 0x02000242 RID: 578
		public enum StunGroup
		{
			// Token: 0x04000EC5 RID: 3781
			Spine,
			// Token: 0x04000EC6 RID: 3782
			ArmLf,
			// Token: 0x04000EC7 RID: 3783
			ArmRt,
			// Token: 0x04000EC8 RID: 3784
			LegLf,
			// Token: 0x04000EC9 RID: 3785
			LegRt,
			// Token: 0x04000ECA RID: 3786
			Head
		}

		// Token: 0x02000243 RID: 579
		// (Invoke) Token: 0x06001131 RID: 4401
		public delegate void NPCDamageRecieved(float damageAmount);

		// Token: 0x02000244 RID: 580
		[Serializable]
		public struct UsageSettings
		{

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06001135 RID: 4405 RVA: 0x00008884 File Offset: 0x00006A84
			public static SubBehaviourHealth.UsageSettings Default
			{
				get
				{
					return default(SubBehaviourHealth.UsageSettings);
				}
			}

			// Token: 0x04000ECB RID: 3787
			public float hips;

			// Token: 0x04000ECC RID: 3788
			public float spine;

			// Token: 0x04000ECD RID: 3789
			public float legLf;

			// Token: 0x04000ECE RID: 3790
			public float legRt;

			// Token: 0x04000ECF RID: 3791
			public float armLf;

			// Token: 0x04000ED0 RID: 3792
			public float armRt;
		}
	}
}
