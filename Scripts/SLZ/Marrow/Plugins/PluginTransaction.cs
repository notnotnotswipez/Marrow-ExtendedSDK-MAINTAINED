using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000BF RID: 191
	internal sealed class PluginTransaction : IDisposable
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x00003A7C File Offset: 0x00001C7C
		[MethodImpl(256)]
		public static PluginTransaction OpenTransaction()
		{
			return null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00003A7F File Offset: 0x00001C7F
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00003A89 File Offset: 0x00001C89
		protected void Finalize()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00003A8B File Offset: 0x00001C8B
		void System.IDisposable.Dispose()
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00003A8D File Offset: 0x00001C8D
		public void AddPlugin(ValueTuple<Type, MarrowPluginAttribute> type)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00003A8F File Offset: 0x00001C8F
		public bool ContainsPluginType(Type pluginType)
		{
			return false;
		}

		// Token: 0x04000381 RID: 897
		internal static ThreadLocal<PluginTransaction> _tl_CurrentTransaction;

		// Token: 0x04000382 RID: 898
		private bool _disposedValue;

		// Token: 0x04000383 RID: 899
		private List<ValueTuple<Type, MarrowPluginAttribute>> PendingPlugins;
	}
}
