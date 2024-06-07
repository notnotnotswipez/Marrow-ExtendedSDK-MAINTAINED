using UnityEngine;

namespace SLZ.MLAgents
{
	public class Bullet : MonoBehaviour
	{
		public float baseDamage;

		private Rigidbody _rb;

		[HideInInspector]
		public TurretAgent turret;

		private bool killingBlow;

		private void Start()
		{
		}

		private void Deactivate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
