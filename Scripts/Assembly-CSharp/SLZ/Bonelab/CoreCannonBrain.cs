using SLZ.Bonelab.Obsolete;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CoreCannonBrain : MonoBehaviour
	{
		[SerializeField]
		private Powerable_Joint _firingPin;

		[SerializeField]
		private AudioClip _fireClip;

		[SerializeField]
		private Rigidbody _spinnerRb;

		[SerializeField]
		private Transform _pressureGauge;

		[SerializeField]
		private AmbientSFX _steamSfx;

		[SerializeField]
		private Powerable_ParticleManager steamManager;

		private float _charge;

		private float _gaugeAng;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void FireCannon()
		{
		}

		private void UpdateGauge()
		{
		}
	}
}
