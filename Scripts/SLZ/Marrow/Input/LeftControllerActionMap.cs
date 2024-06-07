using System;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000156 RID: 342
	public class LeftControllerActionMap : ControllerActionMap, InputActions.IControllerLActions
	{
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00007F3C File Offset: 0x0000613C
		public override InputDeviceCharacteristics Characteristics
		{
			get
			{
				return InputDeviceCharacteristics.None;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00004B42 File Offset: 0x00002D42
		protected void ProcessDeviceInfo(InputSystem.InputDevice device)
		{
		}
	}

	public class InputSystem
	{
		public class InputDevice
		{
			
		}
	}
}
