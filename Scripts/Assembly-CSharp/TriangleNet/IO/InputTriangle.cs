using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public class InputTriangle : ITriangle
	{
		internal int[] vertices;

		internal int label;

		internal double area;

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

		public InputTriangle(int p0, int p1, int p2)
		{
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
	}
}
