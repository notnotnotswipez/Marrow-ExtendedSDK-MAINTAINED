using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	public class DefaultVoronoiFactory : IVoronoiFactory
	{
		public void Initialize(int vertexCount, int edgeCount, int faceCount)
		{
		}

		public void Reset()
		{
		}

		public TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y)
		{
			return null;
		}

		public HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face)
		{
			return null;
		}

		public Face CreateFace(TriangleNet.Geometry.Vertex vertex)
		{
			return null;
		}
	}
}
