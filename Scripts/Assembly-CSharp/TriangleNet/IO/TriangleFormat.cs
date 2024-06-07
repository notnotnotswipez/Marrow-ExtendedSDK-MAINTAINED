using System.IO;
using TriangleNet.Geometry;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	public class TriangleFormat : IPolygonFormat, IFileFormat, IMeshFormat
	{
		public bool IsSupported(string file)
		{
			return false;
		}

		public IMesh Import(string filename)
		{
			return null;
		}

		public void Write(IMesh mesh, string filename)
		{
		}

		public void Write(IMesh mesh, Stream stream)
		{
		}

		public IPolygon Read(string filename)
		{
			return null;
		}

		public void Write(IPolygon polygon, string filename)
		{
		}

		public void Write(IPolygon polygon, Stream stream)
		{
		}
	}
}
