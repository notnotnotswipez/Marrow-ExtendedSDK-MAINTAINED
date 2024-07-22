using System;
using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[Obsolete("Uses obsolete zone components")]
	public class TutorialTrigger : MonoBehaviour
	{
		private UnityEvent<string> OnHandEnter;

		private bool _rightHand;

		[Tooltip("string to display on left Controller")]
		public string textToTutorial_left;

		[Tooltip("string to display on right Controller")]
		public string textToTutorial_right;

		[Tooltip("highlight button on controller art")]
		public TutorialRig.InputHighlight inputHighlight_left;

		[Tooltip("highlight button on controller art")]
		public TutorialRig.InputHighlight inputHighlight_right;

		[Tooltip("display arrows on joystick or xy")]
		public TutorialRig.LocationHighlight highlightLoc_left;

		[Tooltip("display arrows on joystick or xy")]
		public TutorialRig.LocationHighlight highlightLoc_right;

		[Tooltip("which controllers should be displayed")]
		public TutorialRig.SpecificHand handChoice;

		[Tooltip("how many times button highlights should flash per second")]
		public int flashRate;

		[Tooltip("How long should this display for? -1 = infinite time (use exitEnds or action to end)")]
		public float holdTime;

		[Tooltip("Does exiting collider end the tutorial?")]
		public bool exitEnds;

		[Tooltip("How many times should the player see this tutorial? -1 = infinite")]
		public int tutorialRepeatCount;

		[Tooltip("display sprite image on left controller tooltip")]
		public Sprite sprite_Image_left;

		[Tooltip("display sprite image on right controller tooltip")]
		public Sprite sprite_Image_right;

		[Tooltip("Play this audioclip associated with this tutorial")]
		public AudioClip clip_tutorial;

		private Hand defaultHand;

		private void OnTriggerEnter(Collider other)
		{
		}

		public void TUTORIALSEND()
		{
		}

		public void TUTORIALOFF()
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void TUTORIALCOMPLETE()
		{
		}
	}
}
