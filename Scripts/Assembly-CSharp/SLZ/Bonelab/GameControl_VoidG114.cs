using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_VoidG114 : MonoBehaviour
	{
		[SerializeField]
		private RigManager rm;

		public BodyVitals ctrl_bodyVitals;

		public LevelCrateReference level_quickPlay;

		public LevelCrateReference descentLevelCrate;

		public LevelCrateReference hubLevelCrate;

		public LevelCrateReference longRunLevelCrate;

		public LevelCrateReference mineDiveLevelCrate;

		public LevelCrateReference jimmyLevelCrate;

		public LevelCrateReference ascentLevelCrate;

		public LevelCrateReference townFightLevelCrate;

		public LevelCrateReference voidG114LevelCrate;

		private LevelCrateReference _loadcrate;

		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		private static PlayerProgression Progression => null;

		private static PlayerProgression p => null;

		private void Start()
		{
		}

		public void BUTTON_QUICKPLAY()
		{
		}

		public void BUTTON_PLAYNEWGAME()
		{
		}

		public void BUTTON_PLAYHUB()
		{
		}

		public void BUTTON_PLAYCONTINUE()
		{
		}

		private void LoadLevel()
		{
		}

		private LevelCrateReference ContinueDestination()
		{
			return null;
		}
	}
}
