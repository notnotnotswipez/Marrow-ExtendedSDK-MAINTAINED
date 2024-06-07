using UnityEngine;

namespace SLZ.Bonelab
{
	public class TurretHeadAimer : MonoBehaviour
	{
		private bool _isAttachedToBody;

		private bool _hasRollBody;

		private Vector3 _lookDirection;

		public Transform testLookTransform;

		private Quaternion _yawStartRotation;

		public Rigidbody yawRigidbody;

		public ConfigurableJoint yawJoint;

		private Quaternion _pitchStartRotation;

		public Rigidbody pitchRigidbody;

		public ConfigurableJoint pitchJoint;

		private Quaternion _rollStartRotation;

		public Rigidbody rollRigidbody;

		public ConfigurableJoint rollJoint;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void LookAt(Vector3 worldPos)
		{
		}
	}
}
