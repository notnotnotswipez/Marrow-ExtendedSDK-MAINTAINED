using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TutorialGrip : MonoBehaviour
	{
		public Grip targetGrip;

		public InteractableHost host;

		public UnityEvent<string> OnGripAttachedToHand;

		public UnityEvent<string> OnGripDetachedFromHand;

		public UnityEvent<string> OnHostAttachedToHand;

		public UnityEvent<string> OnHostDetachedFromHand;

		private UnityEvent<string> OnHandEnter;

		private bool _rightHand;

		[Tooltip("True = tutorial on singular grip. False = any grip on object ")]
		public bool specificGrip;

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

		[Tooltip("How long should this display for? 0 = infinite time (use exitEnds or action to end)")]
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

		[HideInInspector]
		public Haptor haptor;

		private void Awake()
		{
		}

		public void TUTORIALSEND(Hand hand)
		{
		}

		public void TUTORIALOFF(Hand hand)
		{
		}

		private void OnAttachedToHandInternal(InteractableHost host, Hand hand)
		{
		}

		private void OnDetachedFromHandInternal(InteractableHost host, Hand hand)
		{
		}

		private void OnAttachedToHandInternal(Hand hand)
		{
		}

		private void OnDetachedFromHandInternal(Hand hand)
		{
		}
	}
}
