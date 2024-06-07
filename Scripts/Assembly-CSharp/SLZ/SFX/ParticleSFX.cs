using UnityEngine;

namespace SLZ.SFX
{
	public class ParticleSFX : MonoBehaviour
	{
		[SerializeField]
		private AudioClip[] impact;

		[SerializeField]
		private AudioClip[] impactSlow;

		[SerializeField]
		private float timeScaleClipSplit;

		[SerializeField]
		private float fastPitchHigh;

		[SerializeField]
		private float fastPitchLow;

		[SerializeField]
		private float slowPitchHigh;

		[SerializeField]
		private float slowPitchLow;

		public AudioSource source;

		private void Reset()
		{
		}

		public void SetSettings()
		{
		}

		public void BulletImpact()
		{
		}
	}
}
