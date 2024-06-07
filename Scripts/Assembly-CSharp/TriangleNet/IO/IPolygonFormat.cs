using System.IO;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public interface IPolygonFormat : IFileFormat
	{
		IPolygon Read(string filename);

		void Write(IPolygon polygon, string filename);

		void Write(IPolygon polygon, Stream stream);
	}
}
