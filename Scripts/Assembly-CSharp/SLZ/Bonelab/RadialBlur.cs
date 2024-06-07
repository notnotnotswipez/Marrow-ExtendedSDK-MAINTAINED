using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Rigidbody))]
	public class RadialBlur : MonoBehaviour
	{
		private Rigidbody rigidbody;

		public float maxBlur;

		public float AVBlurMultiplier;

		public float AVThresholdBlur;

		public float AVUpdateThreshold;

		public Renderer BluredRenderer;

		public GameObject RealObj;

		private float AVm;

		private bool blurring;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void toggleOff()
		{
		}

		private void toggleOn()
		{
		}

		private void ChangeMaterialBlur()
		{
		}
	}
}
