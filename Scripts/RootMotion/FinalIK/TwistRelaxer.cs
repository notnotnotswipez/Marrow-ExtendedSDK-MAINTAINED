using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000050 RID: 80
	public class TwistRelaxer : MonoBehaviour
	{
		// Token: 0x0600030E RID: 782 RVA: 0x000028AB File Offset: 0x00000AAB
		public void Relax()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000028AD File Offset: 0x00000AAD
		private void Start()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000028AF File Offset: 0x00000AAF
		private void OnPostUpdate()
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000028B1 File Offset: 0x00000AB1
		private void LateUpdate()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000028B3 File Offset: 0x00000AB3
		private void OnDestroy()
		{
		}

		// Token: 0x0400029F RID: 671
		public IK ik;

		// Token: 0x040002A0 RID: 672
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		// Token: 0x040002A1 RID: 673
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		// Token: 0x040002A2 RID: 674
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040002A3 RID: 675
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		// Token: 0x040002A4 RID: 676
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		// Token: 0x040002A5 RID: 677
		private Vector3 twistAxis;

		// Token: 0x040002A6 RID: 678
		private Vector3 axis;

		// Token: 0x040002A7 RID: 679
		private Vector3 axisRelativeToParentDefault;

		// Token: 0x040002A8 RID: 680
		private Vector3 axisRelativeToChildDefault;
	}
}
