using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public class SubSegment : ISegment, IEdge
	{
		internal int hash;

		internal Osub[] subsegs;

		internal Vertex[] vertices;

		internal Otri[] triangles;

		internal int boundary;

		public int P0 => 0;

		public int P1 => 0;

		public int Label => 0;

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public ITriangle GetTriangle(int index)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
