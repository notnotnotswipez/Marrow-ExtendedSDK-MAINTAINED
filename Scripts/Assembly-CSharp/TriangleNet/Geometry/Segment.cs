namespace TriangleNet.Geometry
{
	public class Segment : ISegment, IEdge
	{
		private Vertex v0;

		private Vertex v1;

		private int label;

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

		public int P0 => 0;

		public int P1 => 0;

		public Segment(Vertex v0, Vertex v1)
		{
		}

		public Segment(Vertex v0, Vertex v1, int label)
		{
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public ITriangle GetTriangle(int index)
		{
			return null;
		}
	}
}
