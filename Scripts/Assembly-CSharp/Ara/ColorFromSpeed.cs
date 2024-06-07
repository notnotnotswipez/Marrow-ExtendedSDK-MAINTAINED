using UnityEngine;

namespace Ara
{
	[RequireComponent(typeof(AraTrail))]
	public class ColorFromSpeed : MonoBehaviour
	{
		private AraTrail trail;

		[Tooltip("Maps trail speed to color. Control how much speed is transferred to the trail by setting inertia > 0. The trail will be colorized even if physics are disabled. ")]
		public Gradient colorFromSpeed;

		[Tooltip("Min speed used to map speed to color.")]
		public float minSpeed;

		[Tooltip("Max speed used to map speed to color.")]
		public float maxSpeed;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetColorFromSpeed()
		{
		}
	}
}
