using TriangleNet.Meshing;

namespace TriangleNet.Geometry
{
	public static class ExtensionMethods
	{
		public static IMesh Triangulate(this IPolygon polygon)
		{
			return null;
		}

		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options)
		{
			return null;
		}

		public static IMesh Triangulate(this IPolygon polygon, QualityOptions quality)
		{
			return null;
		}

		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options, QualityOptions quality)
		{
			return null;
		}

		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options, QualityOptions quality, ITriangulator triangulator)
		{
			return null;
		}

		public static bool Contains(this ITriangle triangle, Point p)
		{
			return false;
		}

		public static bool Contains(this ITriangle triangle, double x, double y)
		{
			return false;
		}

		public static Rectangle Bounds(this ITriangle triangle)
		{
			return null;
		}

		internal static double DotProduct(Point p, Point q)
		{
			return 0.0;
		}
	}
}
