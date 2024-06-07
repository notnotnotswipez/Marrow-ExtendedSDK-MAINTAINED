namespace TriangleNet.Geometry
{
	public interface ISegment : IEdge
	{
		Vertex GetVertex(int index);

		ITriangle GetTriangle(int index);
	}
}
