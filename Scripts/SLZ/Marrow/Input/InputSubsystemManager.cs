using System;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000155 RID: 341
	public class InputSubsystemManager : SubsystemManager<XRInputSubsystem, XRInputSubsystemDescriptor>
	{
		// Token: 0x06000CEE RID: 3310 RVA: 0x00004B35 File Offset: 0x00002D35
		public void TryRecenter()
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00004B37 File Offset: 0x00002D37
		public bool HasFocus()
		{
			return false;
		}
	}
}
