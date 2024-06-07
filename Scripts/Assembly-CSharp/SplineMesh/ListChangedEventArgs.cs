using System;
using System.Collections.Generic;

namespace SplineMesh
{
	public class ListChangedEventArgs<T> : EventArgs
	{
		public ListChangeType type;

		public List<T> newItems;

		public List<T> removedItems;

		public int insertIndex;

		public int removeIndex;
	}
}
