using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	internal class BadTriangle
	{
		public Otri poortri;

		public double key;

		public Vertex org;

		public Vertex dest;

		public Vertex apex;

		public BadTriangle next;

		public override string ToString()
		{
			return null;
		}
	}
}
