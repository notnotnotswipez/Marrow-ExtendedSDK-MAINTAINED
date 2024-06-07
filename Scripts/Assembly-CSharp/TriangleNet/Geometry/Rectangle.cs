using System.Collections.Generic;

namespace TriangleNet.Geometry
{
	public class Rectangle
	{
		private double xmin;

		private double ymin;

		private double xmax;

		private double ymax;

		public double Left => 0.0;

		public double Right => 0.0;

		public double Bottom => 0.0;

		public double Top => 0.0;

		public double Width => 0.0;

		public double Height => 0.0;

		public Rectangle()
		{
		}

		public Rectangle(Rectangle other)
		{
		}

		public Rectangle(double x, double y, double width, double height)
		{
		}

		public void Resize(double dx, double dy)
		{
		}

		public void Expand(Point p)
		{
		}

		public void Expand(IEnumerable<Point> points)
		{
		}

		public void Expand(Rectangle other)
		{
		}

		public bool Contains(double x, double y)
		{
			return false;
		}

		public bool Contains(Point pt)
		{
			return false;
		}

		public bool Contains(Rectangle other)
		{
			return false;
		}

		public bool Intersects(Rectangle other)
		{
			return false;
		}
	}
}
