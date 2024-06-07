using UnityEngine;

namespace SLZ.Bonelab
{
	public class TankTread : MonoBehaviour
	{
		public float resetHalfThreshold;

		[Range(-15f, 15f)]
		public float velocity;

		public Rigidbody tankTread;

		public Rigidbody topFrontRoll;

		public Rigidbody botFrontRoll;

		public Rigidbody topBackRoll;

		public Rigidbody botBackRoll;

		public Rigidbody frontSlope;

		public Rigidbody tread1;

		public Rigidbody backSlope;

		public ConfigurableJoint tread1Drive;

		public ConfigurableJoint frontSlopeDrive;

		public ConfigurableJoint rearSlopeDrive;

		public ConfigurableJoint topFrontDrive;

		public ConfigurableJoint botFrontDrive;

		public ConfigurableJoint topBackDrive;

		public ConfigurableJoint botBackDrive;

		private void Start()
		{
		}

		public void OnFixedUpdate()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
