using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005F RID: 95
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00002B0E File Offset: 0x00000D0E
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002B10 File Offset: 0x00000D10
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002B12 File Offset: 0x00000D12
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002B14 File Offset: 0x00000D14
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002B16 File Offset: 0x00000D16
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000039FC File Offset: 0x00001BFC
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003A14 File Offset: 0x00001C14
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0400032C RID: 812
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x0400032D RID: 813
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;
	}
}
