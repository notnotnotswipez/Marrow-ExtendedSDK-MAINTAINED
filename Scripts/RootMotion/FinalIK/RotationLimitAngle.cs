using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005C RID: 92
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00002AC9 File Offset: 0x00000CC9
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002ACB File Offset: 0x00000CCB
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002ACD File Offset: 0x00000CCD
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002ACF File Offset: 0x00000CCF
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000393C File Offset: 0x00001B3C
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003954 File Offset: 0x00001B54
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0400031F RID: 799
		[Range(0f, 180f)]
		public float limit;

		// Token: 0x04000320 RID: 800
		[Range(0f, 180f)]
		public float twistLimit;
	}
}
