using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	public class VertexCirculator
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateVertices_003Ed__2 : IEnumerable<Vertex>, IEnumerable, IEnumerator<Vertex>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Vertex _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VertexCirculator _003C_003E4__this;

			private Vertex vertex;

			public Vertex _003C_003E3__vertex;

			private List<Otri>.Enumerator _003C_003E7__wrap1;

			private Vertex System_002ECollections_002EGeneric_002EIEnumerator_003CTriangleNet_002EGeometry_002EVertex_003E_002ECurrent
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

            public Vertex Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CEnumerateVertices_003Ed__2(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Vertex> System_002ECollections_002EGeneric_002EIEnumerable_003CTriangleNet_002EGeometry_002EVertex_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

            public IEnumerator<Vertex> GetEnumerator()
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

		[CompilerGenerated]
		private sealed class _003CEnumerateTriangles_003Ed__3 : IEnumerable<ITriangle>, IEnumerable, IEnumerator<ITriangle>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private ITriangle _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VertexCirculator _003C_003E4__this;

			private Vertex vertex;

			public Vertex _003C_003E3__vertex;

			private List<Otri>.Enumerator _003C_003E7__wrap1;

			private ITriangle System_002ECollections_002EGeneric_002EIEnumerator_003CTriangleNet_002EGeometry_002EITriangle_003E_002ECurrent
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

            public ITriangle Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CEnumerateTriangles_003Ed__3(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<ITriangle> System_002ECollections_002EGeneric_002EIEnumerable_003CTriangleNet_002EGeometry_002EITriangle_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

            public IEnumerator<ITriangle> GetEnumerator()
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

		private List<Otri> cache;

		public VertexCirculator(Mesh mesh)
		{
		}

		[IteratorStateMachine(typeof(_003CEnumerateVertices_003Ed__2))]
		public IEnumerable<Vertex> EnumerateVertices(Vertex vertex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEnumerateTriangles_003Ed__3))]
		public IEnumerable<ITriangle> EnumerateTriangles(Vertex vertex)
		{
			return null;
		}

		private void BuildCache(Vertex vertex, bool vertices)
		{
		}
	}
}
