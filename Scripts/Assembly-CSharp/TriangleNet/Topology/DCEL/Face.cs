using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class Face
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateEdges_003Ed__17 : IEnumerable<HalfEdge>, IEnumerable, IEnumerator<HalfEdge>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private HalfEdge _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Face _003C_003E4__this;

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
			public _003CEnumerateEdges_003Ed__17(int _003C_003E1__state)
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

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator<HalfEdge> IEnumerable<HalfEdge>.GetEnumerator()
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

		public static readonly Face Empty;

		internal int id;

		internal Point generator;

		internal HalfEdge edge;

		internal bool bounded;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public HalfEdge Edge
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Bounded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static Face()
		{
		}

		public Face(Point generator)
		{
		}

		public Face(Point generator, HalfEdge edge)
		{
		}

		[IteratorStateMachine(typeof(_003CEnumerateEdges_003Ed__17))]
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
