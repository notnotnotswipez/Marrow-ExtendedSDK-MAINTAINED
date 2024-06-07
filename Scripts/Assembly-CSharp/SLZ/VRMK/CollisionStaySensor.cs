using UnityEngine;

namespace SLZ.VRMK
{
	public class CollisionStaySensor : MonoBehaviour
	{
		public bool isGrounded;

		public bool ungroundedThisFrame;

		public Vector3 pressureNormal;

		public Vector3 pressurePoint;

		public float pressureKgs;

		public float skidMag;

		public Vector3 totalImpulse;

		public Vector3 skidVelocity;

		private Vector3 _totalImpulse;

		private Vector3 _pressureNormal;

		private Vector3 _pressurePoint;

		private Vector3 _lastRbPosition;

		private Vector3 _skidVelocity;

		private float _highestImpulse;

		private float _lastFixedTime;

		private Collider _groundedCollider;

		private int _count;

		private Rigidbody _rb;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private void ProcessCollision(Collision c, bool isEnter = false)
		{
		}

		public void UpdateSensor()
		{
		}
	}
}
