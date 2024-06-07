using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_CheatButtons : MonoBehaviour
	{
		public Control_Player controlPlayer;

		public TextMeshPro beatGameStatus;

		[FormerlySerializedAs("beatBigJimmyStatus")]
		public TextMeshPro beatBigAnomalyAStatus;

		public TextMeshPro beatBigAnomalyBStatus;

		public TextMeshPro beatStreetPuncherStatus;

		public TextMeshPro beatSprintBridgeStatus;

		public TextMeshPro beatMagmaGateStatus;

		public TextMeshPro beatMoonBaseStatus;

		public TextMeshPro beatMotorwayStatus;

		public TextMeshPro beatPillarStatus;

		public TextMeshPro beatAscentStatus;

		public TextMeshPro ascentProgressStatus;

		public TextMeshPro beatLongRunStatus;

		public TextMeshPro beatMineCartStatus;

		public TextMeshPro beatTownFightStatus;

		public TextMeshPro beatTutorialStatus;

		public TextMeshPro hubSpawnLocationStatus;

		public TextMeshPro isArenaKeyPlacedStatus;

		public TextMeshPro isArenaKeyUnlockedStatus;

		public TextMeshPro isBatteryAPlacedStatus;

		public TextMeshPro isBatteryBPlacedStatus;

		public TextMeshPro isExperimentalKeyPlacedStatus;

		public TextMeshPro isExperimentalKeyUnlockedStatus;

		public TextMeshPro isJimmyKeyPlacedStatus;

		public TextMeshPro isJimmyKeyUnlockedStatus;

		public TextMeshPro isModKeyPlacedStatus;

		public TextMeshPro isModKeyUnlockedStatus;

		public TextMeshPro isParkourKeyPlacedStatus;

		public TextMeshPro isParkourKeyUnlockedStatus;

		public TextMeshPro isSandboxKeyPlacedStatus;

		public TextMeshPro isSandboxKeyUnlockedStatus;

		public TextMeshPro isTacTrialKeyPlacedStatus;

		public TextMeshPro isTacTrialKeyUnlockedStatus;

		public TextMeshPro tutorialProgressStatus;

		public TextMeshPro LongRunProgressStatus;

		public TextMeshPro MenuResumeStatus;

		public TextMeshPro CurrentCampaignLevelStatus;

		public TextMeshPro hasBodyLogStatus;

		public TextMeshPro bodyLogEnabledStatus;

		public LevelCrateReference[] campaignCrates;

		public AvatarCrateReference[] avatarCrates;

		private static PlayerUnlocks u => null;

		private void Start()
		{
		}

		public void ResetProgress()
		{
		}

		public void SetFullProgress()
		{
		}

		public void BeatGame()
		{
		}

		public void BeatBigAnomalyA()
		{
		}

		public void BeatStreetPuncher()
		{
		}

		public void BeatSprintBridge()
		{
		}

		public void BeatMagmaGate()
		{
		}

		public void BeatMoonBase()
		{
		}

		public void BeatMotorway()
		{
		}

		public void BeatPillar()
		{
		}

		public void BeatBigAnomalyB()
		{
		}

		public void HasBodyLog()
		{
		}

		public void BodyLogEnabled()
		{
		}

		public void BeatAscent()
		{
		}

		public void AscentProgress()
		{
		}

		public void BeatLongRun()
		{
		}

		public void BeatMineDive()
		{
		}

		public void BeatOutro()
		{
		}

		public void BeatTutorial()
		{
		}

		public void HubSpawnLocation()
		{
		}

		public void IsArenaKeyPlaced()
		{
		}

		public void IsArenaKeyUnlocked()
		{
		}

		public void IsBatteryAPlaced()
		{
		}

		public void IsBatteryBPlaced()
		{
		}

		public void IsExperimentalKeyPlaced()
		{
		}

		public void IsExperimentalKeyUnlocked()
		{
		}

		public void IsJimmyKeyPlaced()
		{
		}

		public void IsJimmyKeyUnlocked()
		{
		}

		public void IsModKeyPlaced()
		{
		}

		public void IsModKeyUnlocked()
		{
		}

		public void IsSandboxKeyPlaced()
		{
		}

		public void IsSandboxKeyUnlocked()
		{
		}

		public void IsParkourKeyPlaced()
		{
		}

		public void IsParkourKeyUnlocked()
		{
		}

		public void IsTacTrialKeyPlaced()
		{
		}

		public void IsTacTrialKeyUnlocked()
		{
		}

		public void TutorialProgress()
		{
		}

		public void LongRunProgress()
		{
		}

		public void MenuResumeProgress()
		{
		}

		public void CycleCampaignLevel()
		{
		}
	}
}
