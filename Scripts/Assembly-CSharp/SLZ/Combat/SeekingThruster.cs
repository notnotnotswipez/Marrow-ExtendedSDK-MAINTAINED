using UnityEngine;

namespace SLZ.Combat
{
	public class SeekingThruster : MonoBehaviour
	{
		private bool _isLaunching;

		private Rigidbody _rb;

		public Transform thrustPoint;

		private Vector3 initialDirection;

		private Vector3 targetPosition;

		public float acceleration;

		private float _warmupTime;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
