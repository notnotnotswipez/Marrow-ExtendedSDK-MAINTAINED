using UnityEngine;

namespace SplineMesh
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class ExampleSower : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private bool toUpdate;

		public GameObject prefab;

		public float scale;

		public float scaleRange;

		public float spacing;

		public float spacingRange;

		public float offset;

		public float offsetRange;

		public bool isRandomYaw;

		public int randomSeed;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void Sow()
		{
		}
	}
}
