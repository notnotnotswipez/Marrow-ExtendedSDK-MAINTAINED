using System;
using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Voronoi.Legacy
{
	[Obsolete("Use TriangleNet.Voronoi.BoundedVoronoi class instead.")]
	public class BoundedVoronoiLegacy : IVoronoi
	{
		private IPredicates predicates;

		private Mesh mesh;

		private Point[] points;

		private List<VoronoiRegion> regions;

		private List<Point> segPoints;

		private int segIndex;

		private Dictionary<int, SubSegment> subsegMap;

		private bool includeBoundary;

		public Point[] Points => null;

		public ICollection<VoronoiRegion> Regions => null;

		public IEnumerable<IEdge> Edges => null;

		public BoundedVoronoiLegacy(Mesh mesh)
		{
		}

		public BoundedVoronoiLegacy(Mesh mesh, bool includeBoundary)
		{
		}

		private void Generate()
		{
		}

		private void ComputeCircumCenters()
		{
		}

		private void TagBlindTriangles()
		{
		}

		private bool TriangleIsBlinded(ref Otri tri, ref Osub seg)
		{
			return false;
		}

		private void ConstructCell(Vertex vertex)
		{
		}

		private void ConstructBoundaryCell(Vertex vertex)
		{
		}

		private bool SegmentsIntersect(Point p1, Point p2, Point p3, Point p4, out Point p, bool strictIntersect)
		{
			p = null;
			return false;
		}

		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
