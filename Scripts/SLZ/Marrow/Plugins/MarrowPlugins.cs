using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Scripting;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000BD RID: 189
	[Preserve]
	public sealed class MarrowPlugins
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00003A15 File Offset: 0x00001C15
		[RuntimeInitializeOnLoadMethod]
		private static void EnsurePluginSystem()
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00003A17 File Offset: 0x00001C17
		public static MarrowPlugins Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00003A1A File Offset: 0x00001C1A
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00003A1D File Offset: 0x00001C1D
		public bool IsRunning
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00003A1F File Offset: 0x00001C1F
		private OrderedDictionary OrderedPluginWrappersByQN
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003A22 File Offset: 0x00001C22
		private Dictionary<Type, MarrowPluginWrapper> PluginWrappersByType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00003A25 File Offset: 0x00001C25
		private Dictionary<string, HashSet<string>> DependenciesByQN
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00003A28 File Offset: 0x00001C28
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00003A2B File Offset: 0x00001C2B
		private List<List<string>> CachedGroups
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00003A2D File Offset: 0x00001C2D
		private MarrowPlugins()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00003A35 File Offset: 0x00001C35
		protected void Finalize()
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00003A37 File Offset: 0x00001C37
		private void Application_quitting()
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00003A39 File Offset: 0x00001C39
		private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00003A3B File Offset: 0x00001C3B
		private void OnAfterAssembliesLoaded()
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00003A3D File Offset: 0x00001C3D
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00003A3F File Offset: 0x00001C3F
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00003A41 File Offset: 0x00001C41
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00003A43 File Offset: 0x00001C43
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00006F34 File Offset: 0x00005134
		internal UniTask TriggerOnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00006F4C File Offset: 0x0000514C
		internal UniTask TriggerOnMarrowPluginStart()
		{
			return default(UniTask);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00006F64 File Offset: 0x00005164
		internal UniTask TriggerOnMarrowPluginStop()
		{
			return default(UniTask);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00006F7C File Offset: 0x0000517C
		internal UniTask TriggerOnMarrowPluginEditorPaused()
		{
			return default(UniTask);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00006F94 File Offset: 0x00005194
		internal UniTask TriggerOnMarrowPluginEditorUnpaused()
		{
			return default(UniTask);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00006FAC File Offset: 0x000051AC
		internal UniTask TriggerOnMarrowPluginEditorEnteredEditMode()
		{
			return default(UniTask);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00006FC4 File Offset: 0x000051C4
		internal UniTask TriggerOnMarrowPluginEditorExitingEditMode()
		{
			return default(UniTask);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00006FDC File Offset: 0x000051DC
		internal UniTask TriggerOnMarrowPluginEditorEnteredPlayMode()
		{
			return default(UniTask);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00006FF4 File Offset: 0x000051F4
		internal UniTask TriggerOnMarrowPluginEditorExitingPlayMode()
		{
			return default(UniTask);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000700C File Offset: 0x0000520C
		internal UniTask TriggerOnMarrowPluginEditorBeforeAssemblyReload()
		{
			return default(UniTask);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00007024 File Offset: 0x00005224
		internal UniTask TriggerOnMarrowPluginEditorAfterAssemblyReload()
		{
			return default(UniTask);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000703C File Offset: 0x0000523C
		internal UniTask TriggerOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00007054 File Offset: 0x00005254
		internal UniTask TriggerOnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000706C File Offset: 0x0000526C
		internal UniTask TriggerOnBeforeLevelUnload()
		{
			return default(UniTask);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00007084 File Offset: 0x00005284
		internal UniTask TriggerOnAfterLevelUnload()
		{
			return default(UniTask);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000709C File Offset: 0x0000529C
		private UniTask _TriggerAsync<TPlugin>(bool forward, object context, Func<MarrowPluginWrapper, TPlugin, object, UniTask> callback) where TPlugin : IMarrowPlugin
		{
			return default(UniTask);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003A45 File Offset: 0x00001C45
		private static void _ThrowIfCycles(List<List<string>> groups)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00003A47 File Offset: 0x00001C47
		public bool TryGetPlugin<TPlugin>(out TPlugin plugin) where TPlugin : IMarrowPlugin
		{
			plugin = default(TPlugin);
			return false;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00003A51 File Offset: 0x00001C51
		private bool TryGetPluginWrapper<TPlugin>(out MarrowPluginWrapper marrowPluginWrapper) where TPlugin : IMarrowPlugin
		{
			marrowPluginWrapper = null;
			return false;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00003A57 File Offset: 0x00001C57
		private bool TryGetPluginWrapper(string qualifiedName, out MarrowPluginWrapper marrowPluginWrapper)
		{
			marrowPluginWrapper = null;
			return false;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00003A5D File Offset: 0x00001C5D
		internal void ScanForPluginsInAssembly(Assembly loadedAssembly, bool includingTests = false)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003A5F File Offset: 0x00001C5F
		private void AddPlugin(Type type)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00003A61 File Offset: 0x00001C61
		internal void AddPlugins(List<ValueTuple<Type, MarrowPluginAttribute>> plugins)
		{
		}

		// Token: 0x04000375 RID: 885
		private const bool DISABLE_LIFECYCLE_LOGGING = false;

		// Token: 0x04000376 RID: 886
		private const bool DISABLE_GRAPH_LOGGING = true;

		// Token: 0x04000377 RID: 887
		private const bool DISABLE_ASSEMBLY_LOGGING = true;

		// Token: 0x04000378 RID: 888
		private static MarrowPlugins _instance;
	}
}
