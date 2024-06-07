using System;

namespace TriangleNet.Geometry
{
	public class Point : IComparable<Point>, IEquatable<Point>
	{
		internal int id;

		internal int label;

		internal double x;

		internal double y;

		internal double z;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double X
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Y
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Z
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public int Label
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Point()
		{
		}

		public Point(double x, double y)
		{
		}

		public Point(double x, double y, int label)
		{
		}

		public static bool operator ==(Point a, Point b)
		{
			return false;
		}

		public static bool operator !=(Point a, Point b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Point p)
		{
			return false;
		}

		public int CompareTo(Point other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
