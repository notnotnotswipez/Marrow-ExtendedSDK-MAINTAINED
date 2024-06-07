using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(LineRenderer))]
	public class DrawBezierCurve : MonoBehaviour
	{
		private LineRenderer Liner;

		[SerializeField]
		public GameObject Point1;

		[SerializeField]
		public GameObject Point2;

		[SerializeField]
		public GameObject Point3;

		[SerializeField]
		public GameObject Point4;

		[SerializeField]
		private bool OnlySetOnStart;

		public int lineSteps;

		public float linePercentageFill;

		private void Awake()
		{
		}

		public void OnWillRenderObject()
		{
		}

		public void UpdateLines()
		{
		}

		public Vector3 GetBezPoint(float t)
		{
			return default(Vector3);
		}

		private Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		private Vector3 GetSplinePoint(Vector3 start, Vector3 startTangent, Vector3 endTangent, Vector3 end, float perc)
		{
			return default(Vector3);
		}
	}
}
