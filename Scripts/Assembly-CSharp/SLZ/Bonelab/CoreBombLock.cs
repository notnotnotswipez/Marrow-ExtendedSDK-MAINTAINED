using UnityEngine;

namespace SLZ.Bonelab
{
	public class CoreBombLock : MonoBehaviour
	{
		public Rigidbody rb;

		private bool _hasCore;

		private CoreBomb _activeCore;

		private ConfigurableJoint _joint;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}
	}
}
