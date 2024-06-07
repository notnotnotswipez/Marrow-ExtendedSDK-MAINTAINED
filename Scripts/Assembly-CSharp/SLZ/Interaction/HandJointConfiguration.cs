using UnityEngine;

namespace SLZ.Interaction
{
	public class HandJointConfiguration
	{
		public Rigidbody connectedBody;

		public Vector3 axis;

		public Vector3 anchor;

		public Vector3 connectedAnchor;

		public bool autoConfigureConnectedAnchor;

		public float breakForce;

		public float breakTorque;

		public bool enableCollision;

		public bool enablePreprocessing;

		public Vector3 currentForce;

		public Vector3 currentTorque;

		public float massScale;

		public float connectedMassScale;

		public float projectionAngle;

		public float projectionDistance;

		public JointProjectionMode projectionMode;

		public JointDrive slerpDrive;

		public JointDrive angularYZDrive;

		public JointDrive angularXDrive;

		public RotationDriveMode rotationDriveMode;

		public Vector3 targetAngularVelocity;

		public Quaternion targetRotation;

		public JointDrive zDrive;

		public JointDrive yDrive;

		public JointDrive xDrive;

		public Vector3 targetVelocity;

		public Vector3 targetPosition;

		public SoftJointLimit angularZLimit;

		public SoftJointLimit angularYLimit;

		public SoftJointLimit highAngularXLimit;

		public SoftJointLimit lowAngularXLimit;

		public SoftJointLimit linearLimit;

		public SoftJointLimitSpring angularYZLimitSpring;

		public SoftJointLimitSpring angularXLimitSpring;

		public SoftJointLimitSpring linearLimitSpring;

		public ConfigurableJointMotion angularZMotion;

		public ConfigurableJointMotion angularYMotion;

		public ConfigurableJointMotion angularXMotion;

		public ConfigurableJointMotion zMotion;

		public ConfigurableJointMotion yMotion;

		public ConfigurableJointMotion xMotion;

		public Vector3 secondaryAxis;

		public bool configuredInWorldSpace;

		public bool swapBodies;

		public ConfigurableJoint joint;

		private Vector3 _lastVelocity;

		private Vector3 _lastAngularVelocity;

		public void ApplyConfiguration(ConfigurableJoint joint)
		{
		}

		public void LockConfiguration(ConfigurableJoint joint)
		{
		}

		public void FreeConfiguration(ConfigurableJoint joint)
		{
		}

		public void ApplyConfiguration(Quaternion localRotation, ConfigurableJoint joint)
		{
		}

		public void CopyConfiguration(ConfigurableJoint joint)
		{
		}

		public void SleepDrives(ConfigurableJoint joint, Rigidbody rb)
		{
		}

		public void WakeupDrives(ConfigurableJoint joint, Rigidbody rb)
		{
		}
	}
}
