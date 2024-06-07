using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MenuProgressControl : MonoBehaviour
	{
		public bool continueMenu;

		public bool progressBars;

		public bool isOutroMenu;

		public GameObject newGameOption;

		public GameObject continueOption;

		public GameObject hubOption;

		public GameObject quickPlayOption;

		public TextMeshProUGUI currentLevel;

		public TextMeshProUGUI gameProgressNumber;

		public ProgressBar gameProgressBar;

		public ProgressBar tacTrialProgressBar;

		public ProgressBar arenaProgressBar;

		public ProgressBar sandboxProgressBar;

		public ProgressBar parkourProgressBar;

		public ProgressBar experimentalProgressBar;

		public ProgressBar unlocksProgressBar;

		public ProgressBar avatarsProgressBar;

		public ProgressBar easterEggsProgressBar;

		private int _progress;

		public LevelCrateReference hubCrate;

		public LevelCrateReference descentCrate;

		public LevelCrateReference longRunCrate;

		public LevelCrateReference mineDiveCrate;

		public LevelCrateReference bigAnomalyACrate;

		public LevelCrateReference streetPuncherCrate;

		public LevelCrateReference sprintBridgeCrate;

		public LevelCrateReference magmaGateCrate;

		public LevelCrateReference moonBaseCrate;

		public LevelCrateReference motorwayCrate;

		public LevelCrateReference pillarCrate;

		public LevelCrateReference bigAnomalyBCrate;

		public LevelCrateReference ascentCrate;

		public LevelCrateReference outroCrate;

		private static PlayerProgression Progression => null;

		public void SetupDisplays()
		{
		}

		private void SetupOutroMenu()
		{
		}

		private void SetUpContinueMenu()
		{
		}

		private void SetProgressBar()
		{
		}

		private float SolveCompletePercent()
		{
			return 0f;
		}

		private float CalcCampaignComplete()
		{
			return 0f;
		}

		private float CalcHubComplete()
		{
			return 0f;
		}

		private float CalcTacTrials()
		{
			return 0f;
		}

		private float CalcArenas()
		{
			return 0f;
		}

		private float CalcParkours()
		{
			return 0f;
		}

		private float CalcSandbox()
		{
			return 0f;
		}

		private float CalcExperimentals()
		{
			return 0f;
		}

		private float CalcUnlocks()
		{
			return 0f;
		}

		private float CalcAvatars()
		{
			return 0f;
		}

		private float CalcEasterEggs()
		{
			return 0f;
		}
	}
}
