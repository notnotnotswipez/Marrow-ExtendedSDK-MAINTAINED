using System;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000165 RID: 357
	public class XRTracker : XRDevice
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x00004DF3 File Offset: 0x00002FF3
		public XRTracker(string name)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00004DFB File Offset: 0x00002FFB
		public override bool IsTracking
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00004DFE File Offset: 0x00002FFE
		public void ReadPoseContext(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00004E00 File Offset: 0x00003000
		public void ReadTrackingStateContext(InputAction.CallbackContext context)
		{
		}

		// Token: 0x040009D2 RID: 2514
		public readonly string name;

		// Token: 0x040009D3 RID: 2515
		private bool _isTracking;
	}
}
