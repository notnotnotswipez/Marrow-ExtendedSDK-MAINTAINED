using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Plunger : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody baseRB;

		[SerializeField]
		private float attachVelMin;

		[SerializeField]
		private float breakForce;

		[SerializeField]
		private UnityEvent popEvent;

		private bool stuck;

		private void OnTriggerEnter(Collider col)
		{
		}

		public void Break()
		{
		}
	}
}
