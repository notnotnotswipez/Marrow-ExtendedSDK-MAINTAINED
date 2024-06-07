using System.Collections.Generic;
using SLZ.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class ArenaMenuController : MonoBehaviour
	{
		[SerializeField]
		private Arena_GameController arenaGameController;

		[SerializeField]
		private GeoManager geoManager;

		[SerializeField]
		private GameObject[] pageObjs;

		[SerializeField]
		private GameObject mainPageObj;

		[SerializeField]
		private PreferencesPanelView panelView;

		[SerializeField]
		private RoundProfileGroup customProfileGroup;

		public EnemyProfile[] allowedEnemyProfiles;

		public HashSet<EnemyProfile> enemyHash;

		public Button[] enemyProfileButtons;

		public TMP_Text[] buttonTexts;

		[SerializeField]
		private Image[] buttonImages;

		[SerializeField]
		private TMP_Text trialDescriptionText;

		[SerializeField]
		private TMP_Text challengeDescriptionText;

		[SerializeField]
		private RoundProfileGroup projectedSurvChallenge;

		[Header("Events")]
		public UnityEvent OnChallengeSelected;

		[Header("Custom Challenge Limits")]
		public int waveCount;

		public int minEnemyCount;

		public int maxEnemyCount;

		public int enemyCount;

		public int minFriendlyCount;

		public int maxFriendlyCount;

		public int friendlyCount;

		public int minConcurrent;

		public int maxConcurrent;

		public int concurrentEnemyCount;

		public int lightBulletCount;

		public int medBulletCount;

		public int heavyBulletCount;

		public int enemiesPerWave;

		[SerializeField]
		private Color selectedColor;

		[SerializeField]
		private Color deselectedColor;

		[SerializeField]
		[Header("Texts")]
		[Space(10f)]
		private TMP_Text concurrentEnemyText;

		[SerializeField]
		private TMP_Text enemyCountText;

		[SerializeField]
		private TMP_Text friendlyCountText;

		[SerializeField]
		private TMP_Text waveEnemyCountText;

		[SerializeField]
		private TMP_Text geoText;

		[SerializeField]
		private TMP_Text activeChallengeText;

		[SerializeField]
		private TMP_Text activeChallengeDescriptionText;

		[SerializeField]
		private TMP_Text activeChallengeDiffText;

		[SerializeField]
		private TMP_Text difficultyText;

		[SerializeField]
		private GameObject cancelActiveButton;

		private string survivalDifficultyDescription;

		[SerializeField]
		private TMP_Text roundAchievedText;

		[SerializeField]
		private TMP_Text timeAchievedText;

		[SerializeField]
		private Button resumeButton;

		[SerializeField]
		private Image easyCheckImage;

		[SerializeField]
		private Image medCheckImage;

		[SerializeField]
		private Image hardCheckImage;

		private int loadedRoundReached;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnGeoMoveUpComplete()
		{
		}

		public void ARENA_ResetMenuOnModeEnd()
		{
		}

		public void SurvivalSelect()
		{
		}

		public void StartMatch()
		{
		}

		public void TrialSelect(int sel)
		{
		}

		public void ChallengeSelect(int sel)
		{
		}

		public void AssignEnemyProfileButtons()
		{
		}

		public void ToggleCancelButton(bool enable)
		{
		}

		public void ToggleDifficulty(int diff)
		{
		}

		public void SetupActivePage()
		{
		}

		public void ToggleEnemyProfile(int profileIndex)
		{
		}

		public void ToggleMaxConcurrent(bool increase)
		{
		}

		public void ToggleEnemyCount(bool increase)
		{
		}

		public void ToggleFriendlyCount(bool increase)
		{
		}

		[ContextMenu("ToggleCurrentGeo")]
		public void ToggleGeo()
		{
		}

		public void CancelChallenge()
		{
		}

		public void CreateCustomGameAndStart()
		{
		}

		public void OnLoadSaveFile(Arena_DataPlayer playerData)
		{
		}

		[ContextMenu("TestSurvivalProjection")]
		public void TestSurvivalProjection()
		{
		}

		public void ResumeSurvivalFromRound()
		{
		}

		public void SetChallengeCompletion()
		{
		}

		[ContextMenu("GetButtonTexts")]
		public void GetButtonTexts()
		{
		}
	}
}
