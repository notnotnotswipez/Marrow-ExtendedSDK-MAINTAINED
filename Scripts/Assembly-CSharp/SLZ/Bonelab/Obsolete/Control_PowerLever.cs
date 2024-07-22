using System;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[AddComponentMenu(null)]
	[Obsolete("OLD POWERABLE SYSTEM - DO NOT USE!")]
	public class Control_PowerLever : OnOffSwitch
	{
		[Header("SETTINGS")]
		[Space(5f)]
		public bool invert_Output;

		[Tooltip("Lever can be an OnOff Switch or -1,0,1 float")]
		public bool operation_Float;

		[Tooltip("Will return Lever to center position on letgo")]
		public bool operation_Momentary;

		[Tooltip("The number of steps to sweetspot to while not in float mode")]
		[Range(2f, 100f)]
		public int intSubdivisions;

		[Range(0f, 1f)]
		[Tooltip("The size of center swtich dead zone where output will be 0, 0 is no dead zone.")]
		public float deadZoneSize;

		private float voltage;

		public float force_Spring;

		public float force_Damper;

		public float force_Max;

		public AudioClip clip_clickOn;

		public AudioClip clip_clickOff;

		[Space(5f)]
		[Header("JOINT")]
		public ConfigurableJoint jnt_lever;

		[HideInInspector]
		public Rigidbody rb_lever;

		[HideInInspector]
		public Haptor hnd_Haptor;

		private float m_limitMin;

		private float m_limitMax;

		[Header("INDICATOR LIGHTS")]
		[Space(5f)]
		public GameObject[] indicateOn;

		public GameObject[] indicateOff;

		[Space(5f)]
		[Header("CONTROL")]
		public GameObject[] send_Objects;

		[SerializeField]
		[Tooltip("Offset that is added to the lowerAngularLimit of the configurablejoint")]
		private float m_lowerLeverLimit;

		[SerializeField]
		[Tooltip("Offset that is added to the higherAngularLimit of the configurablejoint")]
		private float m_higherLeverLimit;

		private float actualHighLimit;

		private float actualLowLimit;

		private float _xLimitMidpoint;

		private bool m_LeverDegreeOn;

		[HideInInspector]
		public bool canHaptic;

		private bool _prismatic;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LEVERCHECK(bool canSound = false)
		{
		}

		private float Remap(float s, float a1, float a2, float b1, float b2)
		{
			return 0f;
		}

		private void CIRCUIT()
		{
		}

		private void NONCIRCUIT()
		{
		}

		public void HAPTOUT()
		{
		}

		public override void OnOffEvent(bool isOn)
		{
		}

		public void SetIndicators(bool OnOff = false)
		{
		}

		private void PlaySound(AudioClip clip)
		{
		}
	}
}
