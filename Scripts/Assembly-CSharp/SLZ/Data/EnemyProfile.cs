using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "Arena_EnemyProfile", menuName = "StressLevelZero / Enemy_Profile", order = 1)]
	public class EnemyProfile : ScriptableObject
	{
		public string enemyTitle;

		public Spawnable spawnable;

		public BaseEnemyConfig baseConfig;

		public Texture iconImage;

		public bool isKing;

		[HideInInspector]
		public bool showEnemy;

		public int deathMult;

		public float entranceTimeVal;
	}
}
