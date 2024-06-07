using UnityEngine;

namespace PathCreation.Utility
{
	public static class MathUtility
	{
		private class PosRotScale
		{
			public readonly Vector3 position;

			public readonly Quaternion rotation;

			public readonly Vector3 scale;

			public PosRotScale(Transform t)
			{
			}

			public void SetTransform(Transform t)
			{
			}
		}

		private static PosRotScale LockTransformToSpace(Transform t, PathSpace space)
		{
			return null;
		}

		public static Vector3 TransformPoint(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static Vector3 InverseTransformPoint(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static Vector3 TransformVector(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static Vector3 InverseTransformVector(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static Vector3 TransformDirection(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static Vector3 InverseTransformDirection(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		public static bool LineSegmentsIntersect(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			return false;
		}

		public static bool LinesIntersect(Vector2 a1, Vector2 a2, Vector2 a3, Vector2 a4)
		{
			return false;
		}

		public static Vector2 PointOfLineLineIntersection(Vector2 a1, Vector2 a2, Vector2 a3, Vector2 a4)
		{
			return default(Vector2);
		}

		public static Vector2 ClosestPointOnLineSegment(Vector2 p, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public static Vector3 ClosestPointOnLineSegment(Vector3 p, Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static int SideOfLine(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0;
		}

		public static float MinAngle(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		public static bool PointInTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return false;
		}

		public static bool PointsAreClockwise(Vector2[] points)
		{
			return false;
		}
	}
}
