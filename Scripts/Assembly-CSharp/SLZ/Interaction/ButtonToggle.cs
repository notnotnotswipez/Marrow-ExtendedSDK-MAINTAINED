using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class ButtonToggle : MonoBehaviour
	{
		public ConfigurableJoint joint;

		public Transform endTransform;

		public AudioClip[] pressClips;

		public AudioClip[] depressClips;

		[Tooltip("Colliders that the button shaft collider will ignore")]
		public Collider[] ignoreColliders;

		public Collider buttonShaftCollider;

		[Header("Events")]
		public UnityEvent onPress;

		public UnityEvent onDepress;

		public UnityEvent onHold;

		public UnityEvent onPressOneShot;

		private Vector3 _endPosition;

		private Vector3 _startPosition;

		private Rigidbody _rb;

		private float _jointSqrLimit;

		private float _jointLimit;

		private float _jointHalfLimit;

		private float _limitOffset;

		private float _limitSqr;

		private float _padding;

		private bool _isPressed;

		private bool _hasBeenPressed;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void CancelOneShot()
		{
		}
	}
}
