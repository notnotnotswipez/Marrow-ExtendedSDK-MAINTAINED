using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	public class TriangleQuadTree
	{
		private class QuadNode
		{
			private const int SW = 0;

			private const int SE = 1;

			private const int NW = 2;

			private const int NE = 3;

			private const double EPS = 1E-06;

			private static readonly byte[] BITVECTOR;

			private Rectangle bounds;

			private Point pivot;

			private TriangleQuadTree tree;

			private QuadNode[] regions;

			private List<int> triangles;

			private byte bitRegions;

			public QuadNode(Rectangle box, TriangleQuadTree tree)
			{
			}

			public QuadNode(Rectangle box, TriangleQuadTree tree, bool init)
			{
			}

			public List<int> FindTriangles(Point searchPoint)
			{
				return null;
			}

			public void CreateSubRegion(int currentDepth)
			{
			}

			private void AddTriangleToRegion(Point[] triangle, int index)
			{
			}

			private void FindTriangleIntersections(Point[] triangle, int index)
			{
			}

			private void FindIntersectionsWithX(double dx, double dy, Point[] triangle, int index, int k)
			{
			}

			private void FindIntersectionsWithY(double dx, double dy, Point[] triangle, int index, int k)
			{
			}

			private int FindRegion(Point point)
			{
				return 0;
			}

			private void AddToRegion(int index, int region)
			{
			}
		}

		private QuadNode root;

		internal ITriangle[] triangles;

		internal int sizeBound;

		internal int maxDepth;

		public TriangleQuadTree(Mesh mesh, int maxDepth = 10, int sizeBound = 10)
		{
		}

		public ITriangle Query(double x, double y)
		{
			return null;
		}

		internal static bool IsPointInTriangle(Point p, Point t0, Point t1, Point t2)
		{
			return false;
		}

		internal static double DotProduct(Point p, Point q)
		{
			return 0.0;
		}
	}
}
