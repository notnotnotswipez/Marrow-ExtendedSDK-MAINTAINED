using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HealthSetterMachine : MonoBehaviour
	{
		[Header("GLOBAl SETTINGS")]
		public Player_Health player_Health;

		private bool immortal;

		private float ply_default_max_health;

		public float allowed_max_health;

		public float allowed_min_health;

		public float default_health;

		public bool instantDeath;

		private float max_deathTime;

		private float min_deathTime;

		[Header("DISPLAY")]
		private string string_Immortal;

		public TextMeshPro text_Immortal;

		private string string_Death;

		public TextMeshPro text_Death;

		private string string_Health;

		public TextMeshPro text_Health;

		public void Start()
		{
		}

		public void TOGGLE_IMMORTALITY()
		{
		}

		public void TOGGLE_INSTADEATH()
		{
		}

		public void SET_HEALTH(bool up)
		{
		}

		public void DISPLAY_HEALTHMACHINE()
		{
		}
	}
}
