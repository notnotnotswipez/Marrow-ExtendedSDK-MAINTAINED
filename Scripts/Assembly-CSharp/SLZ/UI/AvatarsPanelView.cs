using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Warehouse;
using SLZ.VRMK;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SLZ.UI
{
	public class AvatarsPanelView : PanelView
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopulateMenuAsync_003Ed__91 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarsPanelView _003C_003E4__this;

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
		private sealed class _003CPromptCycle_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AvatarsPanelView _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CPromptCycle_003Ed__95(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__97 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarsPanelView _003C_003E4__this;

			public AvatarCrate avatarCrate;

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
		private struct _003CSwapReflectionAvatar_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Barcode barcode;

			public AvatarsPanelView _003C_003E4__this;

			private AvatarCrate _003Ccrate_003E5__2;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

		public GameObject canvas;

		[Header("Avatar Query")]
		[Tooltip("Include avatars that are built in with the game")]
		public bool includeInternalAvatars;

		[Tooltip("Include avatars that are external (mods)")]
		public bool includeExternalAvatars;

		public bool filterByTag;

		public bool favoritesMode;

		[Header("Avatar List UI Components")]
		public ButtonReferenceHolder[] tabButtons;

		[Header("Avatar List UI Components")]
		public ButtonReferenceHolder[] itemButtons;

		public GameObject forwardButton;

		public GameObject backButton;

		public ButtonReferenceHolder backGroupButton;

		public TextMeshPro groupText;

		public TextMeshProUGUI pageText;

		[Header("Favorites UI Components")]
		public ButtonReferenceHolder[] slotButtons;

		[Header("Stats UI Components")]
		public SpiderChart spiderChart;

		public ButtonReferenceHolder statsButton;

		public ButtonReferenceHolder detailsButton;

		[Header("Details UI Components")]
		public TextMeshPro selectedTitle;

		public TextMeshPro selectedPallet;

		public TextMeshPro selectedAuthor;

		public TextMeshPro selectedDescription;

		public TextMeshPro selectedTags;

		[Header("General UI Components")]
		public GameObject avatarPage;

		public GameObject statControl;

		public GameObject statsPage;

		public GameObject detailsPage;

		public GameObject favoritePage;

		public GameObject prompPage;

		public PullCordDevice bodyLog;

		public GameObject bodylogLock;

		public Transform bodyMallPromptTransform;

		public AudioClip bodyMallPromptClip;

		private ManagedAudioPlayer bodyMallPromptLoop;

		public AvatarCrateReference[] avatarFavorites;

		public bool useSceneImage;

		public Image[] sceneImage;

		public Sprite[] m_SceneSprite;

		private AvatarCrate avatarSelection;

		private Dictionary<string, List<AvatarCrate>> avatarGroupDictionary;

		private List<string> avatarGroupDictionaryIndex;

		private string selectedTag;

		private Dictionary<Barcode, AvatarCrate> avatarFlatDictionary;

		private List<AvatarCrate> avatarCrates;

		private int totalAvatars;

		private int numberOfPages;

		private int currentPage;

		private int cashedCurrentPage;

		private int cashedCurrentGroupPage;

		private int cashedCurrentAllPage;

		[HideInInspector]
		private RigManager rigManager;

		public bool enabledOnStart;

		[Header("Avatar Preview")]
		public bool isBodyMall;

		public Transform previewTransform;

		private Dictionary<Barcode, SLZ.VRMK.Avatar> cachedPreviews;

		private SLZ.VRMK.Avatar previewAvatar;

		[Header("Prompt Components")]
		public Renderer[] lights;

		public Material[] lightMats;

		public RectTransform[] arrow;

		private IEnumerator promptCycle;

		private int lastSelectedTab;

		private int selectedTab;

		private int slotSlection;

		private bool groupMode;

		private bool inGroup;

		private bool firstActivation;

		private List<AvatarCrateReference> defaultFavoriteAvatarsBarcodes;

		private List<AvatarCrateReference> defaultPeasantBarcodes;

		public UnityEvent pullCordInserted;

		public UnityEvent pullCordRemoved;

		private static PlayerUnlocks u => null;

		private void Awake()
		{
		}

		private void OnLevelLoad()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPalletAdded(Barcode palletBarcode)
		{
		}

		public void SwitchTab(int tab)
		{
		}

		private void ConfigureForAllAvatars()
		{
		}

		private void ConfigureForGroups()
		{
		}

		private void ConfigureForSubGroup()
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		public void StatsDetailButton(int idx)
		{
		}

		public void SelectItem(int idx)
		{
		}

		public void BackButton()
		{
		}

		public void ConfirmSelection()
		{
		}

		public void SelectSlot(int i)
		{
		}

		public void BodyLogSet()
		{
		}

		public void DisconnectBodyLog(bool inHand = false)
		{
		}

		private void CalculateSceneList()
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		[AsyncStateMachine(typeof(_003CPopulateMenuAsync_003Ed__91))]
		public UniTaskVoid PopulateMenuAsync()
		{
			return default(UniTaskVoid);
		}

		private void PopulateMenu()
		{
		}

		private void UpdatePageItems(int pageIdx, int maxItems)
		{
		}

		private void UpdatePageText(int idx, int total)
		{
		}

		[IteratorStateMachine(typeof(_003CPromptCycle_003Ed__95))]
		private IEnumerator PromptCycle()
		{
			return null;
		}

		private void LoadFavoriteAvatars()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__97))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSwapReflectionAvatar_003Ed__98))]
		private UniTask SwapReflectionAvatar(Barcode barcode)
		{
			return default(UniTask);
		}
	}
}
