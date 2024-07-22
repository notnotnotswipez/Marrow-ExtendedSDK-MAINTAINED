using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BodyVitals : MonoBehaviour
	{
		public enum MeasurementState
		{
			CUSTOM = 0,
			XSMALL = 1,
			SMALL = 2,
			MEDIUM = 3,
			LARGE = 4,
			XLARGE = 5,
			XXLARGE = 6,
			XXXLARGE = 7
		}

		public delegate void RescaleUI();

		[Range(1f, 2.1f)]
		public float realWorldHeight;

		public MeasurementState measurementPresets;

		public float chestCircumference;

		public float underbustCircumference;

		public float waistCircumference;

		public float hipsCircumference;

		public float wingspan;

		public float inseam;

		[HideInInspector]
		public int loco_CurveMode;

		[HideInInspector]
		public int loco_Direction;

		public float loco_DegreesPerSnap;

		[HideInInspector]
		public int loco_SnapDegreesPerFrame;

		[HideInInspector]
		public float mod_globalHaptic;

		[HideInInspector]
		public bool turnEnabled;

		[HideInInspector]
		public bool quickmenuEnabled;

		[HideInInspector]
		public bool slowTimeEnabled;

		[HideInInspector]
		public bool isRightHanded;

		[HideInInspector]
		public bool beltFlipped;

		[HideInInspector]
		public float uiScaling;

		public bool hasBodyLog;

		public bool bodyLogEnabled;

		public bool bodyLogFlipped;

		public event RescaleUI rescaleEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public void PROPEGATE()
		{
		}

		public void PROPEGATE_SOFT()
		{
		}

		public void CalibratePlayerBodyScale()
		{
		}

		private void ApplyUILayoutSettings()
		{
		}
	}
}
