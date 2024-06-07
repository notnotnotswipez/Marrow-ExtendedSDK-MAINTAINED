using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	internal class NewLocation
	{
		private const double EPS = 1E-50;

		private IPredicates predicates;

		private Mesh mesh;

		private Behavior behavior;

		private double[] petalx;

		private double[] petaly;

		private double[] petalr;

		private double[] wedges;

		private double[] initialConvexPoly;

		private double[] points_p;

		private double[] points_q;

		private double[] points_r;

		private double[] poly1;

		private double[] poly2;

		private double[][] polys;

		public NewLocation(Mesh mesh, IPredicates predicates)
		{
		}

		public Point FindLocation(Vertex org, Vertex dest, Vertex apex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private Point FindNewLocationWithoutMaxAngle(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private Point FindNewLocation(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private int LongestShortestEdge(double aodist, double dadist, double dodist)
		{
			return 0;
		}

		private int DoSmoothing(Otri badotri, Vertex torg, Vertex tdest, Vertex tapex, ref double[] newloc)
		{
			return 0;
		}

		private int GetStarPoints(Otri badotri, Vertex p, Vertex q, Vertex r, int whichPoint, ref double[] points)
		{
			return 0;
		}

		private bool GetNeighborsVertex(Otri badotri, double first_x, double first_y, double second_x, double second_y, ref double[] thirdpoint, ref Otri neighotri)
		{
			return false;
		}

		private bool GetWedgeIntersectionWithoutMaxAngle(int numpoints, double[] points, ref double[] newloc)
		{
			return false;
		}

		private bool GetWedgeIntersection(int numpoints, double[] points, ref double[] newloc)
		{
			return false;
		}

		private bool ValidPolygonAngles(int numpoints, double[] points)
		{
			return false;
		}

		private bool IsBadPolygonAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return false;
		}

		private void LineLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
		}

		private int HalfPlaneIntersection(int numvertices, ref double[] convexPoly, double x1, double y1, double x2, double y2)
		{
			return 0;
		}

		private int SplitConvexPolygon(int numvertices, double[] convexPoly, double x1, double y1, double x2, double y2, double[][] polys)
		{
			return 0;
		}

		private int LinePointLocation(double x1, double y1, double x2, double y2, double x, double y)
		{
			return 0;
		}

		private void LineLineSegmentIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
		}

		private void FindPolyCentroid(int numpoints, double[] points, ref double[] centroid)
		{
		}

		private void CircleLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double r, ref double[] p)
		{
		}

		private bool ChooseCorrectPoint(double x1, double y1, double x2, double y2, double x3, double y3, bool isObtuse)
		{
			return false;
		}

		private void PointBetweenPoints(double x1, double y1, double x2, double y2, double x, double y, ref double[] p)
		{
		}

		private bool IsBadTriangleAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return false;
		}

		private double MinDistanceToNeighbor(double newlocX, double newlocY, ref Otri searchtri)
		{
			return 0.0;
		}
	}
}
