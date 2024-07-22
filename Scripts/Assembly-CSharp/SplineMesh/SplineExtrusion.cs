using System.Collections.Generic;
using UnityEngine;

namespace SplineMesh
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Spline))]
	public class SplineExtrusion : MonoBehaviour
	{
		private Spline spline;

		private bool toUpdate;

		private GameObject generated;

		public List<ExtrusionSegment.Vertex> shapeVertices;

		public Material material;

		public float textureScale;

		public float sampleSpacing;

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void GenerateMesh()
		{
		}

		public void SetToUpdate()
		{
		}
	}
}
