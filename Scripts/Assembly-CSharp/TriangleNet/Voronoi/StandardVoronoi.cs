using TriangleNet.Geometry;

namespace TriangleNet.Voronoi
{
	public class StandardVoronoi : VoronoiBase
	{
		public StandardVoronoi(Mesh mesh)
			: base(null, null, null, generate: false)
		{
		}

		public StandardVoronoi(Mesh mesh, Rectangle box)
			: base(null, null, null, generate: false)
		{
		}

		public StandardVoronoi(Mesh mesh, Rectangle box, IVoronoiFactory factory, IPredicates predicates)
			: base(null, null, null, generate: false)
		{
		}

		private void PostProcess(Rectangle box)
		{
		}
	}
}
