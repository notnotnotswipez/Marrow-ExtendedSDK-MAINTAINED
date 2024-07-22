using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006F RID: 111
	public class VRIKRootController : MonoBehaviour
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00003A5C File Offset: 0x00001C5C
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002C0B File Offset: 0x00000E0B
		public Vector3 pelvisTargetRight
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002C0D File Offset: 0x00000E0D
		private void Awake()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002C0F File Offset: 0x00000E0F
		public void Calibrate()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002C11 File Offset: 0x00000E11
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002C13 File Offset: 0x00000E13
		private void OnPreUpdate()
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002C15 File Offset: 0x00000E15
		private void OnDestroy()
		{
		}

		// Token: 0x04000391 RID: 913
		private Transform pelvisTarget;

		// Token: 0x04000392 RID: 914
		private Transform leftFootTarget;

		// Token: 0x04000393 RID: 915
		private Transform rightFootTarget;

		// Token: 0x04000394 RID: 916
		private VRIK ik;
	}
}
