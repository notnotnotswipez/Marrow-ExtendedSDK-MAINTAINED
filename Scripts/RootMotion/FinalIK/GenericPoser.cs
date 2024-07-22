using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000057 RID: 87
	public class GenericPoser : Poser
	{
		// Token: 0x06000396 RID: 918 RVA: 0x00002A49 File Offset: 0x00000C49
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002A4B File Offset: 0x00000C4B
		protected override void InitiatePoser()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002A4D File Offset: 0x00000C4D
		protected override void UpdatePoser()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002A4F File Offset: 0x00000C4F
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002A51 File Offset: 0x00000C51
		private void StoreDefaultState()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002A53 File Offset: 0x00000C53
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		// Token: 0x040002FF RID: 767
		public GenericPoser.Map[] maps;

		// Token: 0x020000A5 RID: 165
		[Serializable]
		public class Map
		{
			// Token: 0x0600052E RID: 1326 RVA: 0x00002ECC File Offset: 0x000010CC
			public Map(Transform bone, Transform target)
			{
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00002ED4 File Offset: 0x000010D4
			public void StoreDefaultState()
			{
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00002ED6 File Offset: 0x000010D6
			public void FixTransform()
			{
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00002ED8 File Offset: 0x000010D8
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}

			// Token: 0x04000521 RID: 1313
			public Transform bone;

			// Token: 0x04000522 RID: 1314
			public Transform target;

			// Token: 0x04000523 RID: 1315
			private Vector3 defaultLocalPosition;

			// Token: 0x04000524 RID: 1316
			private Quaternion defaultLocalRotation;
		}
	}
}
