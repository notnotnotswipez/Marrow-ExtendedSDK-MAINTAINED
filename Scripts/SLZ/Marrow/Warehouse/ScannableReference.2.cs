using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class ScannableReference<T> : ScannableReference where T : Scannable
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00003287 File Offset: 0x00001487
		public override Type ScannableType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000328A File Offset: 0x0000148A
		public ScannableReference()
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003292 File Offset: 0x00001492
		public ScannableReference(string barcode)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000679C File Offset: 0x0000499C
		public new T Scannable
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000329A File Offset: 0x0000149A
		public bool TryGetScannable(out T scannable)
		{
			scannable = default(T);
			return false;
		}
	}
}
