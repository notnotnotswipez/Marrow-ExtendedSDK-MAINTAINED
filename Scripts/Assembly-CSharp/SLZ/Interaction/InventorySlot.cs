using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InventorySlot : MonoBehaviour
	{
		public delegate void SlotDelegate(InventorySlot slot);

		[HideInInspector]
		public GameObject itemGameObject;

		public event SlotDelegate slotInsertEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event SlotDelegate slotRemoveEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Insert(GameObject go)
		{
		}

		public void Remove()
		{
		}
	}
}
