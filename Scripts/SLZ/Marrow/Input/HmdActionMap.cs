using System;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000152 RID: 338
	public class HmdActionMap : XRHMD, InputActions.IHMDActions
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public override string DeviceInfo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00004AEB File Offset: 0x00002CEB
		public override void OnPostNewInputUpdate()
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00004AED File Offset: 0x00002CED
		void SLZ.Marrow.Input.InputActions.IHMDActions.OnTrackingState(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00004AEF File Offset: 0x00002CEF
		 void SLZ.Marrow.Input.InputActions.IHMDActions.OnPosition(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00004AF1 File Offset: 0x00002CF1
		 void SLZ.Marrow.Input.InputActions.IHMDActions.OnRotation(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00004AF3 File Offset: 0x00002CF3
		 void SLZ.Marrow.Input.InputActions.IHMDActions.OnVelocity(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00004AF5 File Offset: 0x00002CF5
		 void SLZ.Marrow.Input.InputActions.IHMDActions.OnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00004AF7 File Offset: 0x00002CF7
		 void SLZ.Marrow.Input.InputActions.IHMDActions.OnIsTracked(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00004AF9 File Offset: 0x00002CF9
		public override void Refresh()
		{
		}

		// Token: 0x040007B3 RID: 1971
		private InputDevice _isDevice;

		// Token: 0x040007B4 RID: 1972
		private Vector3 _position;

		// Token: 0x040007B5 RID: 1973
		private Quaternion _rotation;

		// Token: 0x040007B6 RID: 1974
		private double _poseUpdateTime;

		// Token: 0x040007B7 RID: 1975
		private double _lastPoseUpdateTime;
	}
}
