using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace SLZ.Bonelab
{
	[MarrowPlugin("com.stresslevelzero.plugins", "BoneSocket", "0.0.1")]
	public class WebSocketPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		private static readonly Dictionary<string, string> mimeTypes;

		private HttpServer _server;

		private DebugConsoleWebSocketBehavior _debugConsole;

		private SynchronizationContext _mainThreadSyncContext;

		private int _port;

		private Dictionary<string, Action<HttpRequestEventArgs>> commands;

		public int Port
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public event PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPlugin_002EOnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginRunCallbacks_002EOnMarrowPluginStart()
		{
			return default(UniTask);
		}

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginRunCallbacks_002EOnMarrowPluginStop()
		{
			return default(UniTask);
		}

		public void StartServer()
		{
		}

		public void StopServer()
		{
		}

		private void HTTPServer_OnGetOrPost(object sender, HttpRequestEventArgs e)
		{
		}

		private bool TryRunCommand(HttpRequestEventArgs e)
		{
			return false;
		}

		private bool TrySetContentTypeFromFileExtension(HttpListenerResponse res, string extension)
		{
			return false;
		}

		private void SetUTF8EncodingIfText(HttpListenerResponse res, string contentType)
		{
		}

		private void Command_HelloWorld(HttpRequestEventArgs e)
		{
		}

		private void Command_Chunks(HttpRequestEventArgs e)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = null)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
		}
	}
}
