using UnityEngine;

namespace SplineMesh
{
	[ExecuteInEditMode]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class SplineMeshTiling : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private bool toUpdate;

		[Tooltip("Mesh to bend along the spline.")]
		public Mesh mesh;

		[Tooltip("Material to apply on the bent mesh.")]
		public Material material;

		[Tooltip("Physic material to apply on the bent mesh.")]
		public PhysicMaterial physicMaterial;

		[Tooltip("Translation to apply on the mesh before bending it.")]
		public Vector3 translation;

		[Tooltip("Rotation to apply on the mesh before bending it.")]
		public Vector3 rotation;

		[Tooltip("Scale to apply on the mesh before bending it.")]
		public Vector3 scale;

		[Tooltip("If true, a mesh collider will be generated.")]
		public bool generateCollider;

		[Tooltip("If true, the mesh will be bent on play mode. If false, the bent mesh will be kept from the editor mode, allowing lighting baking.")]
		public bool updateInPlayMode;

		[Tooltip("If true, a mesh will be placed on each curve of the spline. If false, a single mesh will be placed for the whole spline.")]
		public bool curveSpace;

		[Tooltip("The mode to use to fill the choosen interval with the bent mesh.")]
		public MeshBender.FillingMode mode;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void CreateMeshes()
		{
		}

		private GameObject FindOrCreate(string name)
		{
			return null;
		}
	}
}
