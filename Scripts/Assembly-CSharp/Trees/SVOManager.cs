using System.Collections.Generic;
using System.IO;
using MeshTools;
using Navigation;
using SLZ.Marrow.AI;
using UnityEngine;
using UnityEngine.Serialization;

namespace Trees
{
	public class SVOManager : MonoBehaviour
	{
		public int desiredSize;

		private int _maxSize;

		private int _rootResolution;

		private int _finalResolution;

		private int _nbLayers;

		public SerializedSVODict svoDict;

		private SparseVoxelOctree _tempSvo;

		private SparseVoxelOctree _tempSvo2;

		public int[] agentSizes;

		public bool drawGizmos;

		public bool generateDebugMesh;

		public bool debugPrintNodes;

		public bool debugDrawTestPos;

		public Color svoVolumeColor;

		public Color parentVoxelColor;

		public Color levelZeroNodeColor;

		public Color openVoxelColor;

		public Color occupiedVoxelColor;

		public float debugOpacity;

		public string folderName;

		public string fileName;

		public VoxelDebugMesh dbgMeshMaker;

		private int _voxelSize;

		private int _gridSize;

		private Vector3 _frontLeftCenterPos;

		private Vector3 _voxFrontLeftCenterPos;

		private Vector3 _voxCenter;

		[FormerlySerializedAs("_isUpdated")]
		public bool isUpdated;

		private bool _isInit;

		private Stream _fileStream;

		[Header("Test Section")]
		public GameObject testObj;

		public bool showTestObjPos;

		public Vector3 testAreaSize;

		public Vector3 testAreaSize2;

		public Color areaColor;

		public Color areaColor2;

		public Color areaNodecolor;

		public List<uint> areaNodes;

		public Vector3 testRoamPosition;

		public GameObject testObj2;

		public GameObject testRoamObject;

		public RoamArea testRoamArea;

		public float testRadius;

		public bool useMinHeight;

		public float testMinHeight;

		public float pointDensity;

		public bool testUseHeightCost;

		public GameObject heightReferencePoint;

		public SvoAgent testSvoAgent;

		private HeightRangeCost _heightCost;

		private void OnValidate()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void Awake()
		{
		}

		[ContextMenu("MakeSVO")]
		public void MakeSvos()
		{
		}

		public void InitTree(int agentSize)
		{
		}

		[ContextMenu("ClearSVO")]
		public void ClearSvo()
		{
		}

		public uint[] RequestPath(Vector3 startPos, Vector3 endPos, int agentSize)
		{
			return null;
		}

		[ContextMenu("SaveSVO")]
		public void SaveSvos()
		{
		}

		[ContextMenu("LoadSVO")]
		public void LoadSvos()
		{
		}

		[ContextMenu("CloseStream")]
		public void CloseFileStream()
		{
		}

		[ContextMenu("Delete All SVOs")]
		public void DeleteSvos()
		{
		}

		public void GenerateOccupancyMesh(int agentSize)
		{
		}

		[ContextMenu("Clear Debug Mesh Parents")]
		public void ClearDebugMeshParents()
		{
		}

		[ContextMenu("Clear Debug Meshes")]
		public void ClearDebugMeshes()
		{
		}

		private void SetColors()
		{
		}

		[ContextMenu("Test Object Link Pos")]
		private void GetTestPos()
		{
		}

		public void DrawSVOGizmos(int agentSize)
		{
		}

		private void DrawTestObjects()
		{
		}

		[ContextMenu("Get Overlap Area Nodes")]
		private void GetAreaNodes()
		{
		}

		[ContextMenu("Get Sphere Surface Nodes")]
		private void GetSphereSurfaceNodes()
		{
		}

		[ContextMenu("Get Sphere Volume Nodes")]
		private void GetSphereVolumeNodes()
		{
		}

		[ContextMenu("Get Sphere Surface Position")]
		private void GetSphereSurfacePosition()
		{
		}

		[ContextMenu("Get Sphere Volume Position")]
		private void GetSphereVolumePosition()
		{
		}

		[ContextMenu("Get Roam Position From Open Nodes")]
		private void GetRoamPosition()
		{
		}

		[ContextMenu("Path With Roam Area")]
		private void PathFromRoamArea()
		{
		}

		[ContextMenu("Test Area Overlap")]
		private void TestAreaOverlap()
		{
		}

		[ContextMenu("Clear AreaNodes")]
		private void ClearAreaNodes()
		{
		}

		[ContextMenu("Position to Voxel Test")]
		private void PosToVoxel()
		{
		}

		[ContextMenu("Find Path")]
		private void FindPath()
		{
		}

		[ContextMenu("Clear SVO Agent")]
		public void ClearSVOAgent()
		{
		}
	}
}
