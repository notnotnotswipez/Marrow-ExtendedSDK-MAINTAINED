using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200005C RID: 92
	[RequireComponent(typeof(BoxCollider))]
	public class CrateSpawnerGrid : MonoBehaviour
	{
		// Token: 0x0600039B RID: 923 RVA: 0x000030F3 File Offset: 0x000012F3
		private void Reset()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000670C File Offset: 0x0000490C
		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000030F5 File Offset: 0x000012F5
		[ContextMenu("Spawn")]
		public void SpawnGrid()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00006724 File Offset: 0x00004924
		private UniTask SpawnGridAsync()
		{
			return default(UniTask);
		}

		// Token: 0x04000247 RID: 583
		public BoxCollider boxCollider;

		// Token: 0x04000248 RID: 584
		public bool allPallets;

		// Token: 0x04000249 RID: 585
		public List<PalletReference> pallets;

		// Token: 0x0400024A RID: 586
		public float margin;

		// Token: 0x0400024B RID: 587
		public float padding;

		// Token: 0x0400024C RID: 588
		public bool invertDirection;

		// Token: 0x0400024D RID: 589
		public bool manualSpawn;

		// Token: 0x0400024E RID: 590
		public List<SpawnableCrateReference> cratesToExclude;

		// Token: 0x0400024F RID: 591
		[SerializeField]
		[Header("Debug Fields")]
		private List<CrateSpawner> crateSpawners;

		// Token: 0x04000250 RID: 592
		[SerializeField]
		public List<float> rowMarkers;

		// Token: 0x04000251 RID: 593
		[SerializeField]
		public List<float> longestLengths;

		// Token: 0x020001F0 RID: 496
		private struct GridRange
		{

			// Token: 0x04000D15 RID: 3349
			public Vector3 position;

			// Token: 0x04000D16 RID: 3350
			public float xMin;

			// Token: 0x04000D17 RID: 3351
			public float zMin;

			// Token: 0x04000D18 RID: 3352
			public float xMax;

			// Token: 0x04000D19 RID: 3353
			public float zMax;

			// Token: 0x04000D1A RID: 3354
			public float width;

			// Token: 0x04000D1B RID: 3355
			public float length;
		}
	}
}
