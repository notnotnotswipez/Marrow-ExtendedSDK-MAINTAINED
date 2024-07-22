using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIRig : MonoBehaviour
	{
		public PopUpMenuView popUpMenu;

		public UI_HUD uiHud;

		public Transform[] scaleOffset;

		[HideInInspector]
		public float cur_avatarArmScaleMult;

		public Control_Player controlPlayer;

		public Feedback_Audio feedbackAudio;

		public Feedback_Tactile feedbackTactile;

		private float standardArmLength;

		private float uiScale;

		public UIControllerInput leftUIController;

		public UIControllerInput rightUIController;

		public static UIRig Instance
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

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void EarlyUpdate()
		{
		}

		public void UI_AVATARSCALE(float armLength)
		{
		}
	}
}
