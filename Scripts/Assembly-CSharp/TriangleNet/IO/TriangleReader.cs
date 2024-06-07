using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public class TriangleReader
	{
		private static NumberFormatInfo nfi;

		private int startIndex;

		public static bool IsNullOrWhiteSpace(string value)
		{
			return false;
		}

		private bool TryReadLine(StreamReader reader, out string[] token)
		{
			token = null;
			return false;
		}

		private void ReadVertex(List<Vertex> data, int index, string[] line, int attributes, int marks)
		{
		}

		public void Read(string filename, out Polygon polygon)
		{
			polygon = null;
		}

		public void Read(string filename, out Polygon geometry, out List<ITriangle> triangles)
		{
			geometry = null;
			triangles = null;
		}

		public IPolygon Read(string filename)
		{
			return null;
		}

		public Polygon ReadNodeFile(string nodefilename)
		{
			return null;
		}

		public Polygon ReadNodeFile(string nodefilename, bool readElements)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename, bool readElements)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename, bool readElements, bool readArea)
		{
			return null;
		}

		public List<ITriangle> ReadEleFile(string elefilename)
		{
			return null;
		}

		private List<ITriangle> ReadEleFile(string elefilename, bool readArea)
		{
			return null;
		}

		private double[] ReadAreaFile(string areafilename, int intriangles)
		{
			return null;
		}

		public List<Edge> ReadEdgeFile(string edgeFile, int invertices)
		{
			return null;
		}
	}
}
