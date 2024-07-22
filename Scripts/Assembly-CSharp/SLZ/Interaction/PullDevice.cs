using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class PullDevice : MonoBehaviour
	{
		[Header("Audio")]
		public AudioClip[] pullClips;

		public AudioClip[] releaseClips;

		[Header("References")]
		public Grip grip;

		public ConfigurableJoint joint;

		public Rigidbody rb;

		public float distance;

		public UnityEvent OnHandlePull;

		public UnityEvent OnHandleReturn;

		private Vector3 _startPosition;

		private bool _isPulled;

		private float _distanceSqr;

		private float _halfDistanceSqr;

		private float _defaultDriveMaxForce;

		private void Awake()
		{
		}

		private void OnGripAttached(Hand hand)
		{
		}

		private void OnGripAttachedUpdate(Hand hand)
		{
		}

		private void OnGripDetached(Hand hnad)
		{
		}
	}
}
