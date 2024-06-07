using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000075 RID: 117
	public abstract class CrateT<T> : Crate where T : UnityEngine.Object
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00003446 File Offset: 0x00001646
		public override Type AssetType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00006964 File Offset: 0x00004B64
		public new UniTask<T> LoadAssetAsync()
		{
			return default(UniTask<T>);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00003449 File Offset: 0x00001649
		public void LoadAsset(Action<T> loadCallback)
		{
		}
	}
}
