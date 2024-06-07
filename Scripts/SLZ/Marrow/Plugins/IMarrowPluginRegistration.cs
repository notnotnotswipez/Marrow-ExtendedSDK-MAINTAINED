using System;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000BA RID: 186
	public interface IMarrowPluginRegistration
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600068D RID: 1677
		Type PluginType { get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600068E RID: 1678
		MarrowPluginAttribute MarrowPluginAttribute { get; }

		// Token: 0x0600068F RID: 1679
		void AddDependency(string qualifiedName);
	}
}
