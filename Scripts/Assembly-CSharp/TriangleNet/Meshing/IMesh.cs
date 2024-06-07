using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	public interface IMesh
	{
		ICollection<Vertex> Vertices { get; }

		IEnumerable<Edge> Edges { get; }

		ICollection<SubSegment> Segments { get; }

		ICollection<Triangle> Triangles { get; }

		IList<Point> Holes { get; }

		Rectangle Bounds { get; }

		void Renumber();

		void Refine(QualityOptions quality, bool delaunay);
	}
}
