using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UnlockableDisplayCase : MonoBehaviour
	{
		[Header("TEXT")]
		public TextMeshProUGUI txt_melee;

		public TextMeshProUGUI txt_ranged;

		public TextMeshProUGUI txt_fantasy;

		public TextMeshProUGUI txt_misc;

		public TextMeshProUGUI txt_physics;

		[Header("IMAGES")]
		public GameObject[] image_melee;

		public GameObject[] image_ranged;

		public GameObject[] image_fantasy;

		public GameObject[] image_misc;

		public GameObject[] image_physics;

		[Header("UID")]
		public SpawnableCrateReference[] spawn_melee;

		public SpawnableCrateReference[] spawn_ranged;

		public SpawnableCrateReference[] spawn_fantasy;

		public SpawnableCrateReference[] spawn_misc;

		public SpawnableCrateReference[] spawn_physics;

		private bool[] own_melee;

		private bool[] own_ranged;

		private bool[] own_fantasy;

		private bool[] own_misc;

		private bool[] own_physics;

		private int max_melee;

		private int max_ranged;

		private int max_fantasy;

		private int max_misc;

		private int max_physics;

		private int cur_melee;

		private int cur_ranged;

		private int cur_fantasy;

		private int cur_misc;

		private int cur_physics;

		private void Start()
		{
		}

		public void CHECKDATA()
		{
		}

		public void DISPLAYUI()
		{
		}
	}
}
