using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Logging;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	internal class ConstraintMesher
	{
		private IPredicates predicates;

		private Mesh mesh;

		private Behavior behavior;

		private TriangleLocator locator;

		private List<Triangle> viri;

		private ILog<LogItem> logger;

		public ConstraintMesher(Mesh mesh, Configuration config)
		{
		}

		public void Apply(IPolygon input, ConstraintOptions options)
		{
		}

		private void CarveHoles()
		{
		}

		private void FormSkeleton(IPolygon input)
		{
		}

		private void InfectHull()
		{
		}

		private void Plague()
		{
		}

		private FindDirectionResult FindDirection(ref Otri searchtri, Vertex searchpoint)
		{
			return default(FindDirectionResult);
		}

		private void SegmentIntersection(ref Otri splittri, ref Osub splitsubseg, Vertex endpoint2)
		{
		}

		private bool ScoutSegment(ref Otri searchtri, Vertex endpoint2, int newmark)
		{
			return false;
		}

		private void DelaunayFixup(ref Otri fixuptri, bool leftside)
		{
		}

		private void ConstrainedEdge(ref Otri starttri, Vertex endpoint2, int newmark)
		{
		}

		private void InsertSegment(Vertex endpoint1, Vertex endpoint2, int newmark)
		{
		}

		private void MarkHull()
		{
		}
	}
}
