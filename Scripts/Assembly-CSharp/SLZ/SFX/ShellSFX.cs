using SLZ.Data;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class ShellSFX : MonoBehaviour
	{
		public AudioVarianceData impact;

		public AudioVarianceData eject;

		public AudioVarianceData ejectSlowmo;

		private const float _velToVol = 0.28f;

		private bool _isHeavy;

		private bool _isPlastic;

		private ManagedAudioPlayer _mapImpact;

		private float _nextImpactTime;

		private float _lastImpactMag;

		private void OnCollisionEnter(Collision c)
		{
		}

		public void ImpactSound(Collision c)
		{
		}

		public void ShellEject()
		{
		}
	}
}
