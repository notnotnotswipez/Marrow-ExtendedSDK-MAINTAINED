using System;
using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	[Obsolete("Use TriangleNet.Voronoi.StandardVoronoi class instead.")]
	public class SimpleVoronoi : IVoronoi
	{
		private IPredicates predicates;

		private Mesh mesh;

		private Point[] points;

		private Dictionary<int, VoronoiRegion> regions;

		private Dictionary<int, Point> rayPoints;

		private int rayIndex;

		private Rectangle bounds;

		public Point[] Points => null;

		public ICollection<VoronoiRegion> Regions => null;

		public IEnumerable<IEdge> Edges => null;

		public SimpleVoronoi(Mesh mesh)
		{
		}

		private void Generate()
		{
		}

		private void ComputeCircumCenters()
		{
		}

		private void ConstructCell(VoronoiRegion region)
		{
		}

		private bool BoxRayIntersection(Point pt, double dx, double dy, out Point intersect)
		{
			intersect = null;
			return false;
		}

		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
