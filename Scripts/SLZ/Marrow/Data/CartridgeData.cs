using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200018A RID: 394
	[CreateAssetMenu(fileName = "New Bullet Value", menuName = "Variables/Bullet Item", order = 3)]
	public class CartridgeData : ScriptableObject
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0000507B File Offset: 0x0000327B
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0000507E File Offset: 0x0000327E
		private void Awake()
		{
		}

		// Token: 0x04000A32 RID: 2610
		private string _name;

		// Token: 0x04000A33 RID: 2611
		public ProjectileData projectile;

		// Token: 0x04000A34 RID: 2612
		[Header("Dependencies")]
		public Spawnable cartridgeSpawnable;

		// Token: 0x04000A35 RID: 2613
		public Spawnable cartridgeCaseSpawnable;
	}
}
