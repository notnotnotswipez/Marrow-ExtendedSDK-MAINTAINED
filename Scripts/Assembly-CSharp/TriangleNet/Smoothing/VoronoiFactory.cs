using TriangleNet.Geometry;
using TriangleNet.Topology.DCEL;
using TriangleNet.Voronoi;

namespace TriangleNet.Smoothing
{
	internal class VoronoiFactory : IVoronoiFactory
	{
		private class ObjectPool<T> where T : class
		{
			private int index;

			private int count;

			private T[] pool;

			public int Count => 0;

			public int Capacity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public ObjectPool(int capacity = 3)
			{
			}

			public ObjectPool(T[] pool)
			{
			}

			public bool TryGet(out T obj)
			{
				obj = null;
				return false;
			}

			public void Put(T obj)
			{
			}

			public void Release()
			{
			}

			private void Resize(int size)
			{
			}
		}

		private ObjectPool<TriangleNet.Topology.DCEL.Vertex> vertices;

		private ObjectPool<HalfEdge> edges;

		private ObjectPool<Face> faces;

		public void Initialize(int vertexCount, int edgeCount, int faceCount)
		{
		}

		public void Reset()
		{
		}

		public TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y)
		{
			return null;
		}

		public HalfEdge CreateHalfEdge(TriangleNet.Topology.DCEL.Vertex origin, Face face)
		{
			return null;
		}

		public Face CreateFace(TriangleNet.Geometry.Vertex vertex)
		{
			return null;
		}
	}
}
