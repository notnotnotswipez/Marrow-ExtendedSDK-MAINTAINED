using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class TrianglePool : ICollection<Triangle>, IEnumerable<Triangle>, IEnumerable
	{
		private class Enumerator : IEnumerator<Triangle>, IEnumerator, IDisposable
		{
			private int count;

			private Triangle[][] pool;

			private Triangle current;

			private int index;

			private int offset;

			public Triangle Current => null;

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

            object IEnumerator.Current => throw new NotImplementedException();

            public Enumerator(TrianglePool pool)
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

		[CompilerGenerated]
		private sealed class _003CSample_003Ed__9 : IEnumerable<Triangle>, IEnumerable, IEnumerator<Triangle>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Triangle _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public TrianglePool _003C_003E4__this;

			private int k;

			public int _003C_003E3__k;

			private Random random;

			public Random _003C_003E3__random;

			private int _003Ccount_003E5__2;

			private Triangle System_002ECollections_002EGeneric_002EIEnumerator_003CTriangleNet_002ETopology_002ETriangle_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public Triangle Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CSample_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Triangle> System_002ECollections_002EGeneric_002EIEnumerable_003CTriangleNet_002ETopology_002ETriangle_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

            public IEnumerator<Triangle> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private const int BLOCKSIZE = 1024;

		private int size;

		private int count;

		private Triangle[][] pool;

		private Stack<Triangle> stack;

		public int Count => 0;

		public bool IsReadOnly => false;

		public Triangle Get()
		{
			return null;
		}

		public void Release(Triangle triangle)
		{
		}

		public TrianglePool Restart()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSample_003Ed__9))]
		internal IEnumerable<Triangle> Sample(int k, Random random)
		{
			return null;
		}

		private void Cleanup(Triangle triangle)
		{
		}

		public void Add(Triangle item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Triangle item)
		{
			return false;
		}

		public void CopyTo(Triangle[] array, int index)
		{
		}

		public bool Remove(Triangle item)
		{
			return false;
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
