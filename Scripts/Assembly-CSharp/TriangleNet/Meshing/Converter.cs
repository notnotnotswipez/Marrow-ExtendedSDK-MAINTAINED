using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;
using TriangleNet.Topology.DCEL;

namespace TriangleNet.Meshing
{
	public static class Converter
	{
		public static Mesh ToMesh(Polygon polygon, IList<ITriangle> triangles)
		{
			return null;
		}

		public static Mesh ToMesh(Polygon polygon, ITriangle[] triangles)
		{
			return null;
		}

		private static List<Otri>[] SetNeighbors(Mesh mesh, ITriangle[] triangles)
		{
			return null;
		}

		private static void SetSegments(Mesh mesh, Polygon polygon, List<Otri>[] vertexarray)
		{
		}

		public static DcelMesh ToDCEL(Mesh mesh)
		{
			return null;
		}
	}
}
