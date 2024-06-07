using System.IO;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	public interface IMeshFormat : IFileFormat
	{
		IMesh Import(string filename);

		void Write(IMesh mesh, string filename);

		void Write(IMesh mesh, Stream stream);
	}
}
