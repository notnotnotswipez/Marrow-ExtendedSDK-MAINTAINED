using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	internal class BadTriQueue
	{
		private const double SQRT2 = 1.4142135623730951;

		private BadTriangle[] queuefront;

		private BadTriangle[] queuetail;

		private int[] nextnonemptyq;

		private int firstnonemptyq;

		private int count;

		public int Count => 0;

		public void Enqueue(BadTriangle badtri)
		{
		}

		public void Enqueue(ref Otri enqtri, double minedge, Vertex apex, Vertex org, Vertex dest)
		{
		}

		public BadTriangle Dequeue()
		{
			return null;
		}
	}
}
