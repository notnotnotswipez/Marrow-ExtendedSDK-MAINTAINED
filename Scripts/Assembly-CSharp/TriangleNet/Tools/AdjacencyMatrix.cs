namespace TriangleNet.Tools
{
	public class AdjacencyMatrix
	{
		private int nnz;

		private int[] pcol;

		private int[] irow;

		public readonly int N;

		public int[] ColumnPointers => null;

		public int[] RowIndices => null;

		public AdjacencyMatrix(Mesh mesh)
		{
		}

		public AdjacencyMatrix(int[] pcol, int[] irow)
		{
		}

		public int Bandwidth()
		{
			return 0;
		}

		private int[] AdjacencyCount(Mesh mesh)
		{
			return null;
		}

		private int[] AdjacencySet(Mesh mesh, int[] pcol)
		{
			return null;
		}

		public void SortIndices()
		{
		}
	}
}
