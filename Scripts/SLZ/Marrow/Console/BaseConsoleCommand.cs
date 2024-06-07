using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A0 RID: 416
	public abstract class BaseConsoleCommand
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x00005101 File Offset: 0x00003301
		public IEnumerable<ValueTuple<BaseConsoleCommand.CommandStatus, string, object>> ParseNextArgument(string input)
		{
			return null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000083A4 File Offset: 0x000065A4
		protected virtual ValueTuple<BaseConsoleCommand.CommandStatus, string, object> ParseTokenAtIndex(List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<BaseConsoleCommand.CommandStatus, string, object>);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00005104 File Offset: 0x00003304
		public virtual IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000083BC File Offset: 0x000065BC
		private UniTask DefaultEmptyCommand(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x020002A6 RID: 678
		[Flags]
		public enum CommandStatus : uint
		{
			// Token: 0x04001097 RID: 4247
			Completable = 1U,
			// Token: 0x04001098 RID: 4248
			Continuable = 2U,
			// Token: 0x04001099 RID: 4249
			Disqualified = 4U,
			// Token: 0x0400109A RID: 4250
			SuggestionIsDefault = 268435456U,
			// Token: 0x0400109B RID: 4251
			SuggestionIsCurrentValue = 536870912U,
			// Token: 0x0400109C RID: 4252
			SuggestionIsTemplate = 1073741824U
		}
	}
}
