using System;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000167 RID: 359
	public class XRUICursorReceiver : MonoBehaviour
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x00004E25 File Offset: 0x00003025
		private void Awake()
		{
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00004E27 File Offset: 0x00003027
		public static XRUIInputModule Register(IUIInteractor uiInteractor)
		{
			return null;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00004E2A File Offset: 0x0000302A
		public static void UnRegister(IUIInteractor uiInteractor)
		{
		}

		// Token: 0x040009DB RID: 2523
		[SerializeField]
		private XRUIInputModule _InputModule;

		// Token: 0x040009DC RID: 2524
		[SerializeField]
		private Poolee _poolee;

		// Token: 0x040009DD RID: 2525
		private static XRUICursorReceiver _instance;
	}
}
