using SLZ.Marrow;
using SLZ.Marrow.AI;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Collider))]
	internal class ItemDropper : MonoBehaviour
	{
		public bool dropHands;

		public bool despawnOnDrop;

		public InventorySlotReceiver[] inventorySlotReceivers;

		public AudioClip dropClip;

		public UnityEvent OnDrop;

		private void Awake()
		{
		}

		private void OnLevelLoadGetPlayer()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void RemoveItem(IGrippable host)
		{
		}

		private void DropItems(TriggerRefProxy playerProxy)
		{
		}
	}
}
