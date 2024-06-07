using UnityEngine;

namespace SLZ.Combat
{
	public class AimEnhancer : MonoBehaviour
	{
		public Transform eyeTran;

		public Transform rearSightTran;

		[Range(0f, 1f)]
		public float enhanceIntensity;

		[Range(1f, 60f)]
		public float angleThreshold;

		[Header("Rifle")]
		public Transform lfShoulder;

		public Transform rtShoulder;

		private float _angleThresholdCos;

		private float _dotNormDivBy;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void HandGunAlign()
		{
		}

		private Vector3 EyePoint(Vector3 sightPos, out float enter)
		{
			enter = default(float);
			return default(Vector3);
		}
	}
}
