using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000008 RID: 8
	public class Hierarchy
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000020EB File Offset: 0x000002EB
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return false;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020EE File Offset: 0x000002EE
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020F1 File Offset: 0x000002F1
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return false;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020F4 File Offset: 0x000002F4
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return false;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020F7 File Offset: 0x000002F7
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020F9 File Offset: 0x000002F9
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}
	}
}
