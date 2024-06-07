using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(LineRenderer))]
	public class SmokeTrail : MonoBehaviour
	{
		private LineRenderer line;

		private Transform tr;

		private Vector3[] positions;

		private Vector3[] directions;

		private int i;

		private float timeSinceUpdate;

		private Material lineMaterial;

		private float lineSegment;

		private int currentNumberOfPoints;

		private bool allPointsAdded;

		public int numberOfPoints;

		public float updateSpeed;

		public float riseSpeed;

		public float spread;

		private Vector3 tempVec;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private Vector3 getSmokeVec()
		{
			return default(Vector3);
		}
	}
}
