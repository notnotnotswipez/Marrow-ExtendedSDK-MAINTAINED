using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using SLZ.ModIO;
using SLZ.ModIO.ApiModels;

public class ModSubscriptionDownloader
{
	private class ModDownloadProgressInfo
	{
		public ModObject modObject;

		public ModListing modListing;

		public ModIOModTarget modioModTarget;

		public FileDownloadProgress progress;

		public bool update;

		public ModDownloadProgressInfo(ModObject modObject, ModListing modListing, ModIOModTarget modioModTarget, bool update)
		{
		}

		public float GetPercent()
		{
			return 0f;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDownloadAllSubscribedMods_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public ModSubscriptionDownloader _003C_003E4__this;

		private Result<List<ModObject>> _003Cresult_003E5__2;

		private List<ModObject> _003CupdateSubscriptions_003E5__3;

		private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

		private UniTask<Result<List<ModObject>>>.Awaiter _003C_003Eu__2;

		private UniTask.Awaiter _003C_003Eu__3;

		private List<ModObject>.Enumerator _003C_003E7__wrap3;

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
	private struct _003CPrintDownloadCount_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public ModSubscriptionDownloader _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003COutputDebugText_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public ModSubscriptionDownloader _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ModSubscriptionDownloader _003C_003E4__this;

		public ModIOModTarget modTarget;

		internal void _003CDownloadMod_003Eb__0(FileDownloadProgress downloadProgress)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDownloadMod_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ModSubscriptionDownloader _003C_003E4__this;

		public ModIOModTarget modTarget;

		public CancellationToken cancellationToken;

		public ModObject modObject;

		public ModListing modListing;

		public bool updatePallet;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		private bool _003Csuccess_003E5__2;

		private Stopwatch _003CdownloadStopWatch_003E5__3;

		private Exception _003CfailedException_003E5__4;

		private Pallet _003CinstalledPallet_003E5__5;

		private object _003C_003E7__wrap5;

		private int _003C_003E7__wrap6;

		private UniTask<Pallet>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CTryGetAllModIOSubscriptions_BE_CAREFUL_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Result<List<ModObject>>> _003C_003Et__builder;

		public ModSubscriptionDownloader _003C_003E4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<Result<GetModsObject>> _003C_003Eu__1;

		private UniTask<Result<GetModsObject>[]>.Awaiter _003C_003Eu__2;

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
	private struct _003CWhenAllWithProgress_003Ed__40<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<T[]> _003C_003Et__builder;

		public IReadOnlyCollection<UniTask<T>> tasks;

		public CancellationToken cancellationToken;

		public IProgress<float> progress;

		private List<(AsyncLazy<T> AsyncLazy, int OriginalIndex)> _003CwrappedTasks_003E5__2;

		private int _003CtaskCount_003E5__3;

		private bool[] _003CtasksStatus_003E5__4;

		private T[] _003Cresults_003E5__5;

		private UniTask<T[]>.Awaiter _003C_003Eu__1;

		private UniTask<(bool hasResultLeft, (int winArgumentIndex, T result) result)>.Awaiter _003C_003Eu__2;

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

	private bool _isDownloading;

	private readonly ModIOManager _modIOManager;

	public int maxConcurrentDownloads;

	private string downloadedMods;

	private List<ModListing> downloadedModsList;

	private int downloadModsCount;

	private List<ModListing> updatedModsList;

	private string downloadedFailedMods;

	private List<ModListing> downloadedFailedModsList;

	private int downloadFailedModsCount;

	private int currentDownloadCount;

	private int totalDownloads;

	private string modTargetPlatformName;

	private string modIOPlatformName;

	private Stopwatch totalStopwatch;

	private CancellationTokenSource downloadCancelToken;

	private Dictionary<long, ModDownloadProgressInfo> modDownloadProgressInfos;

	private Dictionary<long, long> invalidModFiles;

	private Dictionary<long, PalletManifest> installedModIOPallets;

	private Action<string> outputTextAction;

	public Action downloadComplete;

	private string outputText;

	private List<PalletCollisionException> palletCollisions;

	public bool IsDownloading
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public ModSubscriptionDownloader(ModIOManager modIOManager, Action<string> outputTextLog)
	{
	}

	private void ApplicationQuitting()
	{
	}

	public void StopDownloading(bool doNotDispose = false)
	{
	}

	[AsyncStateMachine(typeof(_003CDownloadAllSubscribedMods_003Ed__30))]
	public UniTaskVoid DownloadAllSubscribedMods()
	{
		return default(UniTaskVoid);
	}

	public static string ModObjectToString(ModObject modObject)
	{
		return null;
	}

	private void DeleteUnsubscribedMods(List<ModObject> subscriptions)
	{
	}

	private bool TryGetModObjectPlatform(ModObject modObject, out ModPlatformsObject modObjectPlatform)
	{
		modObjectPlatform = default(ModPlatformsObject);
		return false;
	}

	private List<ModObject> FilterSubscriptions(List<ModObject> subscriptions, out List<ModObject> addSubs, out List<ModObject> updateSubs)
	{
		addSubs = null;
		updateSubs = null;
		return null;
	}

	[AsyncStateMachine(typeof(_003CPrintDownloadCount_003Ed__35))]
	public UniTaskVoid PrintDownloadCount()
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003COutputDebugText_003Ed__36))]
	public UniTaskVoid OutputDebugText()
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CDownloadMod_003Ed__37))]
	private UniTask DownloadMod(ModListing modListing, ModIOModTarget modTarget, ModObject modObject, bool updatePallet, CancellationToken cancellationToken)
	{
		return default(UniTask);
	}

	private string BytesToReadable(long bytes)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CTryGetAllModIOSubscriptions_BE_CAREFUL_003Ed__39))]
	private UniTask<Result<List<ModObject>>> TryGetAllModIOSubscriptions_BE_CAREFUL(CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(UniTask<Result<List<ModObject>>>);
	}

	[AsyncStateMachine(typeof(_003CWhenAllWithProgress_003Ed__40<>))]
	public static UniTask<T[]> WhenAllWithProgress<T>(IReadOnlyCollection<UniTask<T>> tasks, IProgress<float> progress, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(UniTask<T[]>);
	}
}
