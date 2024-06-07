using UnityEngine;

namespace SLZ.MLAgents
{
	public class PID_Controller_Joint : MonoBehaviour
	{
		public Rigidbody rb;

		public ConfigurableJoint joint;

		public Transform followTran;

		public float pGain;

		public float iGain;

		public float dGain;

		private Vector3 _lastError;

		private Vector3 _errorSum;

		public bool lockout;

		private void FixedUpdate()
		{
		}
	}
}
