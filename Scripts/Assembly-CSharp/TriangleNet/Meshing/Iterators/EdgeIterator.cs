using System;
using System.Collections;
using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	public class EdgeIterator : IEnumerator<Edge>, IEnumerator, IDisposable
	{
		private IEnumerator<Triangle> triangles;

		private Otri tri;

		private Otri neighbor;

		private Osub sub;

		private Edge current;

		private Vertex p1;

		private Vertex p2;

		public Edge Current => null;

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

        object IEnumerator.Current => throw new NotImplementedException();

        public EdgeIterator(Mesh mesh)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}
}
