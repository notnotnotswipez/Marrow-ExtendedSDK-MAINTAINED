using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SlideMover : MonoBehaviour
	{
		[Header("Use this component only if animation isn't used for slide")]
		public Vector3 localSlideDirection;

		public float slideDistance;

		[Header("Return Animation")]
		public float speed;

		[Header("References")]
		public SlideVirtualController controller;

		public Gun gun;

		private SimpleTransform _localStartTransform;

		private bool _isReturning;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSlideUpdate(float perc)
		{
		}

		private void OnSlideReleased()
		{
		}

		private void OnSlideGrabbed()
		{
		}

		private void Update()
		{
		}
	}
}
