using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006D RID: 109
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private void Start()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002BFA File Offset: 0x00000DFA
		private void RotateShoulders()
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002BFC File Offset: 0x00000DFC
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002BFE File Offset: 0x00000DFE
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002C01 File Offset: 0x00000E01
		private void OnDestroy()
		{
		}

		// Token: 0x0400038C RID: 908
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		// Token: 0x0400038D RID: 909
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		// Token: 0x0400038E RID: 910
		private FullBodyBipedIK ik;

		// Token: 0x0400038F RID: 911
		private bool skip;
	}
}
