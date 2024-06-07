using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000196 RID: 406
	public class PlatformSelectionData : ScriptableObject
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000050BE File Offset: 0x000032BE
		public static PlatformSelectionData LocalData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000050C1 File Offset: 0x000032C1
		public static string AppId()
		{
			return null;
		}

		// Token: 0x04000A88 RID: 2696
		[SerializeField]
		public VRPlatform platform;

		// Token: 0x04000A89 RID: 2697
		[SerializeField]
		public string appId;

		// Token: 0x04000A8A RID: 2698
		[SerializeField]
		public string timeBuilt;

		// Token: 0x04000A8B RID: 2699
		private static string PLATFORM_LOCAL_DATA_PATH;

		// Token: 0x04000A8C RID: 2700
		private static PlatformSelectionData _localData;
	}
}
