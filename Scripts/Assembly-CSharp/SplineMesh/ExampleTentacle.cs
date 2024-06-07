using UnityEngine;

namespace SplineMesh
{
	[DisallowMultipleComponent]
	public class ExampleTentacle : MonoBehaviour
	{
		public float startScale;

		public float endScale;

		public float startRoll;

		public float endRoll;

		private Spline spline => null;

		private void OnValidate()
		{
		}
	}
}
