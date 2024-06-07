using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Meshing;

namespace TriangleNet.IO
{
	public static class FileProcessor
	{
		private static List<IFileFormat> formats;

		static FileProcessor()
		{
		}

		public static void Add(IFileFormat format)
		{
		}

		public static bool IsSupported(string file)
		{
			return false;
		}

		public static IPolygon Read(string filename)
		{
			return null;
		}

		public static void Write(IPolygon polygon, string filename)
		{
		}

		public static IMesh Import(string filename)
		{
			return null;
		}

		public static void Write(IMesh mesh, string filename)
		{
		}
	}
}
