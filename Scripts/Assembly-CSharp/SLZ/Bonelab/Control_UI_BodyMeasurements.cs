using SLZ.Bonelab.SaveData;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class Control_UI_BodyMeasurements : MonoBehaviour
	{
		public TextMeshProUGUI height_metric;

		public TextMeshProUGUI height_imperial;

		public TextMeshProUGUI shirt_size;

		public TextMeshProUGUI txt_measure_wingspan;

		public TextMeshProUGUI txt_measure_chest;

		public TextMeshProUGUI txt_measure_underbust;

		public TextMeshProUGUI txt_measure_waist;

		public TextMeshProUGUI txt_measure_hips;

		public TextMeshProUGUI txt_measure_inseam;

		public TextMeshProUGUI txt_Standing;

		public Image img_StandingSeated;

		public Sprite[] sprite_StandingSeated;

		public GameObject obj_pleaseSave;

		public GameObject obj_advancedSettings;

		[Space(10f)]
		public UnityEvent completionEvent;

		[Space(10f)]
		[Header("TextDisplay")]
		public string[] string_DisplayText;

		public TextMeshProUGUI[] text_DisplayText;

		[Space(10f)]
		[Header("Body")]
		public Control_Player controlPlayer;

		public string[] shirt_sizes;

		public float[] shirtSizeModifier;

		public float wingspanModifier;

		public float mediumChest;

		public float mediumUnderbust;

		public float mediumWaist;

		public float mediumHips;

		public float inseamModifier;

		private static PlayerSettings ps => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void BUTTON_GUESS()
		{
		}

		public void BUTTON_HEIGHT(bool up)
		{
		}

		public void BUTTON_SHIRT(bool left)
		{
		}

		public void BUTTON_MEASUREMENTS(int buttonValue)
		{
		}

		public void BUTTON_ADVANCEDSETTINGS()
		{
		}

		public void BUTTON_CONFIRM()
		{
		}

		private void CalculateMeasurements(bool guessHeight = false)
		{
		}

		private void CheckApprovals()
		{
		}

		private void SendVitals()
		{
		}

		private void SOMETHINGCHANGED(bool changed = true)
		{
		}

		private void DISPLAY_TEXT()
		{
		}

		private void DISPLAY_MEASUREMENTS()
		{
		}
	}
}
