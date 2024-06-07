using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	public class VoronoiRegion
	{
		private int id;

		private Point generator;

		private List<Point> vertices;

		private bool bounded;

		private Dictionary<int, VoronoiRegion> neighbors;

		public int ID => 0;

		public Point Generator => null;

		public ICollection<Point> Vertices => null;

		public bool Bounded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VoronoiRegion(Vertex generator)
		{
		}

		public void Add(Point point)
		{
		}

		public void Add(List<Point> points)
		{
		}

		public VoronoiRegion GetNeighbor(Point p)
		{
			return null;
		}

		internal void AddNeighbor(int id, VoronoiRegion neighbor)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
