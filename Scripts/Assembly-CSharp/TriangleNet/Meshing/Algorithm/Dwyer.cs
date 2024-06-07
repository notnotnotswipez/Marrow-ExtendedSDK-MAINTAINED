using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Algorithm
{
	public class Dwyer : ITriangulator
	{
		private IPredicates predicates;

		public bool UseDwyer;

		private Vertex[] sortarray;

		private Mesh mesh;

		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		private void MergeHulls(ref Otri farleft, ref Otri innerleft, ref Otri innerright, ref Otri farright, int axis)
		{
		}

		private void DivconqRecurse(int left, int right, int axis, ref Otri farleft, ref Otri farright)
		{
		}

		private int RemoveGhosts(ref Otri startghost)
		{
			return 0;
		}
	}
}
