using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;

namespace SLZ.Bonelab.SaveData
{
	public class PlayerUnlocks : IUnlocks
	{
		[JsonProperty("unlocks")]
		private Dictionary<string, int> Unlocks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int UnlockCountForBarcode(Barcode barcode)
		{
			return 0;
		}

		public int IncrementUnlockForBarcode(Barcode barcode)
		{
			return 0;
		}

		public bool ClearUnlockForBarcode(Barcode barcode)
		{
			return false;
		}
	}
}
