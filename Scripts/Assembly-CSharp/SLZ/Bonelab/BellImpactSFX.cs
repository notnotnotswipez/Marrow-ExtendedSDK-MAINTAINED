using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class BellImpactSFX : MonoBehaviour
	{
		public UnityEvent onRingBell;

		public AudioClip bellImpactClip;

		private float _nextImpactTime;

		private float _mass;

		private float _minVelSquared;

		public float velocityClipSplit;

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void TriggerSFX(Collision collision)
		{
		}

		public void OnAttackSFX()
		{
		}
	}
}
