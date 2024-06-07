using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineBody : SplineEntity
	{
		public ConfigurableJointMotion angularXMotion;

		public float angularXLimit;

		public float angularXLimitBounciness;

		public float angularXLimitContactDistance;

		[Header("References")]
		public Rigidbody rb;

		public float targetVelocity;

		public float positionDamper;

		public float maximumForce;

		[HideInInspector]
		public ConfigurableJoint[] contactJoints;

		[HideInInspector]
		public bool isSpeedChanged;

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		public void SetTargetVelocity(float velocity)
		{
		}

		public void SetPositionDamper(float damper)
		{
		}

		public void SetMaximumForce(float force)
		{
		}
	}
}
