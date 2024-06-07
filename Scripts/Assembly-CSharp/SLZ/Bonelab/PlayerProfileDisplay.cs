using SLZ.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class PlayerProfileDisplay : MonoBehaviour
	{
		public Image img_profilePic;

		public Sprite sprite_profilePic;

		public TextMeshProUGUI dis_profileName;

		public string profileName;

		public TextMeshProUGUI dis_progress;

		public float progressPercent;

		public TextMeshProUGUI dis_dateTime;

		public string dateTime;

		public ProgressBar bar_progressTotal;

		public ProgressBar bar_Arena;

		public ProgressBar bar_Tac;

		public ProgressBar bar_Parkour;

		public ProgressBar bar_Sandbox;

		public ProgressBar bar_Experimental;

		public ProgressBar bar_prog_Weapons;

		public ProgressBar bar_prog_Climbs;

		public ProgressBar bar_prog_Secrets;

		public GameProgress_Bonelab progressCard;

		private void Start()
		{
		}

		public void PROPEGATE_UI()
		{
		}
	}
}
