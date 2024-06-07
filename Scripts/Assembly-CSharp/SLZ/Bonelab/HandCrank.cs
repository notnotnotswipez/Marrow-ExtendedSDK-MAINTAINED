using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HandCrank : MonoBehaviour
	{
		public Rigidbody rotaterBody;

		public GameObject rotaterBar;

		public GameObject staticBar;

		public float prevSignedAngle;

		public float signedAngle;

		public float deltaSignedAngle;

		public ConfigurableJoint moverJoint;

		public Grip leftGrip;

		public Grip rightGrip;

		public float jointIncrementVal;

		public float maxPosition;

		public void FixedUpdate()
		{
		}

		private void MoveJoint(bool forward)
		{
		}
	}
}
