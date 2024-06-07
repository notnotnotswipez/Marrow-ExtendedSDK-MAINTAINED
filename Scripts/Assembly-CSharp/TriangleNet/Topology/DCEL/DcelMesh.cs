using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class DcelMesh
	{
		protected List<Vertex> vertices;

		protected List<HalfEdge> edges;

		protected List<Face> faces;

		public List<Vertex> Vertices => null;

		public List<HalfEdge> HalfEdges => null;

		public List<Face> Faces => null;

		public IEnumerable<IEdge> Edges => null;

		public DcelMesh()
		{
		}

		protected DcelMesh(bool initialize)
		{
		}

		public virtual bool IsConsistent(bool closed = true, int depth = 0)
		{
			return false;
		}

		public void ResolveBoundaryEdges()
		{
		}

		protected virtual IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
