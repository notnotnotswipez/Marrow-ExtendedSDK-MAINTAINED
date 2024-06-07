using UnityEngine;

namespace SLZ.MLAgents
{
	public class Car : MonoBehaviour
	{
		[Tooltip("The speed the car moves")]
		public float driveSpeed;

		public Vector3 targetDestination;

		private float randomizedSpeed;

		private float nextActionTime;

		private void FixedUpdate()
		{
		}

		private void Drive()
		{
		}
	}
}
