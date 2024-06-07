using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class EditorMeshBuilder : ScriptableObject
	{
		public InfoPool infoPool;

		public Mesh ivyMesh;

		private Dictionary<int, int[]> branchesLeavesIndices;

		public Vector3[] verts;

		private Vector3[] normals;

		private Vector2[] uvs;

		private Color[] vColor;

		private int[] trisBranches;

		private List<List<int>> trisLeaves;

		private float angle;

		public List<Material> leavesMaterials;

		public List<List<int>> typesByMat;

		public Rect[] uv2Rects;

		public bool leavesDataInitialized;

		public void InitLeavesData()
		{
		}

		public void Initialize()
		{
		}

		private void BuildLeaves(int b, ref int vertCount)
		{
		}

		public void BuildGeometry()
		{
		}

		private Vector3[] CalculateVectors(Vector3 branchPoint, int p, int b)
		{
			return null;
		}

		private float CalculateRadius(float lenght, float totalLenght)
		{
			return 0f;
		}

		private float GetTipInfluence(float lenght, float totalLenght)
		{
			return 0f;
		}

		private void TriangulateBranch(int b, ref int triCount, int vertCount, int lastVertCount)
		{
		}
	}
}
