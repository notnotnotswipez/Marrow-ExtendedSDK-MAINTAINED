using UnityEngine;

namespace Lux_SRP_GrassDisplacement
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		public float maxDistance;

		public float fallOff;

		[Layer]
		public int layerMask;

		[Space(5f)]
		public bool DebugRay;

		private Transform trans;

		private ParticleSystem ps;

		private ParticleSystem.MainModule main;

		private RaycastHit hit;

		private float alpha;

		private float min_alpha;

		private float max_alpha;

		private Color min_StartColor;

		private Color max_StartColor;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
