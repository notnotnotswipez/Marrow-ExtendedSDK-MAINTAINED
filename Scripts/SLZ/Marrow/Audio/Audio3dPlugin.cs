using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B5 RID: 437
	[MarrowPlugin("SLZ.Marrow.Zones", "Audio 3d", null)]
	public class Audio3dPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000052E5 File Offset: 0x000034E5
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x000052E8 File Offset: 0x000034E8
		public static Audio3dManager Audio3dManager
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
	}
}
