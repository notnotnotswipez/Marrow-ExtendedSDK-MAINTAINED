using System.Collections.Generic;
using UnityEngine;

namespace SplineMesh
{
	[RequireComponent(typeof(Spline))]
	[ExecuteInEditMode]
	public class RopeBuilder : MonoBehaviour
	{
		private bool toUpdate;

		private GameObject generated;

		private Spline spline;

		private GameObject firstSegment;

		[SerializeField]
		public List<GameObject> wayPoints;

		public GameObject segmentPrefab;

		public int segmentCount;

		public float segmentSpacing;

		private GameObject Generated => null;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void UpdateNodes()
		{
		}

		private void UpdateSpline()
		{
		}

		private void Generate()
		{
		}
	}
}
