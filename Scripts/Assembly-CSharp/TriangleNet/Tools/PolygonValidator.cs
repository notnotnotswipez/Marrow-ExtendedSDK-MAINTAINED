using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	public static class PolygonValidator
	{
		public static bool IsConsistent(IPolygon poly)
		{
			return false;
		}

		public static bool HasDuplicateVertices(IPolygon poly)
		{
			return false;
		}

		public static bool HasBadAngles(IPolygon poly, double threshold = 2E-12)
		{
			return false;
		}

		private static bool IsBadAngle(Point a, Point b, Point c, double threshold = 0.0)
		{
			return false;
		}

		private static double DotProduct(Point a, Point b, Point c)
		{
			return 0.0;
		}

		private static double CrossProductLength(Point a, Point b, Point c)
		{
			return 0.0;
		}

		private static int CheckVertexIDs(IPolygon poly, int count)
		{
			return 0;
		}

		private static int CheckDuplicateIDs(IPolygon poly)
		{
			return 0;
		}
	}
}
