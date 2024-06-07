using System;
using UnityEngine;

namespace SplineMesh
{
	[Serializable]
	public class TransformedMesh
	{
		public Mesh mesh;

		public Material material;

		public PhysicMaterial physicMaterial;

		public Vector3 translation;

		public Vector3 rotation;

		public Vector3 scale;
	}
}
