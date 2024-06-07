using TriangleNet.Geometry;
using TriangleNet.Meshing;
using TriangleNet.Topology.DCEL;
using TriangleNet.Voronoi;

namespace TriangleNet.Smoothing
{
	public class SimpleSmoother : ISmoother
	{
		private TrianglePool pool;

		private Configuration config;

		private IVoronoiFactory factory;

		private ConstraintOptions options;

		public SimpleSmoother()
		{
		}

		public SimpleSmoother(IVoronoiFactory factory)
		{
		}

		public SimpleSmoother(IVoronoiFactory factory, Configuration config)
		{
		}

		public void Smooth(IMesh mesh)
		{
		}

		public void Smooth(IMesh mesh, int limit)
		{
		}

		private void Step(Mesh mesh, IVoronoiFactory factory, IPredicates predicates)
		{
		}

		private void Centroid(Face face, out double x, out double y)
		{
			x = default(double);
			y = default(double);
		}

		private Polygon Rebuild(Mesh mesh)
		{
			return null;
		}
	}
}
