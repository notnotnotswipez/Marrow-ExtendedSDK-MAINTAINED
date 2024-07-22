using UnityEngine;

namespace Lux_SRP_GrassDisplacement
{
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		public float maxDistance;

		public float fallOff;

		[Layer]
		public int layerMask;

		[Space(5f)]
		public bool DebugRay;

		private Transform trans;

		private Renderer rend;

		private MaterialPropertyBlock mpb;

		private RaycastHit hit;

		private float alpha;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}
	}
}
