using SLZ.Bonelab.SaveData;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HubMap : MonoBehaviour
	{
		public GameControl_Hub gcHub;

		[Header("GameState Notices")]
		public string text_gameState_Welcome;

		public string text_gameState_Need3Unlocks;

		public string text_gameState_Need3CoreKeys;

		public string text_gameState_SpecialProjectsArea;

		public string text_gameState_NeedBodyLog;

		public string text_gameState_Need6CoreKeys;

		public string text_gameState_EmergencyExitAuthorization;

		[Header("Recommended Notices")]
		public string[] text_recommend_Module;

		[Header("Lore Notices")]
		public string[] LabLoreNotice;

		[Header("TextMeshPros")]
		public TextMeshPro tmp_notice;

		public TextMeshPro tmp_labNotice;

		public TextMeshPro tmp_recNotice;

		public TextMeshPro tmp_keyUnlockedCount;

		public TextMeshPro tmp_keyInsertedCount;

		private string _noticeToDisplay;

		public GameObject displayCanvas;

		public Transform sideFront;

		public Transform sideBack;

		public GameObject arrow_SPA;

		public GameObject arrow_Ascent;

		public GameObject craneAlert;

		public GameObject loreExtra;

		private int int_gameState;

		public int testState;

		private int coreKeysUnlocked;

		private int coreKeysInserted;

		private static PlayerProgression Progression => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void CHECK()
		{
		}

		private void CheckGameState()
		{
		}

		private void DetermineNotice(int gameStateSwitch = 0)
		{
		}

		public void UpdateDisplayText()
		{
		}

		public void PICKSIDE(bool front = true)
		{
		}

		public void OFF()
		{
		}
	}
}
