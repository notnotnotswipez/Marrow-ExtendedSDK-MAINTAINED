using UnityEngine;

namespace SLZ.Bonelab
{
	public class TreadmillMovement : MonoBehaviour
	{
		public GameObject belt;

		public Transform endPoint;

		public Transform startPoint;

		public float speed_belt;

		private void Update()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
