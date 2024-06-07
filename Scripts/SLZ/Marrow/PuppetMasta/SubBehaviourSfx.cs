using System;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class SubBehaviourSfx : SubBehaviourBase
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x00003E42 File Offset: 0x00002042
		public void Initiate(BehaviourBase b)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00003E44 File Offset: 0x00002044
		public void Respawn()
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00003E46 File Offset: 0x00002046
		public void BlockImpactsFor(float time)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00003E48 File Offset: 0x00002048
		public void Impact(MuscleCollision m, float impulse)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00003E4A File Offset: 0x0000204A
		public void Agro()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00003E4C File Offset: 0x0000204C
		public void AttenuateAgroLoop(float volume, float pitch)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00003E4E File Offset: 0x0000204E
		public void AttenuateMovementLoop(float volume, float pitch)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00003E50 File Offset: 0x00002050
		public void AttenuateDot1Loop(float volume, float pitch, float minDistance)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00003E52 File Offset: 0x00002052
		public void UnAgro()
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00003E54 File Offset: 0x00002054
		public void JumpCharge()
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00003E56 File Offset: 0x00002056
		public void Jump(float jumpCharge)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00003E58 File Offset: 0x00002058
		public void Pain(float magnitude)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00003E5A File Offset: 0x0000205A
		public void Death()
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00003E5C File Offset: 0x0000205C
		public void SmallEffort()
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00003E5E File Offset: 0x0000205E
		public void Attack1()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00003E60 File Offset: 0x00002060
		public void Attack2()
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00003E62 File Offset: 0x00002062
		public void AttackLand1()
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00003E64 File Offset: 0x00002064
		public void StopLoopSource()
		{
		}

		// Token: 0x040004FD RID: 1277
		public AudioClip[] agro;

		// Token: 0x040004FE RID: 1278
		public AudioClip[] unAgro;

		// Token: 0x040004FF RID: 1279
		public AudioClip[] painSmall;

		// Token: 0x04000500 RID: 1280
		public AudioClip[] painBig;

		// Token: 0x04000501 RID: 1281
		public AudioClip[] death;

		// Token: 0x04000502 RID: 1282
		public AudioClip[] jumpCharge;

		// Token: 0x04000503 RID: 1283
		public AudioClip[] jump;

		// Token: 0x04000504 RID: 1284
		public AudioClip[] smallEffort;

		// Token: 0x04000505 RID: 1285
		public AudioClip[] mediumEffort;

		// Token: 0x04000506 RID: 1286
		public AudioClip[] largeEffort;

		// Token: 0x04000507 RID: 1287
		public AudioClip[] attack1;

		// Token: 0x04000508 RID: 1288
		public AudioClip[] attackLand1;

		// Token: 0x04000509 RID: 1289
		public AudioClip[] attack2;

		// Token: 0x0400050A RID: 1290
		public AudioClip[] impactHead;

		// Token: 0x0400050B RID: 1291
		public AudioClip[] impactSpine;

		// Token: 0x0400050C RID: 1292
		public AudioClip[] impactLimb;

		// Token: 0x0400050D RID: 1293
		public AudioClip dotLoop1;

		// Token: 0x0400050E RID: 1294
		public AudioClip agroMovementLoop;

		// Token: 0x0400050F RID: 1295
		public AudioClip movementLoop;

		// Token: 0x04000510 RID: 1296
		[SerializeField]
		private float pitchMultiplier;

		// Token: 0x04000511 RID: 1297
		private AudioSource _mouthSource;

		// Token: 0x04000512 RID: 1298
		public AudioSource impactSource;

		// Token: 0x04000513 RID: 1299
		private AudioSource _loopSource;

		// Token: 0x04000514 RID: 1300
		private float _impactCooldownTime;

		// Token: 0x04000515 RID: 1301
		private float _lastImpactImpulse;

		// Token: 0x04000516 RID: 1302
		private ManagedAudioPlayer _mapMovement;

		// Token: 0x04000517 RID: 1303
		private ManagedAudioPlayer _mapDotLoop;
	}
}
