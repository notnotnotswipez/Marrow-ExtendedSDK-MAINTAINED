using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GenGameControl_Display : MonoBehaviour
	{
		public TMP_Text titleText;

		public TMP_Text timeText;

		public TMP_Text aliveText;

		public TMP_Text killsText;

		public TMP_Text totalKillsText;

		public TMP_Text totalEnemiesText;

		public TMP_Text aliveFriendsText;

		public TMP_Text collectiblesTotalText;

		public TMP_Text collectiblesFoundText;

		public TMP_Text arenaTimeText;

		public TMP_Text arenaRoundText;

		public TMP_Text arenaWaveText;

		public TMP_Text arenaDifficultyText;

		public Color textColor;

		[ContextMenu("ChangeAllTextColor")]
		public void ChangeAllTextColor()
		{
		}
	}
}
