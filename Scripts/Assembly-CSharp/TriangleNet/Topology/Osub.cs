using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public struct Osub
	{
		internal SubSegment seg;

		internal int orient;

		public SubSegment Segment => null;

		public override string ToString()
		{
			return null;
		}

		public void Sym(ref Osub os)
		{
		}

		public void Sym()
		{
		}

		public void Pivot(ref Osub os)
		{
		}

		internal void Pivot(ref Otri ot)
		{
		}

		public void Next(ref Osub ot)
		{
		}

		public void Next()
		{
		}

		public Vertex Org()
		{
			return null;
		}

		public Vertex Dest()
		{
			return null;
		}

		internal void SetOrg(Vertex vertex)
		{
		}

		internal void SetDest(Vertex vertex)
		{
		}

		internal Vertex SegOrg()
		{
			return null;
		}

		internal Vertex SegDest()
		{
			return null;
		}

		internal void SetSegOrg(Vertex vertex)
		{
		}

		internal void SetSegDest(Vertex vertex)
		{
		}

		internal void Bond(ref Osub os)
		{
		}

		internal void Dissolve(SubSegment dummy)
		{
		}

		internal bool Equal(Osub os)
		{
			return false;
		}

		internal void TriDissolve(Triangle dummy)
		{
		}

		internal static bool IsDead(SubSegment sub)
		{
			return false;
		}

		internal static void Kill(SubSegment sub)
		{
		}
	}
}
