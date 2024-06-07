using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000160 RID: 352
	public class XRController : XRDevice
	{
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00007FE4 File Offset: 0x000061E4
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x00004C5E File Offset: 0x00002E5E
		public virtual XRControllerType Type
		{
			[CompilerGenerated]
			get
			{
				return XRControllerType.OculusTouch;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00004C60 File Offset: 0x00002E60
		public override bool IsConnected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00007FFC File Offset: 0x000061FC
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00004C63 File Offset: 0x00002E63
		public Vector2 Joystick2DAxis
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00004C65 File Offset: 0x00002E65
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00004C68 File Offset: 0x00002E68
		public bool JoystickButton
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00004C6A File Offset: 0x00002E6A
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00004C6D File Offset: 0x00002E6D
		public bool JoystickButtonUp
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00004C6F File Offset: 0x00002E6F
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00004C72 File Offset: 0x00002E72
		public bool JoystickButtonDown
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00004C74 File Offset: 0x00002E74
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00004C77 File Offset: 0x00002E77
		public bool JoystickTouch
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00008014 File Offset: 0x00006214
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00004C79 File Offset: 0x00002E79
		public Vector2 Touchpad2DAxis
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00004C7B File Offset: 0x00002E7B
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00004C7E File Offset: 0x00002E7E
		public bool TouchpadButton
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00004C80 File Offset: 0x00002E80
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00004C83 File Offset: 0x00002E83
		public bool TouchpadButtonUp
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00004C85 File Offset: 0x00002E85
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00004C88 File Offset: 0x00002E88
		public bool TouchpadButtonDown
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00004C8A File Offset: 0x00002E8A
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00004C8D File Offset: 0x00002E8D
		public bool TouchpadTouch
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00004C8F File Offset: 0x00002E8F
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00004C96 File Offset: 0x00002E96
		public float Trigger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00004C98 File Offset: 0x00002E98
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00004C9F File Offset: 0x00002E9F
		public float TriggerForce
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00004CA1 File Offset: 0x00002EA1
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public bool TriggerButton
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00004CA6 File Offset: 0x00002EA6
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00004CA9 File Offset: 0x00002EA9
		public bool TriggerButtonUp
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00004CAB File Offset: 0x00002EAB
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00004CAE File Offset: 0x00002EAE
		public bool TriggerButtonDown
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00004CB0 File Offset: 0x00002EB0
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00004CB3 File Offset: 0x00002EB3
		public bool TriggerTouched
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00004CB5 File Offset: 0x00002EB5
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public bool GripButton
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00004CBA File Offset: 0x00002EBA
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00004CBD File Offset: 0x00002EBD
		public bool GripButtonUp
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00004CBF File Offset: 0x00002EBF
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00004CC2 File Offset: 0x00002EC2
		public bool GripButtonDown
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00004CC4 File Offset: 0x00002EC4
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00004CCB File Offset: 0x00002ECB
		public float Grip
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00004CCD File Offset: 0x00002ECD
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public float GripForce
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00004CD6 File Offset: 0x00002ED6
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00004CDD File Offset: 0x00002EDD
		public float GripVelocity
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00004CDF File Offset: 0x00002EDF
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public bool AButton
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00004CE4 File Offset: 0x00002EE4
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00004CE7 File Offset: 0x00002EE7
		public bool AButtonUp
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00004CE9 File Offset: 0x00002EE9
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00004CEC File Offset: 0x00002EEC
		public bool AButtonDown
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00004CEE File Offset: 0x00002EEE
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public bool ATouch
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00004CF3 File Offset: 0x00002EF3
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00004CF6 File Offset: 0x00002EF6
		public bool BButton
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00004CF8 File Offset: 0x00002EF8
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x00004CFB File Offset: 0x00002EFB
		public bool BButtonUp
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00004CFD File Offset: 0x00002EFD
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00004D00 File Offset: 0x00002F00
		public bool BButtonDown
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00004D02 File Offset: 0x00002F02
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00004D05 File Offset: 0x00002F05
		public bool BTouch
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00004D07 File Offset: 0x00002F07
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00004D0A File Offset: 0x00002F0A
		public bool MenuButton
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00004D0C File Offset: 0x00002F0C
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00004D0F File Offset: 0x00002F0F
		public bool MenuButtonUp
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00004D11 File Offset: 0x00002F11
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00004D14 File Offset: 0x00002F14
		public bool MenuButtonDown
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00004D16 File Offset: 0x00002F16
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00004D1D File Offset: 0x00002F1D
		public float RingFinger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00004D1F File Offset: 0x00002F1F
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00004D26 File Offset: 0x00002F26
		public float IndexFinger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00004D28 File Offset: 0x00002F28
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00004D2F File Offset: 0x00002F2F
		public float PinkyFinger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00004D31 File Offset: 0x00002F31
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00004D38 File Offset: 0x00002F38
		public float MiddleFinger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00004D3A File Offset: 0x00002F3A
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00004D41 File Offset: 0x00002F41
		public float ThumbFinger
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00004D43 File Offset: 0x00002F43
		public virtual void SetHaptic(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}
	}
}
