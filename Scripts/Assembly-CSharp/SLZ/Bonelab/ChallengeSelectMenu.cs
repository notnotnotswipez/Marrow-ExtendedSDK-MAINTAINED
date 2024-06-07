using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ChallengeSelectMenu : MonoBehaviour
	{
		[SerializeField]
		private bool updateEnemyCount;

		[SerializeField]
		private Arena_GameController arenaGameController;

		[SerializeField]
		private TMP_Text[] chalDescriptionTexts;

		[SerializeField]
		private TMP_Text difficultyDescText;

		[SerializeField]
		private TMP_Text activeChallengeText;

		[SerializeField]
		private TMP_Text enemyCountText;

		public UnityEvent OnChallengeSelected;

		public UnityEvent OnChallengeCanceled;

		public static Action<int> OnLoadoutSelected;

		public UnityEvent[] OnChallengeStarted;

		private int challengeID;

		private int loadID;

		private int minEnemyCount;

		private int maxEnemyCount;

		private int enemyCountValue;

		private string[] diffDescriptions;

		public void Start()
		{
		}

		public void SelectLoadout(int idx)
		{
		}

		public void OnLoadoutSelect()
		{
		}

		public void SelectChallenge(int idx)
		{
		}

		public void OnChallengeSelect()
		{
		}

		public void ChallengeStarted()
		{
		}

		public void CancelCurrentChallenge()
		{
		}

		public void UpdateDiffText()
		{
		}

		public void ToggleEnemyCount(bool up)
		{
		}
	}
}
