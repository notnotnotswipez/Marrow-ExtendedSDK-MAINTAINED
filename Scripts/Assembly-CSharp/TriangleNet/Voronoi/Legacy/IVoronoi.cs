using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	public interface IVoronoi
	{
		Point[] Points { get; }

		ICollection<VoronoiRegion> Regions { get; }

		IEnumerable<IEdge> Edges { get; }
	}
}
