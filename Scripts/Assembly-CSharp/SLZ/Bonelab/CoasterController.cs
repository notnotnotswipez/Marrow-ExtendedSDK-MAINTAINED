using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CoasterController : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private float thrust;

		[SerializeField]
		private float throttle;

		[SerializeField]
		private Grip leverGrip;

		[SerializeField]
		private bool passengerOnBoard;

		private void Awake()
		{
		}

		public void PlayerEnterExit(bool enter)
		{
		}

		private void FixedUpdate()
		{
		}

		public void LEVER(float voltage)
		{
		}
	}
}
