using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class GenericTurretSFX : MonoBehaviour
	{
		public AudioClip[] idleClips;

		public AudioClip[] alertClips;

		public AudioClip[] patrolClips;

		public AudioClip[] unPackClips;

		public AudioClip[] packClips;

		public AudioClip[] speakClips;

		public AudioClip[] deathClips;

		public AudioClip[] impactClips;

		public AudioClip[] alarmClips;

		public AudioClip[] jumpClips;

		private float volume;

		private float minDist;

		private ManagedAudioPlayer _mapLoop;

		public void StopAll()
		{
		}

		public void PlayIdleLoop()
		{
		}

		public void StopIdleLoop()
		{
		}

		public void PlayAlarm()
		{
		}

		public void PlayJump()
		{
		}

		public void PlayAlert()
		{
		}

		public void PlayPatrol()
		{
		}

		public void PlayUnpack()
		{
		}

		public void PlayPack()
		{
		}

		public void PlaySpeak()
		{
		}

		public void PlayDeath()
		{
		}

		public void PlayImpact()
		{
		}
	}
}
