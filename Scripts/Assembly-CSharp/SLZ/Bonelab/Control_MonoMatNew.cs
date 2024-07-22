using System;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Control_MonoMatNew : MonoBehaviour
	{
		[Serializable]
		public class MonomatInventoryItem
		{
			public SpawnableCrateReference[] monomatItems;

			public int itemPrice;

			public int mult;
		}

		[Serializable]
		public class MonomatInventory
		{
			public MonomatInventoryItem[] inventory;
		}

		private MonomatInventory currentInventory;

		private int selectedItem;

		public MonomatInventory[] inventories;

		[SerializeField]
		private PowerSource doorPower;

		[SerializeField]
		private int multiplier;

		[SerializeField]
		private int itemPrice;

		[SerializeField]
		private int lightBullets;

		[SerializeField]
		private int mediumBullets;

		[SerializeField]
		private int heavyBullets;

		[SerializeField]
		private TextMeshPro bulletBalanceTextmesh;

		[SerializeField]
		private TextMeshPro refundTextmesh;

		[SerializeField]
		private AmmoReciever reciever;

		[SerializeField]
		private GameObject[] previewObjects;

		[SerializeField]
		private GameObject[] previewRots;

		[SerializeField]
		private MeshFilter[] previewMeshes;

		private SpawnableCrate[] lastCrates;

		private Mesh[] loadedMeshes;

		private Vector3[] cashedEularOffsets;

		[SerializeField]
		private MeshFilter drawerBounds;

		[SerializeField]
		private MeshFilter drawerPreviewMesh;

		[SerializeField]
		private Transform drawerPreviewRots;

		public float previewMeshScaleTune;

		private Vector3[] offsets;

		[SerializeField]
		private Spawnable lightRefundSpawnable;

		[SerializeField]
		private Spawnable mediumRefundSpawnable;

		[SerializeField]
		private Spawnable heavyRefundSpawnable;

		[SerializeField]
		private AudioClip _openedClip;

		[SerializeField]
		private AudioClip _unlockedClip;

		[SerializeField]
		private AudioClip _lockedClip;

		public Transform giveChangeTransform;

		private bool[] itemConsumed;

		private void Start()
		{
		}

		[ContextMenu("SetInventory0")]
		public void SetInventory0()
		{
		}

		[ContextMenu("SetInventory1")]
		public void SetInventory1()
		{
		}

		[ContextMenu("SetInventory2")]
		public void SetInventory2()
		{
		}

		public void SETINVENTORY(int index)
		{
		}

		public void SETINVENTORY(MonomatInventory inventory)
		{
		}

		private void UpdateItems()
		{
		}

		public void UpdatePreviewMeshes(int index, SpawnableCrate crate)
		{
		}

		public void SELECTITEM(int index)
		{
		}

		[ContextMenu("CheckItemMenu")]
		public void CheckItemMenu()
		{
		}

		public void CHECKITEM()
		{
		}

		public void GIVECHANGE()
		{
		}

		public void InsertMagazine(Magazine magazine)
		{
		}

		private void AddBullets(int addedBullets, int type)
		{
		}

		private void SpawnItems(SpawnableCrate crate)
		{
		}
	}
}
