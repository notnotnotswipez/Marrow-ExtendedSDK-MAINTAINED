using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("repo", "delete", "Delete a mod repo")]
	[ConsoleCommand("repo", "list", "List mod repos")]
	[ConsoleCommand("repo", "del", "Delete a mod repo")]
	[ConsoleCommand("repo", "add", "Add a mod repo")]
	public class RepoConsoleCommand : BaseConsoleCommand
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CListRepos_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public IAsyncWriter<object> writer;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<List<(int lineNumber, Uri url)>>.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Uri uri;

			internal bool _003CAddRepos_003Eb__0(string line)
			{
				return false;
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddRepos_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Uri uri;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			private string _003CrepositoriesList_003E5__2;

			private StreamWriter _003Csw_003E5__3;

			private TaskAwaiter<string[]> _003C_003Eu__1;

			private object _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private TaskAwaiter _003C_003Eu__2;

			private ValueTaskAwaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDeleteRepos_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public int lineNo;

			private string _003CrepositoriesList_003E5__2;

			private TaskAwaiter<string[]> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<(string token, object parsed)> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListRepos_003Ed__2))]
		private static Task ListRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddRepos_003Ed__3))]
		private static Task AddRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken, Uri uri)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteRepos_003Ed__4))]
		private static Task DeleteRepos(IAsyncWriter<object> writer, CancellationToken cancellationToken, int lineNo)
		{
			return null;
		}
	}
}
