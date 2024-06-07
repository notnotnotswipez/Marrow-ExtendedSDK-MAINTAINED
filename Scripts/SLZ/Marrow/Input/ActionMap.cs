using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200014D RID: 333
	public class ActionMap
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000048F0 File Offset: 0x00002AF0
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000048F3 File Offset: 0x00002AF3
		public InputDevice ISDevice
		{
			[CompilerGenerated]
			get
			{
				return default(InputDevice);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000048F5 File Offset: 0x00002AF5
		public virtual void OnPreNewInputUpdate()
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000048F7 File Offset: 0x00002AF7
		public virtual void OnPostNewInputUpdate()
		{
		}
	}
}
