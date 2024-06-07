using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine.XR.Management;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200015C RID: 348
	public class XRApi
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00004BDF File Offset: 0x00002DDF
		public XRManagerSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00004BE4 File Offset: 0x00002DE4
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00004BE2 File Offset: 0x00002DE2
		public XRHMD HMD
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00004BE9 File Offset: 0x00002DE9
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public XRController LeftController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00004BEE File Offset: 0x00002DEE
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00004BEC File Offset: 0x00002DEC
		public XRController RightController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00004BF3 File Offset: 0x00002DF3
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00004BF1 File Offset: 0x00002DF1
		public XRHand LeftHand
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00004BF8 File Offset: 0x00002DF8
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00004BF6 File Offset: 0x00002DF6
		public XRHand RightHand
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00004BFD File Offset: 0x00002DFD
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00004BFB File Offset: 0x00002DFB
		public XRBody Body
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00004C02 File Offset: 0x00002E02
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00004C00 File Offset: 0x00002E00
		public GamepadActionMap Gamepad
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00004C07 File Offset: 0x00002E07
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00004C05 File Offset: 0x00002E05
		public ViveTrackerActionMap Trackers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00004C0C File Offset: 0x00002E0C
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00004C0A File Offset: 0x00002E0A
		public DisplaySubsystemManager Display
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00004C11 File Offset: 0x00002E11
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00004C0F File Offset: 0x00002E0F
		public InputSubsystemManager Input
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00004C16 File Offset: 0x00002E16
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00004C14 File Offset: 0x00002E14
		public MeshSubsystemManager Mesh
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00004C1B File Offset: 0x00002E1B
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00004C19 File Offset: 0x00002E19
		public bool HasPalmPoseFeature
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00004C26 File Offset: 0x00002E26
		private static bool IsFeatureSupported<TFeature>() where TFeature : OpenXRFeature
		{
			return false;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00007F9C File Offset: 0x0000619C
		public UniTask Initialize()
		{
			return default(UniTask);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00004C29 File Offset: 0x00002E29
		public void Deinitialize()
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00004C2B File Offset: 0x00002E2B
		public void Refresh()
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00004C2D File Offset: 0x00002E2D
		private void OnStartFrame()
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00004C2F File Offset: 0x00002E2F
		private void OnPreNewInputUpdate()
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00004C31 File Offset: 0x00002E31
		private void OnPostNewInputUpdate()
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00007FB4 File Offset: 0x000061B4
		private UniTask InitializeXRLoader()
		{
			return default(UniTask);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00007FCC File Offset: 0x000061CC
		private UniTaskVoid WatchXRChanges()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0400090D RID: 2317
		private readonly CancellationTokenSource _cts;

		// Token: 0x0400090E RID: 2318
		private InputActions _inputActions;
	}

	internal class OpenXRFeature
	{
	}
}
