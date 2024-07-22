using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class BonelabLevelsPanelView : PanelView
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopulateMenuAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BonelabLevelsPanelView _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[Header("Level Query")]
		[Tooltip("Include levels that are built in with the game")]
		public bool includeInternalLevels;

		[Tooltip("Include levels that are external (mods)")]
		public bool includeExternalLevels;

		public bool isRadialMenu;

		public bool isModMenu;

		public bool isSandboxMenu;

		public bool doKeyImages;

		public bool filterByTag;

		public List<string> levelTags;

		[Header("UI Components")]
		public GameObject[] items;

		public TextMeshProUGUI[] text;

		public Image[] keyImage;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshProUGUI pageText;

		public bool useSceneImage;

		public Image[] sceneImage;

		public Sprite[] m_SceneSprite;

		private LevelCrateReference loadScreen_Internal;

		public LevelCrateReference loadScreen_MODMAP;

		private int m_TotalScenes;

		private int m_NumberOfPages;

		private int m_CurrentPage;

		private LevelCrate[] m_LevelCrates;

		private List<LevelCrate> levelCrates;

		private LevelCrateReference[] keyLevelCrates;

		private Dictionary<LevelCrateReference, string> storyLevelBarcodeKeyPair;

		public List<Barcode> completedStoryLevelBarcodes;

		private LevelCrateReference kartRaceRef;

		[Tooltip("Optional: Forward level load event to DoorPortalController")]
		public DoorPortalController doorPortalController;

		public GameObject uiTrigger;

		public int doorPortalIndex;

		private static PlayerProgression p => null;

		private void Start()
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

		private void CalculateSceneList()
		{
		}

		private bool GetLevelCompletion(PlayerProgression progression, string _level)
		{
			return false;
		}

		[ContextMenu("Load First Level")]
		public void LoadFirstLevel()
		{
		}

		public void SelectItem(int idx)
		{
		}

		public override void Activate()
		{
		}

		[AsyncStateMachine(typeof(_003CPopulateMenuAsync_003Ed__42))]
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

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		public static void Startup()
		{
		}
	}
}
