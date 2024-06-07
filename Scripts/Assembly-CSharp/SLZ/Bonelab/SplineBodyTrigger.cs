using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineBodyTrigger : MonoBehaviour
	{
		public float targetVelocity;

		public float positionDamper;

		public float maximumForce;

		public SplineBody splineBody;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
