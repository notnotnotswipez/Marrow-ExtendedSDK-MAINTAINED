using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;
using TriangleNet.Logging;
using TriangleNet.Meshing;
using TriangleNet.Meshing.Iterators;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class Mesh : IMesh
	{
		[CompilerGenerated]
		private sealed class _003Cget_Edges_003Ed__39 : IEnumerable<Edge>, IEnumerable, IEnumerator<Edge>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Edge _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Mesh _003C_003E4__this;

			private EdgeIterator _003Ce_003E5__2;

			private Edge System_002ECollections_002EGeneric_002EIEnumerator_003CTriangleNet_002EGeometry_002EEdge_003E_002ECurrent
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

            public Edge Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003Cget_Edges_003Ed__39(int _003C_003E1__state)
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
			private IEnumerator<Edge> System_002ECollections_002EGeneric_002EIEnumerable_003CTriangleNet_002EGeometry_002EEdge_003E_002EGetEnumerator()
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

            IEnumerator<Edge> IEnumerable<Edge>.GetEnumerator()
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

		private IPredicates predicates;

		private ILog<LogItem> logger;

		private QualityMesher qualityMesher;

		private Stack<Otri> flipstack;

		internal TrianglePool triangles;

		internal Dictionary<int, SubSegment> subsegs;

		internal Dictionary<int, Vertex> vertices;

		internal int hash_vtx;

		internal int hash_seg;

		internal int hash_tri;

		internal List<Point> holes;

		internal List<RegionPointer> regions;

		internal Rectangle bounds;

		internal int invertices;

		internal int insegments;

		internal int undeads;

		internal int mesh_dim;

		internal int nextras;

		internal int hullsize;

		internal int steinerleft;

		internal bool checksegments;

		internal bool checkquality;

		internal Vertex infvertex1;

		internal Vertex infvertex2;

		internal Vertex infvertex3;

		internal TriangleLocator locator;

		internal Behavior behavior;

		internal NodeNumbering numbering;

		internal const int DUMMY = -1;

		internal Triangle dummytri;

		internal SubSegment dummysub;

		public Rectangle Bounds => null;

		public ICollection<Vertex> Vertices => null;

		public IList<Point> Holes => null;

		public ICollection<Triangle> Triangles => null;

		public ICollection<SubSegment> Segments => null;

		public IEnumerable<Edge> Edges
		{
			[IteratorStateMachine(typeof(_003Cget_Edges_003Ed__39))]
			get
			{
				return null;
			}
		}

		public int NumberOfInputPoints => 0;

		public int NumberOfEdges => 0;

		public bool IsPolygon => false;

		public NodeNumbering CurrentNumbering => default(NodeNumbering);

		private void Initialize()
		{
		}

		public Mesh(Configuration config)
		{
		}

		public void Refine(QualityOptions quality, bool delaunay = false)
		{
		}

		public void Renumber()
		{
		}

		public void Renumber(NodeNumbering num)
		{
		}

		internal void SetQualityMesher(QualityMesher qmesher)
		{
		}

		internal void CopyTo(Mesh target)
		{
		}

		private void ResetData()
		{
		}

		private void Reset()
		{
		}

		internal void TransferNodes(IList<Vertex> points)
		{
		}

		internal void MakeVertexMap()
		{
		}

		internal void MakeTriangle(ref Otri newotri)
		{
		}

		internal void MakeSegment(ref Osub newsubseg)
		{
		}

		internal InsertVertexResult InsertVertex(Vertex newvertex, ref Otri searchtri, ref Osub splitseg, bool segmentflaws, bool triflaws)
		{
			return default(InsertVertexResult);
		}

		internal void InsertSubseg(ref Otri tri, int subsegmark)
		{
		}

		internal void Flip(ref Otri flipedge)
		{
		}

		internal void Unflip(ref Otri flipedge)
		{
		}

		private void TriangulatePolygon(Otri firstedge, Otri lastedge, int edgecount, bool doflip, bool triflaws)
		{
		}

		internal void DeleteVertex(ref Otri deltri)
		{
		}

		internal void UndoVertex()
		{
		}

		internal void TriangleDealloc(Triangle dyingtriangle)
		{
		}

		internal void VertexDealloc(Vertex dyingvertex)
		{
		}

		internal void SubsegDealloc(SubSegment dyingsubseg)
		{
		}
	}
}
