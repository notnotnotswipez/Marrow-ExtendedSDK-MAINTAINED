using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.Scripting;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000BB RID: 187
	[AttributeUsage(AttributeTargets.Class)]
	[RequireAttributeUsages]
	[MeansImplicitUse]
	public class MarrowPluginAttribute : Attribute
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000039F6 File Offset: 0x00001BF6
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x000039F9 File Offset: 0x00001BF9
		public string Namespace
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x000039FB File Offset: 0x00001BFB
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x000039FE File Offset: 0x00001BFE
		public string Name
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00003A00 File Offset: 0x00001C00
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00003A03 File Offset: 0x00001C03
		public string Version
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

		// Token: 0x06000696 RID: 1686 RVA: 0x00003A05 File Offset: 0x00001C05
		public MarrowPluginAttribute(string Namespace, string Name, string Version = "0.0.1-UNKNOWN")
		{
		}
	}
}
