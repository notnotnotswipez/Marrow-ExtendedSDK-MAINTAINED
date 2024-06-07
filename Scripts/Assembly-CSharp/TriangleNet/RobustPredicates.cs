using TriangleNet.Geometry;

namespace TriangleNet
{
	public class RobustPredicates : IPredicates
	{
		private static readonly object creationLock;

		private static RobustPredicates _default;

		private static double epsilon;

		private static double splitter;

		private static double resulterrbound;

		private static double ccwerrboundA;

		private static double ccwerrboundB;

		private static double ccwerrboundC;

		private static double iccerrboundA;

		private static double iccerrboundB;

		private static double iccerrboundC;

		private double[] fin1;

		private double[] fin2;

		private double[] abdet;

		private double[] axbc;

		private double[] axxbc;

		private double[] aybc;

		private double[] ayybc;

		private double[] adet;

		private double[] bxca;

		private double[] bxxca;

		private double[] byca;

		private double[] byyca;

		private double[] bdet;

		private double[] cxab;

		private double[] cxxab;

		private double[] cyab;

		private double[] cyyab;

		private double[] cdet;

		private double[] temp8;

		private double[] temp16a;

		private double[] temp16b;

		private double[] temp16c;

		private double[] temp32a;

		private double[] temp32b;

		private double[] temp48;

		private double[] temp64;

		public static RobustPredicates Default => null;

		static RobustPredicates()
		{
		}

		public double CounterClockwise(Point pa, Point pb, Point pc)
		{
			return 0.0;
		}

		public double InCircle(Point pa, Point pb, Point pc, Point pd)
		{
			return 0.0;
		}

		public double NonRegular(Point pa, Point pb, Point pc, Point pd)
		{
			return 0.0;
		}

		public Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta, double offconstant)
		{
			return null;
		}

		public Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta)
		{
			return null;
		}

		private int FastExpansionSumZeroElim(int elen, double[] e, int flen, double[] f, double[] h)
		{
			return 0;
		}

		private int ScaleExpansionZeroElim(int elen, double[] e, double b, double[] h)
		{
			return 0;
		}

		private double Estimate(int elen, double[] e)
		{
			return 0.0;
		}

		private double CounterClockwiseAdapt(Point pa, Point pb, Point pc, double detsum)
		{
			return 0.0;
		}

		private double InCircleAdapt(Point pa, Point pb, Point pc, Point pd, double permanent)
		{
			return 0.0;
		}

		private void AllocateWorkspace()
		{
		}

		private void ClearWorkspace()
		{
		}
	}
}
