using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	public abstract class SimpleConsoleCommand : BaseConsoleCommand
	{
		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<(string token, object parsed)> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public abstract UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter);

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
	}
}
