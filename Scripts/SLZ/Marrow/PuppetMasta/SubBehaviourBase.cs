using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000D9 RID: 217
	[Serializable]
	public abstract class SubBehaviourBase
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00007324 File Offset: 0x00005524
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000733C File Offset: 0x0000553C
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00007354 File Offset: 0x00005554
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000736C File Offset: 0x0000556C
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		// Token: 0x040004BD RID: 1213
		protected BehaviourBase behaviour;
	}
}
