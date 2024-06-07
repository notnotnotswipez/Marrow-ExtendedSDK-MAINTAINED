using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public struct Otri
	{
		internal Triangle tri;

		internal int orient;

		private static readonly int[] plus1Mod3;

		private static readonly int[] minus1Mod3;

		public Triangle Triangle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public void Sym(ref Otri ot)
		{
		}

		public void Sym()
		{
		}

		public void Lnext(ref Otri ot)
		{
		}

		public void Lnext()
		{
		}

		public void Lprev(ref Otri ot)
		{
		}

		public void Lprev()
		{
		}

		public void Onext(ref Otri ot)
		{
		}

		public void Onext()
		{
		}

		public void Oprev(ref Otri ot)
		{
		}

		public void Oprev()
		{
		}

		public void Dnext(ref Otri ot)
		{
		}

		public void Dnext()
		{
		}

		public void Dprev(ref Otri ot)
		{
		}

		public void Dprev()
		{
		}

		public void Rnext(ref Otri ot)
		{
		}

		public void Rnext()
		{
		}

		public void Rprev(ref Otri ot)
		{
		}

		public void Rprev()
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

		public Vertex Apex()
		{
			return null;
		}

		public void Copy(ref Otri ot)
		{
		}

		public bool Equals(Otri ot)
		{
			return false;
		}

		internal void SetOrg(Vertex v)
		{
		}

		internal void SetDest(Vertex v)
		{
		}

		internal void SetApex(Vertex v)
		{
		}

		internal void Bond(ref Otri ot)
		{
		}

		internal void Dissolve(Triangle dummy)
		{
		}

		internal void Infect()
		{
		}

		internal void Uninfect()
		{
		}

		internal bool IsInfected()
		{
			return false;
		}

		internal void Pivot(ref Osub os)
		{
		}

		internal void SegBond(ref Osub os)
		{
		}

		internal void SegDissolve(SubSegment dummy)
		{
		}

		internal static bool IsDead(Triangle tria)
		{
			return false;
		}

		internal static void Kill(Triangle tri)
		{
		}
	}
}
