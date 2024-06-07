using System;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200014E RID: 334
	public class ControllerActionMap : XRController
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00004901 File Offset: 0x00002B01
		public override string DeviceInfo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00004904 File Offset: 0x00002B04
		protected virtual void ProcessDeviceInfo(InputDevice device)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00004906 File Offset: 0x00002B06
		public override void OnPreNewInputUpdate()
		{
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00004908 File Offset: 0x00002B08
		public override void OnPostNewInputUpdate()
		{
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0000490A File Offset: 0x00002B0A
		public void SetHapticInputAction(InputAction hapticAction)
		{
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0000490C File Offset: 0x00002B0C
		public override void SetHaptic(float secondsFromNow, float duration, float frequency, float amplitude)
		{
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0000490E File Offset: 0x00002B0E
		public void OnPalmPose(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00004910 File Offset: 0x00002B10
		public void OnPointerPose(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00004912 File Offset: 0x00002B12
		public void OnTrackingState(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00004914 File Offset: 0x00002B14
		public void OnVelocity(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00004916 File Offset: 0x00002B16
		public void OnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00004918 File Offset: 0x00002B18
		public void OnPrimary2DAxis(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000491A File Offset: 0x00002B1A
		public void OnPrimary2DAxisClick(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0000491C File Offset: 0x00002B1C
		public void OnPrimary2DAxisTouch(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0000491E File Offset: 0x00002B1E
		public void OnTouchpad(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00004920 File Offset: 0x00002B20
		public void OnTouchpadClick(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00004922 File Offset: 0x00002B22
		public void OnTouchpadTouch(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00004924 File Offset: 0x00002B24
		public void OnTrigger(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00004926 File Offset: 0x00002B26
		public void OnTriggerPress(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00004928 File Offset: 0x00002B28
		public void OnTriggerTouch(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0000492A File Offset: 0x00002B2A
		public void OnGrip(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0000492C File Offset: 0x00002B2C
		public void OnGripPress(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0000492E File Offset: 0x00002B2E
		public void OnGripForce(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00004930 File Offset: 0x00002B30
		public void OnPrimaryButton(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00004932 File Offset: 0x00002B32
		public void OnPrimaryTouch(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00004934 File Offset: 0x00002B34
		public void OnSecondaryButton(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00004936 File Offset: 0x00002B36
		public void OnSecondaryTouch(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00004938 File Offset: 0x00002B38
		public void OnMenuButton(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0000493A File Offset: 0x00002B3A
		public void OnHaptic(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0000493C File Offset: 0x00002B3C
		public void OnIsTracked(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0000493E File Offset: 0x00002B3E
		public override void Refresh()
		{
		}

		// Token: 0x04000764 RID: 1892
		private InputDevice _isDevice;

		// Token: 0x04000765 RID: 1893
		private InputAction _hapticInputAction;

		// Token: 0x04000766 RID: 1894
		private float _simIndexTouch;

		// Token: 0x04000767 RID: 1895
		private Vector3 _position;

		// Token: 0x04000768 RID: 1896
		private Vector3 _pointerPosition;

		// Token: 0x04000769 RID: 1897
		protected Vector3 _offsetPosition;

		// Token: 0x0400076A RID: 1898
		private Quaternion _rotation;

		// Token: 0x0400076B RID: 1899
		private Quaternion _pointerRotation;

		// Token: 0x0400076C RID: 1900
		protected Quaternion _offsetRotation;

		// Token: 0x0400076D RID: 1901
		private double _poseUpdateTime;

		// Token: 0x0400076E RID: 1902
		private double _lastPoseUpdateTime;
	}

	public class InputAction
	{
		public class CallbackContext
		{
			
		}
	}
}
