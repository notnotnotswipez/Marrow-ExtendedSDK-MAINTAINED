using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	public class BoundedVoronoi : VoronoiBase
	{
		private int offset;

		public BoundedVoronoi(Mesh mesh)
			: base(null, null, null, generate: false)
		{
		}

		public BoundedVoronoi(Mesh mesh, IVoronoiFactory factory, IPredicates predicates)
			: base(null, null, null, generate: false)
		{
		}

		private void PostProcess()
		{
		}

		private void HandleCase1(HalfEdge edge, TriangleNet.Geometry.Vertex v1, TriangleNet.Geometry.Vertex v2)
		{
		}

		private void HandleCase2(HalfEdge edge, TriangleNet.Geometry.Vertex v1, TriangleNet.Geometry.Vertex v2)
		{
		}
	}
}
