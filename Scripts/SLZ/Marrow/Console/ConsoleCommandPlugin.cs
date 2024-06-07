using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A4 RID: 420
	[MarrowPlugin("SLZ.Marrow.Plugins", "CommandConsole", "0.0.1")]
	public class ConsoleCommandPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00005133 File Offset: 0x00003333
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00005136 File Offset: 0x00003336
		public TokenParseContext TokenParseContext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00005138 File Offset: 0x00003338
		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000083EC File Offset: 0x000065EC
		public UniTask OnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00008404 File Offset: 0x00006604
		public UniTask OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000841C File Offset: 0x0000661C
		public UniTask OnMarrowPluginStop()
		{
			return default(UniTask);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0000513A File Offset: 0x0000333A
		private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0000513C File Offset: 0x0000333C
		private void ScanForCommandsInAssembly(Assembly loadedAssembly)
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0000513E File Offset: 0x0000333E
		public void Describe(object obj, TokenParseContext tpc, Action<ObjectDescription> action)
		{
		}

		// Token: 0x04000ABD RID: 2749
		internal Dictionary<Type, ConsoleCommandWrapper> Commands;

		// Token: 0x04000ABE RID: 2750
		private HashSet<IObjectDescriber> Describers;

		// Token: 0x04000ABF RID: 2751
		private HashSet<Type> KnownDescribers;

		// Token: 0x04000AC0 RID: 2752
		private Dictionary<Type, IObjectDescriber> DescriberCache;
	}
}
