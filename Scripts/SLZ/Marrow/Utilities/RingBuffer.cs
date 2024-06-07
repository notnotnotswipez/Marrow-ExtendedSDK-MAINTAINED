using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000123 RID: 291
	public class RingBuffer<TStruct> where TStruct : struct
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000043E6 File Offset: 0x000025E6
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000043E4 File Offset: 0x000025E4
		public int Length
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000043E9 File Offset: 0x000025E9
		public RingBuffer(int size)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000043F1 File Offset: 0x000025F1
		public void Add(in TStruct tStruct)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000043F3 File Offset: 0x000025F3
		public TStruct GetReadOnly(int index)
		{
			return default(TStruct);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000043F7 File Offset: 0x000025F7
		public TStruct Get(int index)
		{
			return default(TStruct);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000043FB File Offset: 0x000025FB
		public void Clear()
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000043FD File Offset: 0x000025FD
		private int Mod(int x, int m)
		{
			return 0;
		}

		// Token: 0x04000655 RID: 1621
		private TStruct[] _buffer;

		// Token: 0x04000656 RID: 1622
		private int _size;

		// Token: 0x04000657 RID: 1623
		private int _cursor;
	}
}
