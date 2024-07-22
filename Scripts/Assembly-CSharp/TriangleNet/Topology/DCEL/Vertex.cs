using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class Vertex : Point
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateEdges_003Ed__6 : IEnumerable<HalfEdge>, IEnumerable, IEnumerator<HalfEdge>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private HalfEdge _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Vertex _003C_003E4__this;

			private HalfEdge _003Cedge_003E5__2;

			private int _003Cfirst_003E5__3;

			private HalfEdge System_002ECollections_002EGeneric_002EIEnumerator_003CTriangleNet_002ETopology_002EDCEL_002EHalfEdge_003E_002ECurrent
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

            public HalfEdge Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CEnumerateEdges_003Ed__6(int _003C_003E1__state)
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
			private IEnumerator<HalfEdge> System_002ECollections_002EGeneric_002EIEnumerable_003CTriangleNet_002ETopology_002EDCEL_002EHalfEdge_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

            public IEnumerator<HalfEdge> GetEnumerator()
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

		internal HalfEdge leaving;

		public HalfEdge Leaving
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vertex(double x, double y)
		{
		}

		public Vertex(double x, double y, HalfEdge leaving)
		{
		}

		[IteratorStateMachine(typeof(_003CEnumerateEdges_003Ed__6))]
		public IEnumerable<HalfEdge> EnumerateEdges()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
