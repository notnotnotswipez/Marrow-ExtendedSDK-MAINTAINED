using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleSpread : MonoBehaviour
	{
		public enum Alignment
		{
			Surface = 0,
			Source = 1,
			Reflected = 2,
			Viewer = 3,
			SurfaceSourceBlend = 4,
			Direction = 5
		}

		public Alignment alignment;

		[Range(1f, 180f)]
		public float MinAngle;

		[Range(1f, 180f)]
		public float MaxAngle;

		public ParticleSystem TargetParticleSystem;

		private void Reset()
		{
		}

		public void GetPS()
		{
		}
	}
}
