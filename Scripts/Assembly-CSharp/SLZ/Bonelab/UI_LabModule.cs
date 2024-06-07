using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class UI_LabModule : MonoBehaviour
	{
		[Header("Assign in Prefab")]
		public TextMeshProUGUI txt_title;

		public TextMeshProUGUI txt_description;

		public bool startActive;

		public GameObject menu;

		public BonelabLevelsPanelView lpv;

		public Image icon;

		[Header("Assign in Editor")]
		public Sprite sprite_Icon;

		public string title;

		public string description;

		public List<string> levelTags;

		private void OnEnable()
		{
		}
	}
}
