using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class FlightStabilizer : MonoBehaviour
	{
		private InteractableHost host;

		private Rigidbody rb;

		[Tooltip("The axis in which the object will orient itself to in flight")]
		public Vector3 primaryAxis;

		public Vector3 secondaryAxis;

		private bool isCollisionStay;

		private void Start()
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void FixedUpdate()
		{
		}

		public void ResetRB()
		{
		}
	}
}
