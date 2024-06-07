using System;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Obsolete]
	public class GameControl_TownFight : MonoBehaviour
	{
		public const string LevelKey = "TownFight";

		[Header("Level Loader")]
		public LevelCrateReference nextLevel;

		public LevelCrateReference loadScreenLevel;

		[HideInInspector]
		public Spawnable vfxFadeOutSpawnable;

		[Tooltip("this needs to be set so that the save data will be written")]
		public int hubSpawnLocation;

		public void Start()
		{
		}

		public void NEXTLEVEL()
		{
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}

		private void SaveData(int location = 10)
		{
		}
	}
}
