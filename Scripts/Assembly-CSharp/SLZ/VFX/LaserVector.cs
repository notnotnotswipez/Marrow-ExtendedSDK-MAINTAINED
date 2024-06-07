using UnityEngine;

namespace SLZ.VFX
{
	public class LaserVector : MonoBehaviour
	{
		public enum Alignment
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		public Alignment alignment;

		public Renderer[] renderers;

		public TrailRenderer trail;

		private Vector3 preV3;

		private Color startcolor;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
