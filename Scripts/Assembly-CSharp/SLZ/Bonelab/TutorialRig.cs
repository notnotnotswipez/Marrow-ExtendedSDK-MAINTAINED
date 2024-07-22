using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TutorialRig : MonoBehaviour
	{
		public enum InputHighlight
		{
			none = 0,
			trigger = 1,
			button_A = 2,
			button_B = 3,
			grip = 4,
			joystick = 5,
			touchpad = 6,
			gripTrig = 7
		}

		public enum LocationHighlight
		{
			none_l = 0,
			left_l = 1,
			right_l = 2,
			up_l = 3,
			down_l = 4,
			upDown_l = 5,
			leftRight_l = 6,
			all_l = 7,
			none_r = 8,
			left_r = 9,
			right_r = 10,
			up_r = 11,
			down_r = 12,
			upDown_r = 13,
			leftRight_r = 14,
			all_r = 15
		}

		public enum SpecificHand
		{
			none = 0,
			both = 1,
			either = 2,
			left = 3,
			right = 4
		}

		public ControllerTutorialArt[] leftControllerArt;

		public ControllerTutorialArt[] rightControllerArt;

		private int cur_l_art;

		private int cur_r_art;

		public Transform[] arrowArt_L;

		public Transform[] arrowArt_R;

		public ControllerToolTip toolTip_left;

		public ControllerToolTip toolTip_right;

		private string textToSend_L;

		private string textToSend_R;

		private bool send_L;

		private bool send_R;

		private Sprite _spriteToSend_L;

		private Sprite _spriteToSend_R;

		private AudioClip _clip_tutorial;

		[HideInInspector]
		public bool tutorialActive;

		[HideInInspector]
		public TutorialTrigger cur_activeTutorial;

		private bool _activeControllers;

		private float standardHeight;

		private float tutorialScale;

		public GameObject controllerTitles;

		public HeadTitles headTitles;

		public static TutorialRig Instance
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

		private void Awake()
		{
		}

		private void OnLevelLoad()
		{
		}

		private void OnLevelUnload()
		{
		}

		private void Start()
		{
		}

		private bool GetSettings()
		{
			return false;
		}

		public void GrippedLeft(HandReciever handReciever)
		{
		}

		public void UngrippedLeft(HandReciever handReciever)
		{
		}

		public void GrippedRight(HandReciever handReciever)
		{
		}

		public void UngrippedRight(HandReciever handReciever)
		{
		}

		private void SetActiveController()
		{
		}

		public void CUSTOMTUTORIAL(InputHighlight highlightPhase_left = InputHighlight.none, InputHighlight highlightPhase_right = InputHighlight.none, LocationHighlight highlightLoc_left = LocationHighlight.none_l, LocationHighlight highlightLoc_right = LocationHighlight.none_r, SpecificHand handChoice = SpecificHand.none, bool isRightHand = true, string tutorialText_left = "", string tutorialText_right = "", int flashRate = 1, float holdTime = 4f, Sprite spriteImage_left = null, Sprite spriteImage_right = null, AudioClip clip_tutorial = null, TutorialTrigger specificTutorial = null)
		{
		}

		public void DEACTIVETUTORIAL()
		{
		}

		private void SendControllerArt(bool activation = true)
		{
		}

		private void SendToolTip(bool toolTipOn = false)
		{
		}

		private void TimedDisable()
		{
		}

		private void TutorialShutOff(bool isOn = false)
		{
		}

		public void TUTORIALSCALE(float avatarEyeHeight)
		{
		}

		private void SendTutorialComplete()
		{
		}
	}
}
