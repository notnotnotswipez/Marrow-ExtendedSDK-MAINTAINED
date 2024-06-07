using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B2 RID: 434
	[MarrowPlugin("SLZ.Marrow.Zones", "Audio 2d", null)]
	public class Audio2dPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00005211 File Offset: 0x00003411
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00005214 File Offset: 0x00003414
		public static Audio2dManager Audio2dManager
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
