using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(LineRenderer))]
	public class DrawLine2Points : MonoBehaviour
	{
		private LineRenderer Liner;

		[SerializeField]
		public GameObject Point1;

		[SerializeField]
		public GameObject Point2;

		[SerializeField]
		private bool OnlySetOnStart;

		private void Awake()
		{
		}

		public void OnWillRenderObject()
		{
		}

		public void UpdateLines()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
