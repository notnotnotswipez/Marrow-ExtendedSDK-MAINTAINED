using UnityEngine;

namespace SplineMesh
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Spline))]
	public class ExampleGrowingRoot : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private float rate;

		private MeshBender meshBender;

		public Mesh mesh;

		public Material material;

		public Vector3 rotation;

		public Vector3 scale;

		public float startScale;

		public float DurationInSecond;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void EditorUpdate()
		{
		}

		private void Contort()
		{
		}

		private void Init()
		{
		}
	}
}
