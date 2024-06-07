using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class CrateReferenceT<T> : ScannableReference<Crate> where T : Crate
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00003174 File Offset: 0x00001374
		public CrateReferenceT()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000317C File Offset: 0x0000137C
		public CrateReferenceT(string barcode)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000676C File Offset: 0x0000496C
		public T Crate
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00003184 File Offset: 0x00001384
		public bool TryGetCrate(out T crate)
		{
			crate = default(T);
			return false;
		}
	}
}
