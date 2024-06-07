namespace TriangleNet.Topology.DCEL
{
	public class HalfEdge
	{
		internal int id;

		internal int mark;

		internal Vertex origin;

		internal Face face;

		internal HalfEdge twin;

		internal HalfEdge next;

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

		public int Boundary
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vertex Origin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Face Face
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HalfEdge Twin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HalfEdge Next
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HalfEdge(Vertex origin)
		{
		}

		public HalfEdge(Vertex origin, Face face)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
