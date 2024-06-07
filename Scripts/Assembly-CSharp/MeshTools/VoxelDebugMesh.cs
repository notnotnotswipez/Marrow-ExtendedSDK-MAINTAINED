using System.Collections.Generic;
using Trees;
using UnityEngine;

namespace MeshTools
{
	public class VoxelDebugMesh : MonoBehaviour
	{
		public GameObject[] octantMeshObjects;

		public MeshFilter[] octantMeshFilters;

		public MeshRenderer[] octantMeshRenderers;

		public Material unocLeafMat;

		public Material unocOctantMat;

		public GameObject[] leafMeshObjects;

		public MeshFilter[] leafMeshFilters;

		public MeshRenderer[] leafMeshRenderers;

		public Material[] leafMeshMaterials;

		private List<Mesh> _activeMeshes;

		private List<Mesh> _inactiveMeshes;

		private string _materialPath;

		private string _ocVoxString;

		private string _unocVoxString;

		private string _unocLeafString;

		private string _unocOctant;

		[ContextMenu("Init")]
		public void Init(int nbLayers)
		{
		}

		public void MeshFromNodes(SparseVoxelOctree svo)
		{
		}

		public void MeshFromLeafs(SparseVoxelOctree svo)
		{
		}

		public (GameObject, MeshFilter, MeshRenderer) MeshObjectSetup(string name, Material material, GameObject parent)
		{
			return default((GameObject, MeshFilter, MeshRenderer));
		}
	}
}
