using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BaseVehicleUtils : MonoBehaviour
	{
		public enum SpeedUnit
		{
			Imperial = 0,
			Metric = 1
		}

		[Tooltip("The vehicle the senors connected to")]
		public BaseVehicle baseVehicle;

		[Tooltip("Configuration to pre-initialize values from for a basevehile")]
		public VehicleConfig config_file;

		[Header("Motor & Transmission Section")]
		[Tooltip("Maximum values used in the BaseVehicleUtils class (not SphereVehicleUtils")]
		public float maxTorque;

		[Tooltip("Maximum values used in the BaseVehicleUtils class (not SphereVehicleUtils")]
		[Header("Motor & Transmission Section")]
		public float maxReverseTorque;

		[Tooltip("Maximum values used in the BaseVehicleUtils class (not SphereVehicleUtils")]
		[Header("Motor & Transmission Section")]
		public float maxBrakeTorque;

		[Tooltip("Maximum values used in the BaseVehicleUtils class (not SphereVehicleUtils")]
		[Header("Motor & Transmission Section")]
		public float maxSteerAngle;

		[Tooltip("Gear and Rev Values are only used in audio functions")]
		public bool useGears;

		public static int NoOfGears;

		private int m_GearNum;

		private float m_GearFactor;

		private float m_RevRangeBoundary;

		[Tooltip("Used in setting and normalizing speed values")]
		public float topSpeed;

		[Tooltip("Used in setting and normalizing speed values")]
		public float topReverseSpeed;

		[HideInInspector]
		public bool Accelerating;

		[HideInInspector]
		public bool Deccelerating;

		[Tooltip("Maximum speed this vehicle can ever go")]
		public float maxSpeedEver;

		[Tooltip("(Depricated) Used in the old dynamic steer method")]
		public float speed_ratio;

		[Tooltip("(Not Currently Used) Observed in the next observation, similar to steering value")]
		public float last_motorInput;

		[Header("Steering & Control Section")]
		public PhysVehicleAIInput physInput;

		[Tooltip("Used in observations")]
		public float last_steerInput;

		[Tooltip("Lerp the incoming steering value (used in dynamic steering)")]
		public float steeringLerpScale;

		[Tooltip("Used in dynamic steering")]
		public float baseSteerAngle;

		[Tooltip("Used in dynamic steering")]
		public float baseLerpScale;

		[Tooltip("The Actual Steering Value")]
		public float currentSteer;

		[HideInInspector]
		public bool Left;

		[HideInInspector]
		public bool Right;

		[HideInInspector]
		public float HandBrake;

		protected float steerVal;

		[Tooltip("Amount of time where the vehicle will be immune post spawn")]
		[Header("Vehicle Status Section")]
		public float totalImmuneTime;

		[Tooltip("Immunity Clock Time Left")]
		public float immune_countdown;

		public bool immune;

		[Tooltip("Amount of time of falling that has to be detected before a respawn event will fire")]
		public float fallingTimeThresh;

		[Tooltip("Reference point for setting COM of the rigidbody system")]
		[Header("Physical Section")]
		public Transform centerOfMass;

		[Tooltip("Whether to continually change center of mass volume as the car is moving and shifting weight around")]
		public bool updateCOM;

		public Rigidbody _rb;

		[Tooltip("The rigidbody thats in the seat")]
		public Rigidbody seatedBody;

		[Tooltip("Wheel off ground after touching a jump")]
		[Header("Additional Forces Section")]
		public bool hasJumped;

		[Tooltip("Clock Ticker for how long its been off ground")]
		public float offGroundTime;

		[Tooltip("Use additional forces on the body to prevent it from flipping over in the air")]
		public bool isAntiRolling;

		[Tooltip("Modulate friction to go higher as the angular velocity increases to slip out and prevent flip (unstable)")]
		public bool isAntiRollingFriction;

		[Tooltip("Static amount of friction to apply to force points designated in the prefab")]
		public float downForce;

		public float antiRollFrontHorizontal;

		public float antiRollRearHorizontal;

		public float antiRollVertical;

		public float inAirForce;

		[Tooltip("Minimum angle that the vehicle needs to be at for it to be detected as flipped over.")]
		public float allowedAngle;

		public bool flipOverInput;

		[Tooltip("Is the vehicle flipped over?")]
		public bool flippedOver;

		[Tooltip("If enabled a prompt will be shown after the timeout, asking player to press the FlipOverModule button.")]
		public bool manual;

		[Tooltip("Flip over detection will be disabled if velocity is above this value [m/s].")]
		public float maxDetectionSpeed;

		[Tooltip("Rotation speed of the vehicle while being flipped back.")]
		public float rotationSpeed;

		[Tooltip("Time after detecting flip over after which vehicle will be flipped back or the manual button can be used.")]
		public float timeout;

		private bool _manualFlipoverInProgress;

		private float _xAngle;

		private float _zAngle;

		private float _timeAfterRecovery;

		private float _timeSinceFlip;

		private float _vehicleAngle;

		private bool _wasFlippedOver;

		[Tooltip("Amount of force to apply to un flip the car after some amount of time and past angle thresholds")]
		public float flipMod;

		[Header("Wheels Section")]
		[Tooltip("BaseVehicle uses RCC wheels - these are the wheel references")]
		public RCC_WheelCollider[] rccWheels;

		private int powerableWheelCount;

		private int brakableWheelCount;

		[Tooltip("Only works for RCC wheels currently")]
		public float[] wheelsGrounded;

		public int nb_wheels_off_ground;

		[Tooltip("Number of wheels that have to be off ground before the event is triggered")]
		public int nbUngroundedThresh;

		[Tooltip("Switch for turning on helper UI")]
		public bool debugSlip;

		[Tooltip("Normalized Values representing each wheels forward and sideways slip that feed into the debug UI")]
		public WheelFrictionCurve[] initForwardWheelCurves;

		[Tooltip("Normalized Values representing each wheels forward and sideways slip that feed into the debug UI")]
		public WheelFrictionCurve[] initSidewaysWheelCurves;

		[Tooltip("Text Objects for representing float value of slip (another debug tool)")]
		public TextMeshProUGUI[] slipText;

		[Tooltip("Manager script for instancing skid marks from the rcc wheel class")]
		public SkidManager skidManager;

		[Tooltip("Switch for using additional drift forces")]
		public bool useDrifting;

		[Tooltip("Switch for using skidmark effects")]
		public bool useSkidmarks;

		private WheelHit emptyWheelHit;

		public WheelFrictionCurve rollCurve;

		public float Revs
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[Tooltip("Called in the drive function")]
		public float AccelInput
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public VehicleConfig Config
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float CurrentSpeed => 0f;

		public event Action Fallen
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

		private void StoreWheelCurves()
		{
		}

		public virtual void Awake()
		{
		}

		protected void UpdateCOM()
		{
		}

		private void UpdateSlipText()
		{
		}

		private void FixedUpdate()
		{
		}

		protected void SetFromConfig()
		{
		}

		public void Init()
		{
		}

		[ContextMenu("Force Rest")]
		public void ForceRest()
		{
		}

		protected void OffGroundTicker()
		{
		}

		private void CheckWheelsGrounded()
		{
		}

		public virtual void Drive(float motorInput, float steerInput, float handBrake, bool reverseEyes = false, bool discreteControl = true)
		{
		}

		public void AntiRollWheelFriction()
		{
		}

		public void SoftReset(BaseVehicle car, Vector3 respawn_pos, Vector3 respawn_rot)
		{
		}

		public static float NextPointsAngle(Vector3[] point_arr)
		{
			return 0f;
		}

		public virtual void PlaceVehicle(BaseVehicle car, Vector3 pos, Vector3 rot)
		{
		}

		public static void GetSpawnRotation(Transform car_transform, GameObject currentObjective, Vector3 carRotation)
		{
		}

		private void ImmuneSwitcher(GameObject go, bool rb_val, bool col_val)
		{
		}

		public void ImmunityHandler()
		{
		}

		protected void AntiRollBars()
		{
		}

		protected void CheckFlipped()
		{
		}

		protected void CalculateGearFactor()
		{
		}

		protected void CalculateRevs()
		{
		}

		protected void GearChanging()
		{
		}

		private static float CurveFactor(float factor)
		{
			return 0f;
		}

		private static float ULerp(float from, float to, float value)
		{
			return 0f;
		}

		protected float ValueRemapper(float fromValue, float fromLow, float fromHigh, float toLow, float toHigh)
		{
			return 0f;
		}
	}
}
