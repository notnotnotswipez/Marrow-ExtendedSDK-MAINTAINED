using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class SimpleSFX : MonoBehaviour
	{
		public enum mixerGroups
		{
			hardInteraction = 0,
			softInteraction = 1,
			impact = 2,
			ambience = 3,
			diegeticMusic = 4,
			npcVocals = 5
		}

		public enum PlayBehavior
		{
			random = 0,
			order = 1,
			single = 2
		}

		public GameObject audioPlacementOverride;

		public AudioMixerGroup mixerGroup;

		public mixerGroups audioMixerGroup;

		public AudioClip[] simpleClip;

		[Tooltip("Is the sound 2d or 3d?")]
		[Range(0f, 1f)]
		public float spatialBlend;

		[Range(0.1f, 10f)]
		[Tooltip("Radius of min sphere")]
		public float sourceRadius;

		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		[Range(0f, 1f)]
		public float volume;

		public PlayBehavior playBehavior;

		private int _last_clip;

		private void Start()
		{
		}

		public void SIMPLEPLAY(int clipSpecific = 0)
		{
		}

		public void SAMPLEPLAY(AudioClip sampleOverride)
		{
		}

		public void RANDOMPLAY()
		{
		}

		private void AUDIOPLAY(int clipSpecific = 0, PlayBehavior behavior = PlayBehavior.order, AudioClip clipOverride = null, Transform location = null)
		{
		}
	}
}
