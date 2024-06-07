using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public class TriangleWriter
	{
		private static NumberFormatInfo nfi;

		public void Write(Mesh mesh, string filename)
		{
		}

		public void WriteNodes(Mesh mesh, string filename)
		{
		}

		private void WriteNodes(StreamWriter writer, Mesh mesh)
		{
		}

		private void WriteNodes(StreamWriter writer, IEnumerable<Vertex> nodes, bool markers, int attribs, bool jettison)
		{
		}

		public void WriteElements(Mesh mesh, string filename)
		{
		}

		public void WritePoly(IPolygon polygon, string filename)
		{
		}

		public void WritePoly(Mesh mesh, string filename)
		{
		}

		public void WritePoly(Mesh mesh, string filename, bool writeNodes)
		{
		}

		public void WriteEdges(Mesh mesh, string filename)
		{
		}

		public void WriteNeighbors(Mesh mesh, string filename)
		{
		}
	}
}
