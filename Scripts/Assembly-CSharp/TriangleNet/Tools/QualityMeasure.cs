using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	public class QualityMeasure
	{
		private class AreaMeasure
		{
			public double area_min;

			public double area_max;

			public double area_total;

			public int area_zero;

			public void Reset()
			{
			}

			public double Measure(Point a, Point b, Point c)
			{
				return 0.0;
			}
		}

		private class AlphaMeasure
		{
			public double alpha_min;

			public double alpha_max;

			public double alpha_ave;

			public double alpha_area;

			public void Reset()
			{
			}

			private double acos(double c)
			{
				return 0.0;
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				return 0.0;
			}

			public void Normalize(int n, double area_total)
			{
			}
		}

		private class Q_Measure
		{
			public double q_min;

			public double q_max;

			public double q_ave;

			public double q_area;

			public void Reset()
			{
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				return 0.0;
			}

			public void Normalize(int n, double area_total)
			{
			}
		}

		private AreaMeasure areaMeasure;

		private AlphaMeasure alphaMeasure;

		private Q_Measure qMeasure;

		private Mesh mesh;

		public double AreaMinimum => 0.0;

		public double AreaMaximum => 0.0;

		public double AreaRatio => 0.0;

		public double AlphaMinimum => 0.0;

		public double AlphaMaximum => 0.0;

		public double AlphaAverage => 0.0;

		public double AlphaArea => 0.0;

		public double Q_Minimum => 0.0;

		public double Q_Maximum => 0.0;

		public double Q_Average => 0.0;

		public double Q_Area => 0.0;

		public void Update(Mesh mesh)
		{
		}

		private void Compute()
		{
		}

		public int Bandwidth()
		{
			return 0;
		}
	}
}
