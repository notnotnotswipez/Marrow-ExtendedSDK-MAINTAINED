using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public class Triangle : ITriangle
	{
		internal int hash;

		internal int id;

		internal Otri[] neighbors;

		internal Vertex[] vertices;

		internal Osub[] subsegs;

		internal int label;

		internal double area;

		internal bool infected;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Label
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double Area
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public int GetVertexID(int index)
		{
			return 0;
		}

		public ITriangle GetNeighbor(int index)
		{
			return null;
		}

		public int GetNeighborID(int index)
		{
			return 0;
		}

		public ISegment GetSegment(int index)
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
