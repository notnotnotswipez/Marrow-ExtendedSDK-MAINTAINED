using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[RequireComponent(typeof(ParticleSystem))]
	public class Powerable_ParticleManager : Powerable
	{
		[Header("Powerable Settings")]
		public float map_low;

		public float map_high;

		[Header("Control Particle System externally")]
		[Range(0f, 1f)]
		[SerializeField]
		public float Thickness;

		[Range(0f, 1f)]
		[SerializeField]
		public float OutputSpeed;

		[SerializeField]
		[Tooltip("Minimum amount of particles allowed")]
		private float MinParticleCount;

		public AmbientSFX ambientSound;

		private float ambientSoundMax;

		[HideInInspector]
		[SerializeField]
		private ParticleSystem sourcePSystem;

		[SerializeField]
		[HideInInspector]
		private ParticleSystem.EmissionModule EmissionModule;

		[SerializeField]
		[HideInInspector]
		private ParticleSystem.MainModule MainModule;

		private float orginalEmissionRate;

		private Vector2 orginalSpeed;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void UpdateAmount()
		{
		}

		public void UpdateSpeed(float SpeedPercentage)
		{
		}

		public void UpdateAmount(float SpeedPercentage, float ThicknessPercentage)
		{
		}

		public void turnOff()
		{
		}

		public void turnOn()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}
	}
}
