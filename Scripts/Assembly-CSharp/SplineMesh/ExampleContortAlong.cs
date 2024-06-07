using UnityEngine;

namespace SplineMesh
{
	[RequireComponent(typeof(Spline))]
	[ExecuteInEditMode]
	public class ExampleContortAlong : MonoBehaviour
	{
		private Spline spline;

		private float rate;

		private MeshBender meshBender;

		[HideInInspector]
		public GameObject generated;

		public Mesh mesh;

		public Material material;

		public Vector3 rotation;

		public Vector3 scale;

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
