using System;

namespace SLZ.Marrow.Plugins.Tests
{
	// Token: 0x020000C2 RID: 194
	[AttributeUsage(AttributeTargets.Class)]
	public class MarrowTestMarrowPluginAttribute : MarrowPluginAttribute
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x00003AD6 File Offset: 0x00001CD6
		public MarrowTestMarrowPluginAttribute(string Namespace, string Name, string Version = "0.0.1-UNKNOWN")
			: base(null, null, null)
		{
		}
	}
}
