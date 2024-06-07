using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000EB RID: 235
	public class SkinnedBoneRebind : MonoBehaviour
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x000040E7 File Offset: 0x000022E7
		private void Awake()
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000040E9 File Offset: 0x000022E9
		private void RebindTool()
		{
		}

		// Token: 0x040005E0 RID: 1504
		public Transform[] bones;

		// Token: 0x040005E1 RID: 1505
		public bool[] rebindBone;

		// Token: 0x040005E2 RID: 1506
		public SkinnedMeshRenderer skinnedMeshRenderer;

		// Token: 0x040005E3 RID: 1507
		[Header("Bind Pose Tool")]
		public Mesh meshToRead;

		// Token: 0x040005E4 RID: 1508
		public Mesh meshToWrite;
	}
}
