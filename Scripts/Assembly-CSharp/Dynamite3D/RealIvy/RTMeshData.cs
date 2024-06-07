using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class RTMeshData
	{
		private int vertCount;

		private int vertexIndex;

		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector2[] uv;

		public Vector2[] uv2;

		public Color[] colors;

		public int[] triangleIndices;

		public int[][] triangles;

		public RTMeshData(int numVertices, int numSubmeshes, List<int> numTrianglesPerSubmesh)
		{
		}

		public RTMeshData(Mesh mesh)
		{
		}

		private void SetValues(Vector3[] vertices, Vector3[] normals, Vector2[] uv, Color[] colors, int[][] triangles)
		{
		}

		public void CopyDataFromIndex(int index, int lastTriCount, int numTris, RTMeshData copyFrom)
		{
		}

		public void AddTriangle(int sumbesh, int value)
		{
		}

		public void AddVertex(Vector3 vertexValue, Vector3 normalValue, Vector2 uvValue, Color color)
		{
		}

		private void Resize()
		{
		}

		public int VertexCount()
		{
			return 0;
		}

		public void Clear()
		{
		}
	}
}
