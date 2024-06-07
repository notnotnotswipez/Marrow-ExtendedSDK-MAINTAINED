using System;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200014F RID: 335
	public class DisplaySubsystemManager : SubsystemManager<XRDisplaySubsystem, XRDisplaySubsystemDescriptor>
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x00004948 File Offset: 0x00002B48
		public float GetRefreshRate()
		{
			return 0f;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0000494F File Offset: 0x00002B4F
		public float GetRecommendedPhysFrequency()
		{
			return 0f;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00004956 File Offset: 0x00002B56
		public bool HasFrequencyChanged()
		{
			return false;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00004959 File Offset: 0x00002B59
		public void SetRefreshRate(float refreshRate)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0000495B File Offset: 0x00002B5B
		public void SetFoveationLevel(DisplaySubsystemManager.FoveationLevel level)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0000495D File Offset: 0x00002B5D
		public void EnableLocalDimming(bool value)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000495F File Offset: 0x00002B5F
		public void EnableEyeTrackedFoveatedRendering(bool value)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00004961 File Offset: 0x00002B61
		public void EnableDynamicFFR(bool value)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00004963 File Offset: 0x00002B63
		public bool TryGetAvailableRefreshRates(out float[] refreshRates)
		{
			refreshRates = null;
			return false;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00004969 File Offset: 0x00002B69
		public void SetColorSpaceDesc(DisplaySubsystemManager.ColorSpace colorSpace)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0000496B File Offset: 0x00002B6B
		public bool TryGetIPD(out float ipd)
		{
			ipd = 0f;
			return false;
		}

		// Token: 0x0400076F RID: 1903
		private int _lastFrequency;

		// Token: 0x02000274 RID: 628
		public enum FoveationLevel
		{
			// Token: 0x04000FC9 RID: 4041
			DISABLE,
			// Token: 0x04000FCA RID: 4042
			LOW,
			// Token: 0x04000FCB RID: 4043
			MEDIUM,
			// Token: 0x04000FCC RID: 4044
			HIGH,
			// Token: 0x04000FCD RID: 4045
			HIGH_TOP
		}

		// Token: 0x02000275 RID: 629
		public enum ColorSpace
		{
			// Token: 0x04000FCF RID: 4047
			Unknown,
			// Token: 0x04000FD0 RID: 4048
			Unmanaged,
			// Token: 0x04000FD1 RID: 4049
			Rec_2020,
			// Token: 0x04000FD2 RID: 4050
			Rec_709,
			// Token: 0x04000FD3 RID: 4051
			Rift_CV1,
			// Token: 0x04000FD4 RID: 4052
			Rift_S,
			// Token: 0x04000FD5 RID: 4053
			Quest,
			// Token: 0x04000FD6 RID: 4054
			P3,
			// Token: 0x04000FD7 RID: 4055
			Adobe_RGB
		}
	}
}
