using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	public interface IConstraintMesher
	{
		IMesh Triangulate(IPolygon polygon);

		IMesh Triangulate(IPolygon polygon, ConstraintOptions options);
	}
}
