using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshCombiner : MonoBehaviour
{
	private const int Mesh16BitBufferVertexLimit = 65535;

	[SerializeField]
	private bool createMultiMaterialMesh;

	[SerializeField]
	private bool combineInactiveChildren;

	[SerializeField]
	private bool deactivateCombinedChildren;

	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	[SerializeField]
	private bool generateUVMap;

	[SerializeField]
	private bool destroyCombinedChildren;

	[SerializeField]
	private string folderPath;

	[SerializeField]
	[Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	private MeshFilter[] meshFiltersToSkip;

	public bool CreateMultiMaterialMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CombineInactiveChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildrenMeshRenderers
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GenerateUVMap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DestroyCombinedChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string FolderPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void CheckDeactivateCombinedChildren()
	{
	}

	private void CheckDestroyCombinedChildren()
	{
	}

	public void CombineMeshes(bool showCreatedMeshInfo)
	{
	}

	private MeshFilter[] GetMeshFiltersToCombine()
	{
		return null;
	}

	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
	}

	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
	}

	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters)
	{
	}

	private void GenerateUV(Mesh combinedMesh)
	{
	}
}
