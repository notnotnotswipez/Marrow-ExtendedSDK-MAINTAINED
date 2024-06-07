using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing.Algorithm
{
	public class Incremental : ITriangulator
	{
		private Mesh mesh;

		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		private void GetBoundingBox()
		{
		}

		private int RemoveBox()
		{
			return 0;
		}
	}
}
