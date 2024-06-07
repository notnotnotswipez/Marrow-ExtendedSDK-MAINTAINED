using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class StemControl : MonoBehaviour
	{
		[HideInInspector]
		private enum Transition
		{
			HOLD = 0,
			INTRO = 1,
			LAYERING = 2,
			OUTRO = 3
		}

		[Header("Audio Clips")]
		public AudioClip[] stems_hold;

		public AudioClip[] stems_Intro;

		public AudioClip[] stems_layer_A;

		public AudioClip[] stems_layer_B;

		public AudioClip[] stems_layer_C;

		public AudioClip[] stems_layer_D;

		public AudioClip[] stems_Outro;

		[HideInInspector]
		public bool playing_hold;

		[HideInInspector]
		public bool playing_intro;

		[HideInInspector]
		public bool playing_layer_A;

		[HideInInspector]
		public bool playing_layer_B;

		[HideInInspector]
		public bool playing_layer_C;

		[HideInInspector]
		public bool playing_layer_D;

		[HideInInspector]
		public bool playing_outro;

		public int cur_hold;

		public int cur_intro;

		public int cur_layer_A;

		public int cur_layer_B;

		public int cur_layer_C;

		public int cur_layer_D;

		public int cur_outro;

		private AudioPlayer _ap;

		public AudioPlayer audioPlayer => null;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
