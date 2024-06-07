using UnityEngine;

namespace SLZ.MLAgents
{
	public class LPPV_Follow : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float rotationDamping;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float height;

		[SerializeField]
		private float damping;

		[SerializeField]
		private bool smoothRotation;

		[SerializeField]
		private bool followBehind;

		private void FixedUpdate()
		{
		}
	}
}
