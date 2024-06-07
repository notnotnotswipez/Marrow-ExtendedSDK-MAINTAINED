using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000120 RID: 288
	public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00007B1C File Offset: 0x00005D1C
		public static T Instance
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000043BD File Offset: 0x000025BD
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x000043C0 File Offset: 0x000025C0
		public bool Killing
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000043C2 File Offset: 0x000025C2
		public static bool HasInstance()
		{
			return false;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000043C5 File Offset: 0x000025C5
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0400064C RID: 1612
		private static T _instance;

		// Token: 0x0400064D RID: 1613
		private bool _killing;

		// Token: 0x0400064E RID: 1614
		private static bool creatingInstance;

		// Token: 0x0400064F RID: 1615
		private static bool debug;
	}
}
