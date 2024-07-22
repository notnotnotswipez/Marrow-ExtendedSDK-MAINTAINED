using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "teleport", "Teleport to coordinates")]
	public class TeleportConsoleCommand : BaseConsoleCommand
	{
		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<(string token, object parsed)> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
	}
}
