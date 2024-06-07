using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A1 RID: 417
	[ConsoleCommand("__builtin", "help", "Show console help")]
	internal class HelpConsoleCommand : BaseConsoleCommand
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x0000510F File Offset: 0x0000330F
		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000083D4 File Offset: 0x000065D4
		private static UniTask Create(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
