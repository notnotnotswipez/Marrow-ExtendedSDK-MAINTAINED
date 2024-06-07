using System.Globalization;
using System.IO;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	internal class DebugWriter
	{
		private static NumberFormatInfo nfi;

		private int iteration;

		private string session;

		private StreamWriter stream;

		private string tmpFile;

		private int[] vertices;

		private int triangles;

		private static readonly DebugWriter instance;

		public static DebugWriter Session => null;

		static DebugWriter()
		{
		}

		private DebugWriter()
		{
		}

		public void Start(string session)
		{
		}

		public void Write(Mesh mesh, bool skip = false)
		{
		}

		public void Finish()
		{
		}

		private void Finish(string path)
		{
		}

		private void WriteGeometry(IPolygon geometry)
		{
		}

		private void WriteMesh(Mesh mesh, bool skip)
		{
		}

		private bool VerticesChanged(Mesh mesh)
		{
			return false;
		}

		private void HashVertices(Mesh mesh)
		{
		}
	}
}
