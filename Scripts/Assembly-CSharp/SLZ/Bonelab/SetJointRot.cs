using UnityEngine;

namespace SLZ.Bonelab
{
	public class SetJointRot : MonoBehaviour
	{
		public ConfigurableJoint joint;

		public Quaternion initRot;

		public Quaternion openQuat;

		public Quaternion closedQuat;

		private JointDrive angDrive;

		private float openSpringForce;

		private float closedSpringForce;

		private float maxForce;

		public void Start()
		{
		}

		[ContextMenu("SetOpen")]
		public void SetOpen()
		{
		}

		[ContextMenu("SetClosed")]
		public void SetClosed()
		{
		}
	}
}
