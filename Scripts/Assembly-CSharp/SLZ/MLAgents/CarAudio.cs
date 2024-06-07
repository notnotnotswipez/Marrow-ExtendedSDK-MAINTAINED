using UnityEngine;

namespace SLZ.MLAgents
{
	[RequireComponent(typeof(BaseVehicleUtils))]
	public class CarAudio : MonoBehaviour
	{
		public enum EngineAudioOptions
		{
			Simple = 0,
			FourChannel = 1
		}

		public EngineAudioOptions engineSoundStyle;

		public AudioClip lowAccelClip;

		public AudioClip lowDecelClip;

		public AudioClip highAccelClip;

		public AudioClip highDecelClip;

		public float pitchMultiplier;

		public float lowPitchMin;

		public float lowPitchMax;

		public float highPitchMultiplier;

		public float maxRolloffDistance;

		public float dopplerLevel;

		public bool useDoppler;

		private AudioSource m_LowAccel;

		private AudioSource m_LowDecel;

		private AudioSource m_HighAccel;

		private AudioSource m_HighDecel;

		private bool m_StartedSound;

		public BaseVehicleUtils baseVehicleUtils;

		private void StartSound()
		{
		}

		private void StopSound()
		{
		}

		private void Update()
		{
		}

		private AudioSource SetUpEngineAudioSource(AudioClip clip, bool is3D = true)
		{
			return null;
		}

		private static float ULerp(float from, float to, float value)
		{
			return 0f;
		}
	}
}
