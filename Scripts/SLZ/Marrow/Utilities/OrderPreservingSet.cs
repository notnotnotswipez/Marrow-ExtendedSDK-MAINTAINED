using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000117 RID: 279
	public class OrderPreservingSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x0000431E File Offset: 0x0000251E
		public OrderPreservingSet(IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00004326 File Offset: 0x00002526
		public OrderPreservingSet()
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0000432E File Offset: 0x0000252E
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00004331 File Offset: 0x00002531
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000077D4 File Offset: 0x000059D4
		public T Item
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00004334 File Offset: 0x00002534
		public void Add(T item)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00004336 File Offset: 0x00002536
		public void Clear()
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00004338 File Offset: 0x00002538
		public bool Contains(T item)
		{
			return false;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0000433B File Offset: 0x0000253B
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000433D File Offset: 0x0000253D
		public bool Remove(T item)
		{
			return false;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00004340 File Offset: 0x00002540
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00004343 File Offset: 0x00002543
		 IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004346 File Offset: 0x00002546
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00004349 File Offset: 0x00002549
		public void Insert(int index, T item)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0000434B File Offset: 0x0000254B
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0400063F RID: 1599
		private readonly IDictionary<T, LinkedListNode<T>> _dictionary;

		// Token: 0x04000640 RID: 1600
		private readonly LinkedList<T> _linkedList;
		private IReadOnlyList<T> _readOnlyListImplementation;
		T IReadOnlyList<T>.this[int index] => _readOnlyListImplementation[index];
	}
}
