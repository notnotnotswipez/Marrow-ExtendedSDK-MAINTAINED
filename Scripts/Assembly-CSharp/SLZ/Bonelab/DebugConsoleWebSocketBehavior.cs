using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Console;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace SLZ.Bonelab
{
	internal class DebugConsoleWebSocketBehavior : WebSocketBehavior
	{
		private static HashSet<DebugConsoleWebSocketBehavior> instances;

		private ConsoleCommandWrapperConverter _commandConverter;

		private static ConsoleCommandPlugin Plugin => null;

		protected override void OnOpen()
		{
		}

		protected override void OnClose(CloseEventArgs e)
		{
		}

		protected override void OnMessage(MessageEventArgs e)
		{
		}

		private IUniTaskAsyncEnumerable<object> RunCommandAsync(string command)
		{
			return null;
		}

		private bool TryMatchCommands(string input, out List<ConsoleCommandWrapper> matchedCommands)
		{
			matchedCommands = null;
			return false;
		}

		public static void SendString(string @string)
		{
		}

		public static void SendBytes(byte[] bytes)
		{
		}
	}
}
