using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Combat
{
	// Token: 0x020001AF RID: 431
	public class VisualDamageController : MonoBehaviour
	{
		// Token: 0x06000F0B RID: 3851 RVA: 0x000051AA File Offset: 0x000033AA
		public bool isLODVisible()
		{
			return false;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000051AD File Offset: 0x000033AD
		public void AddToHitArray(Matrix4x4 Matrix)
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000051AF File Offset: 0x000033AF
		public void AddToCutArray(Matrix4x4 Matrix)
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000051B1 File Offset: 0x000033B1
		public void ResetHits()
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000051B3 File Offset: 0x000033B3
		private void Awake()
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000051B5 File Offset: 0x000033B5
		private void OnEnable()
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000051B7 File Offset: 0x000033B7
		private void InitializeBlock()
		{
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000051B9 File Offset: 0x000033B9
		public void UpdateArray()
		{
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000051BB File Offset: 0x000033BB
		public void collectSkins()
		{
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000051BD File Offset: 0x000033BD
		private IEnumerator BleedOverTimer()
		{
			return null;
		}

		// Token: 0x04000ADC RID: 2780
		[NonSerialized]
		private const int MAX_HITS = 32;

		// Token: 0x04000ADD RID: 2781
		[NonSerialized]
		private int Count;

		// Token: 0x04000ADE RID: 2782
		private PosespaceImpactManager impactManager;

		// Token: 0x04000ADF RID: 2783
		[NonSerialized]
		private const int MAX_HITS_CUT = 8;

		// Token: 0x04000AE0 RID: 2784
		[NonSerialized]
		private int Count_CUT;

		// Token: 0x04000AE1 RID: 2785
		[NonSerialized]
		private List<Matrix4x4> CutPoint;

		// Token: 0x04000AE2 RID: 2786
		[NonSerialized]
		private Matrix4x4[] CutPos;

		// Token: 0x04000AE3 RID: 2787
		[Tooltip("Renderers to set hit variables for")]
		public Renderer[] Renderers;

		// Token: 0x04000AE4 RID: 2788
		public float meshScaleFactor;

		// Token: 0x04000AE5 RID: 2789
		public float hitScaleFactor;

		// Token: 0x04000AE6 RID: 2790
		private int NumberOfHits;

		// Token: 0x04000AE7 RID: 2791
		private int NumberOfCuts;

		// Token: 0x04000AE8 RID: 2792
		private int NumberOfHitsID;

		// Token: 0x04000AE9 RID: 2793
		private int EllipsoidPosArrayID;

		// Token: 0x04000AEA RID: 2794
		private int ElipsoidMatricesID;

		// Token: 0x04000AEB RID: 2795
		private int NumberOfElipsoidsID;
	}
}
