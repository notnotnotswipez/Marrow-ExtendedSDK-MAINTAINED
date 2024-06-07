using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000161 RID: 353
	public class XRDevice
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0000802C File Offset: 0x0000622C
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00004D4D File Offset: 0x00002F4D
		public virtual InputDeviceCharacteristics Characteristics
		{
			[CompilerGenerated]
			get
			{
				return InputDeviceCharacteristics.None;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00004D4F File Offset: 0x00002F4F
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00004D52 File Offset: 0x00002F52
		public virtual string DeviceInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00004D54 File Offset: 0x00002F54
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x00004D57 File Offset: 0x00002F57
		public virtual bool IsConnected
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00004D59 File Offset: 0x00002F59
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00004D5C File Offset: 0x00002F5C
		public virtual bool IsTracking
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00008044 File Offset: 0x00006244
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00004D5E File Offset: 0x00002F5E
		public Vector3 Position
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0000805C File Offset: 0x0000625C
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00004D60 File Offset: 0x00002F60
		public Quaternion Rotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00008074 File Offset: 0x00006274
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00004D62 File Offset: 0x00002F62
		public Vector3 Velocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0000808C File Offset: 0x0000628C
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00004D64 File Offset: 0x00002F64
		public Vector3 AngularVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00004D66 File Offset: 0x00002F66
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00004D71 File Offset: 0x00002F71
		public double UpdateTime
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00004D73 File Offset: 0x00002F73
		public virtual void OnFrameStart()
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00004D75 File Offset: 0x00002F75
		public virtual void OnPreNewInputUpdate()
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00004D77 File Offset: 0x00002F77
		public virtual void OnPostNewInputUpdate()
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00004D79 File Offset: 0x00002F79
		public virtual void Refresh()
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000080A4 File Offset: 0x000062A4
		public SimpleTransform GetPoseAtFixedTime(double fixedTime)
		{
			return default(SimpleTransform);
		}

		// Token: 0x0400099B RID: 2459
		private List<InputDevice> _xrDevices;

		// Token: 0x0400099C RID: 2460
		protected InputDevice _xrDevice;

		// Token: 0x040009A5 RID: 2469
		private double _lastUpdateTime;

		// Token: 0x040009A6 RID: 2470
		private Vector3 _lastPosition;

		// Token: 0x040009A7 RID: 2471
		private Quaternion _lastRotation;
	}
}
