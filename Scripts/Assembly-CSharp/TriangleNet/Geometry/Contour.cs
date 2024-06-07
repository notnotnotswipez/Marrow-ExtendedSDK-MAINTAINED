using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TriangleNet.Geometry
{
	public class Contour
	{
		private int marker;

		private bool convex;

		public List<Vertex> Points
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Contour(IEnumerable<Vertex> points)
		{
		}

		public Contour(IEnumerable<Vertex> points, int marker)
		{
		}

		public Contour(IEnumerable<Vertex> points, int marker, bool convex)
		{
		}

		public List<ISegment> GetSegments()
		{
			return null;
		}

		public Point FindInteriorPoint(int limit = 5, double eps = 2E-05)
		{
			return null;
		}

		private void AddPoints(IEnumerable<Vertex> points)
		{
		}

		private static Point FindPointInPolygon(List<Vertex> contour, int limit, double eps)
		{
			return null;
		}

		private static bool IsPointInPolygon(Point point, List<Vertex> poly)
		{
			return false;
		}
	}
}
