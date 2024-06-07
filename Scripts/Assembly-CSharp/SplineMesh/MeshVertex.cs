using System;
using UnityEngine;

namespace SplineMesh
{
	[Serializable]
	public class MeshVertex
	{
		public Vector3 position;

		public Vector3 normal;

		public Vector2 uv;

		public MeshVertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
		}

		public MeshVertex(Vector3 position, Vector3 normal)
		{
		}
	}
}
