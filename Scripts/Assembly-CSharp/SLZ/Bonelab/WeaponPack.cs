using System;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class WeaponPack : MonoBehaviour
	{
		public enum WeaponType
		{
			RANGED = 0,
			MELEE = 1
		}

		public enum MeleeType
		{
			BLADE = 0,
			BLUNT = 1
		}

		public bool isSpawned;

		public WeaponType weaponType;

		public MeleeType meleeType;

		[Header("Secondary Weapon Packs")]
		public WeaponPack secondaryPack;

		[Header("SpawnableCrates")]
		public Spawnable weaponSpawnable;

		public Spawnable magSpawnable;

		public Poolee weaponPoolee;

		[Header("Spawned Instances")]
		public GameObject spawnedWeaponObj;

		public GameObject spawnedMagObj;

		[Header("Spawn Points")]
		public Transform weaponSpawn;

		public Transform magazineSpawn;

		[Header("Weapon Swap Refs")]
		public InteractableHost weaponHost;

		public Gun gun;

		public Grip weaponGrip;

		public AmmoSocket slotReciever;

		public Rigidbody gunBody;

		public Grip[] allGrips;

		[Header("Magazine Swap Refs")]
		public Magazine magazine;

		public Grip magGrip;

		public InteractableHost magHost;

		public Rigidbody magBody;

		public Action<WeaponPack> OnPackGrabbed;

		public void OnSpawnWeapon()
		{
		}

		public void OnDespawnWeapon()
		{
		}

		public void ResetHostObj(InteractableHost host)
		{
		}

		public void OnWeaponGrabbed(Hand hand)
		{
		}
	}
}
