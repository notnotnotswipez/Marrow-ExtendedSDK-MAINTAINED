using System;
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

namespace SLZ.Bonelab
{
	public class LevelsPanelView : PanelView
	{
		[Serializable]
		public struct LevelKeyPair
		{
			public LevelCrateReference levelCrate;

			public string key;
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopulateMenuAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public LevelsPanelView _003C_003E4__this;

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

		[Header("Level Query")]
		[Tooltip("Include levels that are built in with the game")]
		public bool includeInternalLevels;

		[Tooltip("Include levels that are external (mods)")]
		public bool includeExternalLevels;

		[Header("UI Components")]
		public GameObject[] items;

		public TextMeshProUGUI[] text;

		public GameObject forwardButton;

		public GameObject backButton;

		public TextMeshProUGUI pageText;

		public LevelCrateReference modLoadScreen;

		private int _totalScenes;

		private int _numberOfPages;

		private int _currentPage;

		private List<LevelCrate> _levelCrates;

		[SerializeField]
		public LevelKeyPair[] storyLevelBarcodeKeyPair;

		private Dictionary<Barcode, string> _storyLevelBarcodeKeyPair;

		private readonly List<Barcode> _completedStoryLevelBarcodes;

		private void Awake()
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

		private bool GetLevelCompletion(PlayerProgression progression, string level)
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

		[AsyncStateMachine(typeof(_003CPopulateMenuAsync_003Ed__25))]
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
	}
}
