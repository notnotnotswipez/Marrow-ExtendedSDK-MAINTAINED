using System.Collections.Generic;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Player
{
	public class Inventory : MonoBehaviour
	{
		public SlotContainer[] bodySlots;

		public SlotContainer[] specialItems;

		internal Dictionary<string, InventorySlot> m_InventorySlots;

		public void RegisterSlot(string name, InventorySlot slot)
		{
		}

		public void SubscribeToInsert(string name, InventorySlot.SlotDelegate callback)
		{
		}

		public void UnSubscribeFromInsert(string name, InventorySlot.SlotDelegate callback)
		{
		}

		public void SubscribeToRemove(string name, InventorySlot.SlotDelegate callback)
		{
		}

		public void UnSubscribeFromRemove(string name, InventorySlot.SlotDelegate callback)
		{
		}

		public void FlipSlot(bool flipped = false, bool specialItemsFlipped = false)
		{
		}
	}
}
