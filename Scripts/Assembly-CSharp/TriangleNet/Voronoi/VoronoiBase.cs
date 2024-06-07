using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	public abstract class VoronoiBase : DcelMesh
	{
		protected IPredicates predicates;

		protected IVoronoiFactory factory;

		protected List<HalfEdge> rays;

		protected VoronoiBase(Mesh mesh, IVoronoiFactory factory, IPredicates predicates, bool generate)
		{
		}

		protected void Generate(Mesh mesh)
		{
		}

		protected List<HalfEdge>[] ComputeVertices(Mesh mesh, TriangleNet.Topology.DCEL.Vertex[] vertices)
		{
			return null;
		}

		protected void ComputeEdges(Mesh mesh, TriangleNet.Topology.DCEL.Vertex[] vertices, Face[] faces, List<HalfEdge>[] map)
		{
		}

		protected virtual void ConnectEdges(List<HalfEdge>[] map)
		{
		}

		protected override IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
