using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TriangleNet.Geometry
{
	public class Polygon : IPolygon
	{
		private List<Vertex> points;

		private List<Point> holes;

		private List<RegionPointer> regions;

		private List<ISegment> segments;

		public List<Vertex> Points => null;

		public List<Point> Holes => null;

		public List<RegionPointer> Regions => null;

		public List<ISegment> Segments => null;

		public bool HasPointMarkers
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

		public bool HasSegmentMarkers
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

		public int Count => 0;

		public Polygon()
		{
		}

		public Polygon(int capacity)
		{
		}

		public Polygon(int capacity, bool markers)
		{
		}

		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker = 0, bool hole = false, bool convex = false)
		{
		}

		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker, Point hole)
		{
		}

		public Rectangle Bounds()
		{
			return null;
		}

		public void Add(Vertex vertex)
		{
		}

		public void Add(ISegment segment, bool insert = false)
		{
		}

		public void Add(ISegment segment, int index)
		{
		}

		public void Add(Contour contour, bool hole = false)
		{
		}

		public void Add(Contour contour, Point hole)
		{
		}
	}
}
