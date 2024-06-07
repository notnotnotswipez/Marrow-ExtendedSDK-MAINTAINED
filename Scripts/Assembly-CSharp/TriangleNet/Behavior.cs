using System;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet
{
	internal class Behavior
	{
		private bool poly;

		private bool quality;

		private bool varArea;

		private bool convex;

		private bool jettison;

		private bool boundaryMarkers;

		private bool noHoles;

		private bool conformDel;

		private Func<ITriangle, double, bool> usertest;

		private int noBisect;

		private double minAngle;

		private double maxAngle;

		private double maxArea;

		internal bool fixedArea;

		internal bool useSegments;

		internal bool useRegions;

		internal double goodAngle;

		internal double maxGoodAngle;

		internal double offconstant;

		public static bool NoExact
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Quality
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double MinAngle
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double MaxAngle
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double MaxArea
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool VarArea
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Poly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Func<ITriangle, double, bool> UserTest
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Convex
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ConformingDelaunay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int NoBisect
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool UseBoundaryMarkers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool NoHoles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Jettison
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Behavior(bool quality = false, double minAngle = 20.0)
		{
		}

		private void Update()
		{
		}
	}
}
