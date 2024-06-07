using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Combat
{
	// Token: 0x020001AE RID: 430
	[Serializable]
	public class PosespaceImpactManager
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00005195 File Offset: 0x00003395
		public int count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00005198 File Offset: 0x00003398
		[MethodImpl(256)]
		public void AddImpact(ref Matrix4x4 hitMatrix)
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0000519A File Offset: 0x0000339A
		public void RemoveImpacts(int removeCount)
		{
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0000519C File Offset: 0x0000339C
		public void ClearImpacts()
		{
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00008434 File Offset: 0x00006634
		public Matrix4x4 GetImpact(int index)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0000519E File Offset: 0x0000339E
		public void SetImpactsOnMaterial(Material mat)
		{
		}

		// Token: 0x04000AD6 RID: 2774
		private const int MAX_HITS = 32;

		// Token: 0x04000AD7 RID: 2775
		public static int EllipsoidPosArrayID;

		// Token: 0x04000AD8 RID: 2776
		public static int NumberOfHitsID;

		// Token: 0x04000AD9 RID: 2777
		[NonSerialized]
		public Matrix4x4[] hitDataMatrixArray;

		// Token: 0x04000ADA RID: 2778
		[NonSerialized]
		private int m_Count;

		// Token: 0x04000ADB RID: 2779
		[NonSerialized]
		private int ptr;
	}
}
