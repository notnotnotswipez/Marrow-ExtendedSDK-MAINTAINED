using Cysharp.Threading.Tasks;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__hidden", "undead", null)]
	[ConsoleCommand("__hidden", "idclip", null)]
	[ConsoleCommand("__hidden", "impulse", null)]
	[ConsoleCommand("__hidden", "kaching", null)]
	[ConsoleCommand("__hidden", "ubermensch", null)]
	[ConsoleCommand("__hidden", "igbigbucks", null)]
	[ConsoleCommand("__hidden", "idspispopd", null)]
	[ConsoleCommand("__hidden", "upupdowndownleftrightleftright", null)]
	[ConsoleCommand("__hidden", "rosebud", null)]
	[ConsoleCommand("__hidden", "idkfa", null)]
	[ConsoleCommand("__hidden", "iddqd", null)]
	[ConsoleCommand("__hidden", "quicken", null)]
	[ConsoleCommand("__hidden", "thereisnospoon", null)]
	[ConsoleCommand("__hidden", "sv_cheats", null)]
	[ConsoleCommand("__hidden", "momoney", null)]
	[ConsoleCommand("__hidden", "nyuknyuk", null)]
	[ConsoleCommand("__hidden", "nofate", null)]
	[ConsoleCommand("__hidden", "fourteen", null)]
	[ConsoleCommand("__hidden", "abacabb", null)]
	[ConsoleCommand("__hidden", "howdoyouturnthison", null)]
	[ConsoleCommand("__hidden", "catchme", null)]
	[ConsoleCommand("__hidden", "smoothstep", null)]
	[ConsoleCommand("__hidden", "inevitable", null)]
	[ConsoleCommand("__hidden", "ithinkthereforei", null)]
	[ConsoleCommand("__hidden", "motherlode", null)]
	[ConsoleCommand("__hidden", "casper", null)]
	public class CheaterConsoleCommands : BaseConsoleCommand
	{
		private int doomCheatCount;

		private int cheatCount;

		private CheaterConsoleCommands()
		{
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
	}
}
