using System;
using System.Collections;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AmmoDispenser : MonoBehaviour, IRecycleListenable, ISpawnListenable
	{
		private void Awake()
		{
		}

		public void Start()
		{
		}

		public void Setup()
		{
		}

		public void SPAWN_AMMO(int type)
		{
		}

		public IEnumerator RAINAMMO(int type)
		{
			return null;
		}

		public void TOGGLERAIN()
		{
		}

		public void STOPRAININGAMMO(int type)
		{
		}

		public void TEXTDISPLAY()
		{
		}

		public void AUDIOALERT(bool positive = false, int type = 0)
		{
		}

		public void OnRecycle(GameObject go)
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public AmmoDispenser()
		{
		}

		public TextMeshPro[] txt_ammoDisplay;

		public bool[] count_infinite;

		public int[] count_ammo;

		public CrateSpawner[] spawn_ammo;

		public CrateSpawner[] inf_spawn_ammo;

		public SimpleParticleSpawner[] spawn_fx;

		public bool makeItRain;

		public TextMeshPro txt_makeItRain;

		public AudioClip[] clip_spawn;

		public AudioClip[] clip_deny;

		private Coroutine[] rainingAmmo;
	}
}
