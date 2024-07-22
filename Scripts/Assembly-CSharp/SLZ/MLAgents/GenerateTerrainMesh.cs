using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MLAgents
{
	[RequireComponent(typeof(MeshCollider))]
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(MeshFilter))]
	public class GenerateTerrainMesh : MonoBehaviour
	{
		public GameObject dbgPoint;

		public Material centerMat;

		public bool useDbg;

		[Tooltip("Size of Square Mesh is Generated On")]
		public float squareSize;

		[Tooltip("Distance Between Points")]
		public float pointSpacing;

		[Tooltip("Distance to Translate Each Point")]
		public float pointOffset;

		[Tooltip("Points That Define Triangle Points")]
		public Vector3[] verts;

		[Tooltip("Points That Were Selected to Displace using Centroid Displacement")]
		public List<int> displaceCenterInds;

		[Tooltip("Probability That Each Vertex Will be Selected for Displacement")]
		public float selectionFreq;

		[Tooltip("Linear Area of Effect for Centroid Displacement")]
		public int selectionRadius;

		[Tooltip("Max Height that Displacement Ranges can Reach")]
		public float maxHeight;

		[Tooltip("Displacement Styles that Create Gaussian Craters/Hills")]
		public bool useCentroidDisplace;

		private string assetPath;

		private int[] GetShuffledInds(int size)
		{
			return null;
		}

		private void GetRandomCentroids(int[] inds)
		{
		}

		private void CentroidDisplace()
		{
		}

		private int[] GenerateTriangles(int triSize)
		{
			return null;
		}

		private Vector2[] GenerateUVs(int triSize)
		{
			return null;
		}

		[ContextMenu("ShowDebugPoints")]
		private void ShowDebugPoints()
		{
		}

		[ContextMenu("Generate New Terrain")]
		public void GenerateNewTerrain()
		{
		}

		private void Awake()
		{
		}
	}
}
