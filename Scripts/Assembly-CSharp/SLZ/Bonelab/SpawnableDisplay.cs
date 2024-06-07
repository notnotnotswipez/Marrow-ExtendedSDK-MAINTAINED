using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class SpawnableDisplay : MonoBehaviour
	{
		[SerializeField]
		private GameObject parentObj;

		[SerializeField]
		private bool includeAllTags;

		[SerializeField]
		private bool includeModCrates;

		[SerializeField]
		private bool sortTags;

		public GameObject[] tagItems;

		public TMP_Text[] tagText;

		public Image[] tagItemBackgrounds;

		public GameObject[] items;

		public TMP_Text[] itemTexts;

		public Image[] itemBackgrounds;

		public GameObject[] tabItems;

		public Image[] tabImageBackgrounds;

		public GameObject[] loadoutButtons;

		public Image[] loadoutButtonBackgrounds;

		public TMP_Text[] loadoutItemTexts;

		public GameObject[] loadSpawnButtons;

		public Image[] loadSpawnBackgrounds;

		public List<string> _usedTags;

		public List<string> _chosenTags;

		private HashSet<string> tagHash;

		public string _selectedTag;

		private string _selectedItemTag;

		private int _selectedItemIndex;

		private int _numberOfPages;

		private int _numberOfTagPages;

		private int _currentPage;

		private int _currentTagPage;

		public GameObject downButton;

		public GameObject upButton;

		public TMP_Text pageText;

		public GameObject tagDownButton;

		public GameObject tagUpButton;

		public TMP_Text tagPageText;

		public TMP_Text spawnableText;

		public TMP_Text spawnAllowText;

		public GameObject spawnSelectPage;

		public GameObject loadoutSelectPage;

		public Crate selectedObject;

		public SpawnableCrateReference selectedCrateRef;

		[SerializeField]
		private List<SpawnablePack> loadoutList;

		private int currLoadIndex;

		public static Action<SpawnableCrateReference> OnSpawnableSelected;

		public static Action OnDespawnAll;

		public static Action<Transform> OnTeleportDisplay;

		public Dictionary<string, List<Crate>> SpawnablesQuickMap
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void Start()
		{
		}

		private void UpdateSpawnableCount(Vector2 count)
		{
		}

		private void UpdateMessage(bool enable)
		{
		}

		public void SetupDisplay()
		{
		}

		private void PopulateDisplay()
		{
		}

		private void HighlightProperSpawnItem()
		{
		}

		public void SelectTab(int idx)
		{
		}

		public void SelectLoadout(int idx)
		{
		}

		public void UpdateLoadoutItems(int idx)
		{
		}

		public void SelectLoadoutItem(int idx)
		{
		}

		public void SelectItem(int idx)
		{
		}

		public void SelectCategory(int idx)
		{
		}

		public void SpawnSelectedLoadout()
		{
		}

		public void SpawnSCR(SpawnableCrateReference scr)
		{
		}

		public void SpawnSelectedCrate(Crate crate, string tag)
		{
		}

		public void DespawnAll()
		{
		}

		[ContextMenu("SpawnAllWeapons")]
		public void SpawnAllWeapons()
		{
		}

		public void SpawnAllFromTag(string tag)
		{
		}

		private void UpdatePageText(int idx, int total)
		{
		}

		private void UpdatePageItems(int pageIdx, int maxItems)
		{
		}

		private void UpdateTagPageText(int idx, int total)
		{
		}

		private void UpdateTagPageItems(int tagPageIdx, int maxTagItems)
		{
		}

		public void NextTagPage()
		{
		}

		public void PrevTagPage()
		{
		}

		public void NextPage()
		{
		}

		public void PrevPage()
		{
		}

		public void UpdateSpawnPoint(GameObject spawnObj)
		{
		}

		public void TeleportDisplay(GameObject teleObj)
		{
		}
	}
}
