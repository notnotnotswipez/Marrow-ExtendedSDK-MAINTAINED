using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000197 RID: 407
	[CreateAssetMenu(fileName = "New ProjectileData", menuName = "Variables/Projectile Data", order = 3)]
	public class ProjectileData : ScriptableObject
	{
		// Token: 0x04000A8D RID: 2701
		[Header("Dependencies")]
		public Spawnable spawnable;

		// Token: 0x04000A8E RID: 2702
		[Header("Physics Settings")]
		[Tooltip("Kilograms")]
		public float mass;

		// Token: 0x04000A8F RID: 2703
		[Tooltip("Meters per second")]
		public float startVelocity;

		// Token: 0x04000A90 RID: 2704
		[Header("Damage Settings")]
		public AttackType AttackType;

		// Token: 0x04000A91 RID: 2705
		[Tooltip("Multiplier to hit damage math")]
		public float damageMultiplier;

		// Token: 0x04000A92 RID: 2706
		[Range(1f, 10f)]
		[Header("Emission Settings")]
		[Tooltip("Number of copies spawned")]
		public int count;

		// Token: 0x04000A93 RID: 2707
		public EmissionType emissionType;

		// Token: 0x04000A94 RID: 2708
		[Range(0f, 180f)]
		[Tooltip("Spread angle in cone emission")]
		public float angle;

		// Token: 0x04000A95 RID: 2709
		[Range(0f, 1f)]
		[Tooltip("Start distance from center")]
		public float radius;
	}
}
