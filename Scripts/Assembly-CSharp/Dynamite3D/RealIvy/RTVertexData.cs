using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public struct RTVertexData
	{
		public Vector3 vertex;

		public Vector3 normal;

		public Vector2 uv;

		public Vector2 uv2;

		public Color color;

		public RTVertexData(Vector3 vertex, Vector3 normal, Vector2 uv, Vector2 uv2, Color color)
		{
			this.vertex = Vector3.down;
			this.normal = Vector3.up;
			this.uv = Vector2.down;
			this.uv2 = Vector2.left;
			this.color = Color.white;
		}
	}
}
