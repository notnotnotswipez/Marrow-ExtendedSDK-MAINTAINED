using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class TriangleLocator
	{
		private TriangleSampler sampler;

		private Mesh mesh;

		private IPredicates predicates;

		internal Otri recenttri;

		public TriangleLocator(Mesh mesh)
		{
		}

		public TriangleLocator(Mesh mesh, IPredicates predicates)
		{
		}

		public void Update(ref Otri otri)
		{
		}

		public void Reset()
		{
		}

		public LocateResult PreciseLocate(Point searchpoint, ref Otri searchtri, bool stopatsubsegment)
		{
			return default(LocateResult);
		}

		public LocateResult Locate(Point searchpoint, ref Otri searchtri)
		{
			return default(LocateResult);
		}
	}
}
