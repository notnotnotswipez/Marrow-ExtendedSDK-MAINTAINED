using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;

namespace SLZ.Bonelab
{
	[Serializable]
	public class MagazineState
	{
		public MagazineData magazineData;

		public CartridgeData cartridgeData;

		private List<CartridgeData> _cartridges;

		public Action<int> onAmmoChange;

		public int AmmoCount => 0;

		public void Initialize(CartridgeData catridgeData, int ammoCount)
		{
		}

		public void Refill()
		{
		}

		public CartridgeData PullCartridge()
		{
			return null;
		}

		public void SetCartridge(int count)
		{
		}

		public void AddCartridge(int count, CartridgeData cart = null)
		{
		}

		public void ClearMagazine()
		{
		}

		public CartridgeData GetCartridgeData()
		{
			return null;
		}
	}
}
