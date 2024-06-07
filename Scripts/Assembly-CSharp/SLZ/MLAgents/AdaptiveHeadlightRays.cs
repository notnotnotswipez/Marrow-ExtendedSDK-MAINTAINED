using UnityEngine;

namespace SLZ.MLAgents
{
	public class AdaptiveHeadlightRays : MonoBehaviour
	{
		[Tooltip("Vehicle the script is attached to")]
		public BaseVehicle vehicle;

		[Tooltip("Used for turning script usage on and off")]
		public bool stabalize_eyes;

		[Tooltip("Response multiplier curve for deriving the y rotation based on the cars steering wheel rotation")]
		public AnimationCurve steer_curve;

		[Tooltip("Response multiplier curve for deriving the x rotation based on the cars current speed")]
		public AnimationCurve speed_curve;

		[Tooltip("Point of reference for what orignal vanilla x rotation was")]
		private float eyes_init_x;

		[Tooltip("Point of reference for what orignal vanilla y rotation was")]
		private float eyes_init_y;

		[Tooltip("Additional rotation value to add ontop of solve")]
		public float max_additional_y;

		[Tooltip("Additional rotation value to add ontop of solve")]
		public float max_additional_x;

		public float hillRotRatio;

		[Tooltip("Rotation reference for counter rotating on slopes")]
		public float curCarXRot;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void StabalizeRays()
		{
		}

		private float WrapAngle(float angle)
		{
			return 0f;
		}
	}
}
