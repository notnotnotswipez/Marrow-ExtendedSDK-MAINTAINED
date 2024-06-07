using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Voronoi
{
	public interface IVoronoiFactory
	{
		void Initialize(int vertexCount, int edgeCount, int faceCount);

		void Reset();

		TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y);

		HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face);

		Face CreateFace(TriangleNet.Geometry.Vertex vertex);
	}
}
