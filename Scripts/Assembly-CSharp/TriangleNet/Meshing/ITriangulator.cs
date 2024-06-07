using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	public interface ITriangulator
	{
		IMesh Triangulate(IList<Vertex> points, Configuration config);
	}
}
