using UnityEngine;

namespace SLZ.Bonelab
{
	public class HoverEngine : MonoBehaviour
	{
		public LayerMask RaycastMask;

		public float MaxHeight;

		public float GroundForce;

		public float Damping;

		public float Exponent;

		public float MaxAngleDrift;

		public Rigidbody Rigidbody;

		private float m_LastPower;

		private RaycastHit m_GroundHit;

		public bool HasGround => false;

		public float Power => 0f;

		public RaycastHit Ground => default(RaycastHit);

		private void FixedUpdate()
		{
		}
	}
}
