using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Utility
{
	public static class CubicBezierUtility
	{
		public static Vector3 EvaluateCurve(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		public static Vector3 EvaluateCurve(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 EvaluateCurveDerivative(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		public static Vector3 EvaluateCurveDerivative(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 EvaluateCurveSecondDerivative(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		public static Vector3 EvaluateCurveSecondDerivative(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 Normal(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		public static Vector3 Normal(Vector3 a1, Vector3 c1, Vector3 c2, Vector3 a2, float t)
		{
			return default(Vector3);
		}

		public static Bounds CalculateSegmentBounds(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Bounds);
		}

		public static Vector3[][] SplitCurve(Vector3[] points, float t)
		{
			return null;
		}

		public static float EstimateCurveLength(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		public static List<float> ExtremePointTimes(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return null;
		}

		private static IEnumerable<float> StationaryPointTimes(float a, float b, float c)
		{
			return null;
		}
	}
}
