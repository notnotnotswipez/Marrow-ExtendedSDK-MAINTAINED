using UnityEngine;

namespace SLZ.Bonelab
{
	public class BezierRing : MonoBehaviour
	{
		[SerializeField]
		public Transform[] points;

		private LineRenderer Liner;

		public int lineSteps;

		public int CurveCount => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public Vector3 GetPoint(float t)
		{
			return default(Vector3);
		}

		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		public void OnWillRenderObject()
		{
		}

		public void UpdateLines()
		{
		}
	}
}
