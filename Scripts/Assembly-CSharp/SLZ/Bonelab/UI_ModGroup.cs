using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Forklift;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;
using SLZ.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class UI_ModGroup : MonoBehaviour
	{
		[Serializable]
		public enum PageType
		{
			Installed = 0,
			Approved = 1,
			External = 2,
			Repos = 3,
			Mods = 4
		}

		[Serializable]
		public struct UI_ModPager
		{
			public GameObject forwardButton;

			public GameObject backButton;

			public TextMeshProUGUI txt_pageNumber;

			public PageType currentPageType;

			public int currentPage;
		}

		[Serializable]
		public struct UI_ModSettings
		{
			public TextMeshProUGUI txt_developerMode;

			public TextMeshProUGUI txt_developerModePort;

			public TextMeshProUGUI txt_modioDiagnostics;

			public TextMeshProUGUI txt_generalDiagnostics;
		}

		[Serializable]
		public class UI_ModViewModel
		{
			public string text;

			public Pallet pallet;

			public ModRepository modRepository;

			public ModListing modListing;

			public ModTarget modTarget;

			public string targetName;

			public bool useItemImage;

			public string itemImageUrl;

			public bool useVersion;

			public bool useProgressBar;

			public FileDownloadProgress progress;

			public bool isInstalled;

			public CancellationTokenSource StopThisDownloadCTS;
		}

		[Serializable]
		public class UI_ModCell
		{
			[StructLayout(3)]
			[CompilerGenerated]
			private struct _003CUpdateFromViewModel_003Ed__7 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				public UI_ModCell _003C_003E4__this;

				public UI_ModViewModel viewModel;

				public UI_ModGroup context;

				private UniTask<UnityEngine.Networking.UnityWebRequest>.Awaiter _003C_003Eu__1;

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

			public ButtonReferenceHolder button;

			public ProgressBar progressBar;

			[HideInInspector]
			public string itemImageUrl;

			public UniTask<Sprite> itemImageTask;

			public CancellationTokenSource itemImageCTS;

			[HideInInspector]
			public bool selected;

			[HideInInspector]
			public int viewModelIndex;

			[AsyncStateMachine(typeof(_003CUpdateFromViewModel_003Ed__7))]
			public UniTask UpdateFromViewModel(UI_ModViewModel viewModel, UI_ModGroup context)
			{
				return default(UniTask);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckLogIn_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public UI_ModGroup _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoad_Repositories_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UI_ModGroup _003C_003E4__this;

			private UniTask<UnityEngine.Networking.UnityWebRequest>.Awaiter _003C_003Eu__1;

			private UniTask<ModRepository[]>.Awaiter _003C_003Eu__2;

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
		private sealed class _003C_003Ec__DisplayClass73_0
		{
			public UI_ModGroup _003C_003E4__this;

			public List<Pallet> pallets;

			internal void _003CPopulateMenu_003Eb__0()
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopulateMenu_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UI_ModGroup _003C_003E4__this;

			private _003C_003Ec__DisplayClass73_0 _003C_003E8__1;

			private UniTask.Awaiter _003C_003Eu__1;

			private ModRepository[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
		private struct _003CLoadingIcon_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationTokenSource cts;

			public UI_ModGroup _003C_003E4__this;

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
		private struct _003CUpdateCells_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int newPageIndex;

			public UI_ModGroup _003C_003E4__this;

			private int _003CcellIndex_003E5__2;

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

		[Space(10f)]
		[Header("Global")]
		public TextMeshProUGUI txt_pageTitle;

		public TextMeshProUGUI txt_sdkVersion;

		public string[] string_pageTitle;

		public Sprite defaultImage;

		[Space(10f)]
		[Header("Group")]
		public GameObject Group_Mods;

		public GameObject Group_Main;

		[Space(10f)]
		[Header("SubMenus")]
		public GameObject Menu_ModsMain;

		public GameObject Menu_Downloads;

		[Space(10f)]
		[Header("Popups")]
		public GameObject Popup_ModWarning;

		public GameObject Popup_AvatarWarning;

		[Space(10f)]
		[Header("Pages")]
		public GameObject Page_Installed;

		public GameObject Page_Approved;

		public GameObject Page_Modio;

		public GameObject Page_Illegal;

		public GameObject Page_Settings;

		public GameObject Page_Repos;

		public GameObject Page_ModLevels;

		private int currentPage;

		[Space(10f)]
		[Header("Paged Pallets")]
		public GameObject Page_Pallets;

		public UI_ModSettings uiModSettings;

		public UI_ModPager pager;

		public UI_ModCell[] PalletButtons;

		public GameObject loadingIcon;

		[Header("Mod.io")]
		[Space(10f)]
		public ButtonReferenceHolder modioButton;

		public TextMeshPro modioReadout;

		public TextMeshPro modioCodeTimer;

		public TextMeshPro modioInstructions;

		[Space(10f)]
		[Header("Warning")]
		public GameObject obj_DevModeWarning;

		public GameObject obj_AvatarWarning;

		public GameObject obj_ModWarning;

		public ModIOManager _modIOManager;

		private ModRepository _officialRepository;

		private ModRepository[] _otherRepositories;

		private List<UI_ModViewModel> _viewModels;

		private Dictionary<string, Sprite> _spriteCache;

		private CancellationTokenSource _stopAllDownloadsCTS;

		private ModSubscriptionDownloader _modSubscriptionDownloader;

		private bool logInProcessActive;

		private CancellationTokenSource killLoginCTS;

		private bool firstEnable;

		private CancellationTokenSource ParseRepoCancelToken;

		private CancellationTokenSource LoadingIconCancelToken;

		public UnityEvent returnEvent;


		private readonly Regex NonAlphanumeric;

		private int _pageCount => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckLogIn_003Ed__50))]
		private UniTaskVoid CheckLogIn()
		{
			return default(UniTaskVoid);
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PortChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		[AsyncStateMachine(typeof(_003CLoad_Repositories_003Ed__56))]
		private UniTask Load_Repositories()
		{
			return default(UniTask);
		}

		public void MODS_BUTTON()
		{
		}

		public void RETURN_BUTTON()
		{
		}

		public void GOTO_PAGE(int page)
		{
		}

		public void BUTTON_MODSETTINGS(int buttonNumber = 0)
		{
		}

		private void UpdateGeneralDiagnostics()
		{
		}

		private void DevModeWarning()
		{
		}

		public void MODIO_BUTTON()
		{
		}

		private void LogInTask()
		{
		}

		public void BUTTON_INSTALLSUBSCRIPTION(bool yesInstall = false)
		{
		}

		private void DownloadComplete()
		{
		}

		public void BUTTON_SELECT(int idx)
		{
		}

		private void OnCellClicked(UI_ModCell button)
		{
		}

		public void BUTTON_OPENPAGE(int pageTypeInt = 0)
		{
		}

		public void BUTTON_BACK(int pages = 1)
		{
		}

		public void BUTTON_FORWARD(int pages = 1)
		{
		}

		public void BUTTON_DELETE(bool deleteAll = true)
		{
		}

		[AsyncStateMachine(typeof(_003CPopulateMenu_003Ed__73))]
		private UniTask PopulateMenu()
		{
			return default(UniTask);
		}

		private void ParseRepositories(ModRepository modRepo, List<Pallet> pallets)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadingIcon_003Ed__75))]
		private UniTaskVoid LoadingIcon(CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		private void UpdatePagerUI(int newPageIndex)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateCells_003Ed__77))]
		private UniTask UpdateCells(int newPageIndex)
		{
			return default(UniTask);
		}

		private int ModSorterLettersAndNumbersOnly(UI_ModViewModel x, UI_ModViewModel y)
		{
			return 0;
		}

		public void WARNINGS()
		{
		}
	}
}
