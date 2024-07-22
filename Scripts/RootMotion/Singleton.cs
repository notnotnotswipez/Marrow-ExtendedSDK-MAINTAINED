using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000E RID: 14
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000031B4 File Offset: 0x000013B4
		public static T instance
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021C4 File Offset: 0x000003C4
		protected virtual void Awake()
		{
		}

		// Token: 0x04000049 RID: 73
		private static T sInstance;
	}
}
