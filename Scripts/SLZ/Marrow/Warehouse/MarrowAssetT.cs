using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000080 RID: 128
	[Serializable]
	public class MarrowAssetT<TObject> : MarrowAsset where TObject : UnityEngine.Object
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x00003567 File Offset: 0x00001767
		public MarrowAssetT()
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000356F File Offset: 0x0000176F
		public MarrowAssetT(string guid)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00006A6C File Offset: 0x00004C6C
		public new TObject Asset
		{
			get
			{
				return default(TObject);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00003577 File Offset: 0x00001777
		public override Type AssetType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00006A84 File Offset: 0x00004C84
		public UniTask<TObject> LoadAssetAsync()
		{
			return default(UniTask<TObject>);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000357A File Offset: 0x0000177A
		public void LoadAsset(Action<TObject> loadCallback)
		{
		}
	}
}
