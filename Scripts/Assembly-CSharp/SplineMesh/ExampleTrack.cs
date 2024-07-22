using System.Collections.Generic;
using UnityEngine;

namespace SplineMesh
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class ExampleTrack : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private bool toUpdate;

		public List<TrackSegment> segments;

		public bool updateInPlayMode;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void CreateMeshes()
		{
		}
	}
}
