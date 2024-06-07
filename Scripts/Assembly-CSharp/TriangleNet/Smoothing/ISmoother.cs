using TriangleNet.Meshing;

namespace TriangleNet.Smoothing
{
	public interface ISmoother
	{
		void Smooth(IMesh mesh);

		void Smooth(IMesh mesh, int limit);
	}
}
