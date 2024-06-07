using System;
using System.Collections.Generic;

namespace TriangleNet.Geometry
{
	public interface IPolygon
	{
		List<Vertex> Points { get; }

		List<ISegment> Segments { get; }

		List<Point> Holes { get; }

		List<RegionPointer> Regions { get; }

		bool HasPointMarkers { get; set; }

		bool HasSegmentMarkers { get; set; }

		[Obsolete("Use polygon.Add(contour) method instead.")]
		void AddContour(IEnumerable<Vertex> points, int marker, bool hole, bool convex);

		[Obsolete("Use polygon.Add(contour) method instead.")]
		void AddContour(IEnumerable<Vertex> points, int marker, Point hole);

		Rectangle Bounds();

		void Add(Vertex vertex);

		void Add(ISegment segment, bool insert = false);

		void Add(ISegment segment, int index);

		void Add(Contour contour, bool hole = false);

		void Add(Contour contour, Point hole);
	}
}
