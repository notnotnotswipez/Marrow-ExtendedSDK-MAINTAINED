using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B5 RID: 181
	[MarrowPlugin("SLZ.Marrow.VoidLogic", "VoidLogicPlugin", "0.0.1")]
	public class VoidLogicPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000039E9 File Offset: 0x00001BE9
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000039EC File Offset: 0x00001BEC
		public static VoidLogicManager CurrentManager
		{
			[CompilerGenerated]
			[MethodImpl(256)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00006D9C File Offset: 0x00004F9C
		UniTask SLZ.Marrow.Plugins.IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public UniTask OnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x0400036D RID: 877
		[PublicAPI]
		public const string PluginNamespace = "SLZ.Marrow.VoidLogic";

		// Token: 0x0400036E RID: 878
		[PublicAPI]
		public const string PluginName = "VoidLogicPlugin";

		// Token: 0x0400036F RID: 879
		[PublicAPI]
		public const string PluginVersion = "0.0.1";

		// Token: 0x04000371 RID: 881
		private GameObject _holder;
	}
}
