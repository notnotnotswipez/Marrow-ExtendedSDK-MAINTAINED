using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class DataCardReference<T> : ScannableReference<DataCard> where T : DataCard
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0000320A File Offset: 0x0000140A
		public DataCardReference()
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003212 File Offset: 0x00001412
		public DataCardReference(string barcode)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00006784 File Offset: 0x00004984
		public T DataCard
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000321A File Offset: 0x0000141A
		public bool TryGetDataCard(out T dataCard)
		{
			dataCard = default(T);
			return false;
		}
	}
}
