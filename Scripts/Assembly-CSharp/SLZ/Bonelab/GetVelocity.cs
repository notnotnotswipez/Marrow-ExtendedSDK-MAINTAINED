using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Rigidbody))]
	public class GetVelocity : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rigidbody;

		private void Reset()
		{
		}

		public void SetVelocity(Vector3 Velocity)
		{
		}

		private void OnDisable()
		{
		}
	}
}
