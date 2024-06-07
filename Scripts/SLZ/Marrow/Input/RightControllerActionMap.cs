using System;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000159 RID: 345
	public class RightControllerActionMap : ControllerActionMap, InputActions.IControllerRActions
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00007F54 File Offset: 0x00006154
		public override InputDeviceCharacteristics Characteristics
		{
			get
			{
				return InputDeviceCharacteristics.None;
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00004B5C File Offset: 0x00002D5C
		protected void ProcessDeviceInfo(InputSystem.InputDevice device)
		{
		}
	}
}
