using System;
using System.Collections;
using System.Collections.Generic;
using TriangleNet.Topology;

namespace TriangleNet
{
	internal class TriangleSampler : IEnumerable<Triangle>, IEnumerable
	{
		private const int RANDOM_SEED = 110503;

		private const int samplefactor = 11;

		private Random random;

		private Mesh mesh;

		private int samples;

		private int triangleCount;

		public TriangleSampler(Mesh mesh)
		{
		}

		public TriangleSampler(Mesh mesh, Random random)
		{
		}

		public void Reset()
		{
		}

		public void Update()
		{
		}

		public IEnumerator<Triangle> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
