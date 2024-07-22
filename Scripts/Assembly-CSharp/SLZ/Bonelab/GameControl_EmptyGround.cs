using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Video;

namespace SLZ.Bonelab
{
	public class GameControl_EmptyGround : BonelabInternalGameControl
	{
		[Header("ValvePuzzle")]
		public ConfigurableJoint jpz_Valve;

		private Quaternion startRot_Valve;

		public ConfigurableJoint jpz_DumbWaiter;

		public ConfigurableJoint jpz_PlatHigh;

		public ConfigurableJoint jpz_PlatLow;

		public bool can_pzl_Valve;

		public ConfigurableJoint jpz_Balloon;

		[Header("Video Puzzle")]
		public VideoPlayer vidPlayer;

		[Header("Cage Puzzle")]
		public bool solved_CagePuzzle;

		public DoorControl ctrl_CageDoor;

		private int int_LightsChecked;

		public int count_SolveToggles;

		[Header("Light Control")]
		public GameObject obj_Light_Title;

		public GameObject obj_Light_Center;

		public GameObject obj_Light_Complex;

		public GameObject obj_Light_Warning;

		public CrateSpawner obj_Flashlight;

		[Header("End Game")]
		public GameObject obj_FXParticleStars;

		public GameObject obj_BlockWall;

		[Header("Recursion")]
		public RigManager rm_player;

		public Transform recurPoint;

		private int count_teleports;

		public GameObject[] obj_firstRecursion;

		public CrateSpawner[] crates_firstRecursion;

		public GameObject[] obj_secondRecursion;

		public CrateSpawner[] crates_secondRecursion;

		public GameObject[] obj_thirdRecursion;

		public CrateSpawner[] crates_thirdRecursion;

		public override void Start()
		{
		}

		public override void Awake()
		{
		}

		public void VALVEPUZZLE()
		{
		}

		public void PlayMeTheMovie()
		{
		}

		public void StopTheMovie()
		{
		}

		public void LockTheLights(bool momentary = false)
		{
		}

		public void TargetTriggerVoltCheck()
		{
		}

		public void TOGGLE(bool OnOff)
		{
		}

		public void TurnOffGameLights()
		{
		}

		public void TurnOnStars()
		{
		}

		public void WonPuzzle()
		{
		}

		public void BALLISTICDOOR(bool open = false)
		{
		}

		public void SecondRound()
		{
		}

		public void TELEPORTPLAYER()
		{
		}

		private void SetRecurseObjects(bool objectsOn)
		{
		}
	}
}
