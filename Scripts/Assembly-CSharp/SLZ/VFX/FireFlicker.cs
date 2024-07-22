using UnityEngine;

namespace SLZ.VFX
{
	public class FireFlicker : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("maximum possible intensity the light can flicker to")]
		[Min(0f)]
		private float maxIntensity;

		[Min(0f)]
		[SerializeField]
		[Tooltip("minimum possible intensity the light can flicker to")]
		private float minIntensity;

		[Min(0f)]
		[SerializeField]
		[Tooltip("maximum frequency of often the light will flicker in seconds")]
		private float maxFlickerFrequency;

		[Tooltip("minimum frequency of often the light will flicker in seconds")]
		[Min(0f)]
		[SerializeField]
		private float minFlickerFrequency;

		[Tooltip("how fast the light will flicker to it's next intensity (a very high value will)look like a dying lightbulb while a lower value will look more like an organic fire")]
		[SerializeField]
		[Min(0f)]
		private float strength;

		private float baseIntensity;

		private float nextIntensity;

		private float flickerFrequency;

		private float timeOfLastFlicker;

		public Light LightSource;

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Flicker()
		{
		}

		public void Reset()
		{
		}
	}
}
