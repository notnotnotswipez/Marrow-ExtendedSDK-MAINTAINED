using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class HandgunVirtualController : VirtualControllerOverride
	{
		private const float enhanceIntensity = 0.6f;

		private const float angleThreshold = 15f;

		public Transform shoulderTransform;

		private float _angleThresholdCos;

		private float _dotNormDivBy;

		protected void Reset()
		{
		}

		protected override void Awake()
		{
		}

		protected Vector3 EyePoint(SimpleTransform eyeTran, SimpleTransform rearSightTran, Vector3 sightPos, out float enter)
		{
			enter = default(float);
			return default(Vector3);
		}

		protected Quaternion AimEnhancer(Quaternion rotation, SimpleTransform eyeTran, SimpleTransform rearSightTran, float enhanceIntensity, out float enhanceT)
		{
			enhanceT = default(float);
			return default(Quaternion);
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload p)
		{
		}
	}
}
