using System;
using UnityEngine;

namespace SLZ.Marrow.UnityExtensions
{
	// Token: 0x020000C3 RID: 195
	public static class TransformExtensions
	{
		// Token: 0x060006E6 RID: 1766 RVA: 0x00003AE1 File Offset: 0x00001CE1
		public static Transform FindDeepChild(this Transform aParent, TransformExtensions.Filter callback)
		{
			return null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public static Transform FindDeepChild(this Transform aParent, string aName)
		{
			return null;
		}

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x060010E0 RID: 4320
		public delegate bool Filter(GameObject go);
	}
}
