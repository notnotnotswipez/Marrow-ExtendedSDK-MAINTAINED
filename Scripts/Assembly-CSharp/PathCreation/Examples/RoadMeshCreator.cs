using UnityEngine;

namespace PathCreation.Examples
{
	public class RoadMeshCreator : PathSceneTool
	{
		[Header("Road settings")]
		public float roadWidth;

		public float thickness;

		public bool flattenSurface;

		[Header("Material settings")]
		public Material roadMaterial;

		public Material undersideMaterial;

		public float textureTiling;

		[SerializeField]
		[HideInInspector]
		public GameObject meshHolder;

		private MeshFilter meshFilter;

		private MeshRenderer meshRenderer;

		private Mesh mesh;

		private string assetPath;

		protected override void PathUpdated()
		{
		}

		private void CreateRoadMesh()
		{
		}

		private void AssignMeshComponents()
		{
		}

		private void AssignMaterials()
		{
		}
	}
}
