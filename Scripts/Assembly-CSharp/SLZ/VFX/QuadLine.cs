using UnityEngine;

namespace SLZ.VFX
{
	public class QuadLine : MonoBehaviour
	{
		[SerializeField]
		private GameObject LineTransform;

		[SerializeField]
		private Renderer LineRenderer;

		[SerializeField]
		public GameObject TargetObject;

		[SerializeField]
		private float lineWidth;

		private void Update()
		{
		}
	}
}
