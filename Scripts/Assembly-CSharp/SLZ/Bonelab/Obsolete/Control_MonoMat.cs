using SLZ.Marrow.Data;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class Control_MonoMat : Powerable
	{
		[SerializeField]
		private Rigidbody[] _loots;

		[SerializeField]
		private Control_PowerLever _doorLever;

		[SerializeField]
		private Powerable _doorMotor;

		[SerializeField]
		private int _multiplier;

		[SerializeField]
		private int _itemPrice;

		[SerializeField]
		private int _lightBullets;

		[SerializeField]
		private int _mediumBullets;

		[SerializeField]
		private int _heavyBullets;

		[SerializeField]
		private bool _opened;

		[SerializeField]
		private bool _unlocked;

		[SerializeField]
		private TextMeshProUGUI _bulletBalanceTextmesh;

		[SerializeField]
		private TextMeshProUGUI _refundTextmesh;

		[SerializeField]
		private AmmoReciever reciever;

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

		private void Start()
		{
		}

		public void GiveChange()
		{
		}

		private void CleanupLight()
		{
		}

		private void CleanupMedium()
		{
		}

		private void CleanupHeavy()
		{
		}

		public void InsertMagazine(Magazine magazine)
		{
		}

		public void AddBullets(int addedBullets, int type)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		public Rigidbody[] GetLoots()
		{
			return null;
		}

		public void SetPrice(int price, int mult)
		{
		}

		public void SetLoots(Rigidbody[] loots)
		{
		}
	}
}
