using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005D RID: 93
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitHinge : RotationLimit
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x00002AD9 File Offset: 0x00000CD9
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002ADB File Offset: 0x00000CDB
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002ADD File Offset: 0x00000CDD
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002ADF File Offset: 0x00000CDF
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000396C File Offset: 0x00001B6C
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00003984 File Offset: 0x00001B84
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x04000321 RID: 801
		public bool useLimits;

		// Token: 0x04000322 RID: 802
		public float min;

		// Token: 0x04000323 RID: 803
		public float max;

		// Token: 0x04000324 RID: 804
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		// Token: 0x04000325 RID: 805
		private Quaternion lastRotation;

		// Token: 0x04000326 RID: 806
		private float lastAngle;
	}
}
