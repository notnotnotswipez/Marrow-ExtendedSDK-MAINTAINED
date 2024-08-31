using System;
using System.Collections;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TaxiController2 : MonoBehaviour
	{
		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void UpdateSpeed(int setting)
		{
		}

		[ContextMenu("StartCreditsCoroutine")]
		public void StartCreditsCoroutine()
		{
		}

		private IEnumerator CreditsCoroutine()
		{
			return null;
		}

		public void DisableTaxiGrips()
		{
		}

		public void StartPushTaxiRoutine()
		{
		}

		private IEnumerator CoWaitForPush()
		{
			return null;
		}

		public void SwapEngineSoundSimple(int i)
		{
		}

		public void SwapEngineSound(int i, float blendTime)
		{
		}

		private IEnumerator EngineSoundCoroutine(int i, float blendTime)
		{
			return null;
		}

		[ContextMenu("SeatRegistered")]
		private void SeatRegistered()
		{
		}

		[ContextMenu("Start Taxi Song")]
		public void StartTaxiSong()
		{
		}

		public void StartPushPromptsCoroutine()
		{
		}

		private IEnumerator PushPromptCoroutine()
		{
			return null;
		}

		public void KillPushPromptCoroutine()
		{
		}

		public void StartDuckMusicCoroutine(float length)
		{
		}

		private IEnumerator DuckMusicCoroutine(float length)
		{
			return null;
		}

		[ContextMenu("SeatDeRegistered")]
		private void SeatDeRegistered()
		{
		}

		public void SplineLoopCounter()
		{
		}

		public void DriveComplete()
		{
		}

		private IEnumerator CoWaitForStop()
		{
			return null;
		}

		public void PlayerExitedCab()
		{
		}

		private IEnumerator CoPlayerDist()
		{
			return null;
		}

		public TaxiController2()
		{
		}

		public ConfigurableJoint frontLf;

		public ConfigurableJoint frontRt;

		public ConfigurableJoint backLf;

		public ConfigurableJoint backRt;

		public CollisionStaySensor frontLfStaySensor;

		public CollisionStaySensor frontRtStaySensor;

		public CollisionStaySensor backLfStaySensor;

		public CollisionStaySensor backRtStaySensor;

		public Rigidbody steeringWheel;

		public Rigidbody frontAxle;

		[SerializeField]
		private Rigidbody carBody;

		private ConfigurableJoint _steeringHinge;

		[InspectorDisplayName("Target Velocity")]
		[Header("Off  -  0")]
		public float velocity_off;

		[InspectorDisplayName("Position Damper")]
		public float damper_off;

		[InspectorDisplayName("Maximum Force")]
		public float force_off;

		[InspectorDisplayName("Target Velocity")]
		[Header("Idle  -  1")]
		public float velocity_idle;

		[InspectorDisplayName("Position Damper")]
		public float damper_idle;

		[InspectorDisplayName("Maximum Force")]
		public float force_idle;

		[InspectorDisplayName("Target Velocity")]
		[Header("Fast  -  2")]
		public float velocity_fast;

		[InspectorDisplayName("Position Damper")]
		public float damper_fast;

		[InspectorDisplayName("Maximum Force")]
		public float force_fast;

		[Header("Slow  -  3")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_slow;

		[InspectorDisplayName("Position Damper")]
		public float damper_slow;

		[InspectorDisplayName("Maximum Force")]
		public float force_slow;

		[Header("Brake  -  4")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_brake;

		[InspectorDisplayName("Position Damper")]
		public float damper_brake;

		[InspectorDisplayName("Maximum Force")]
		public float force_brake;

		private Vector3 jointDriveCurrent;

		private Vector3 jointDriveTarget;

		private Vector3 jointDriveVel;

		public float throttleTime;

		[SerializeField]
		private float currVelMag;

		[SerializeField]
		private float velThresh;

		private float stopThresh;

		public float creditsLength;

		public MeshRenderer creditsRenderer;

		public Texture creditsTexture;

		private Material creditsMaterial;

		public GenericAnimatorController jimmyController;

		[SerializeField]
		private AudioClip[] engineStart;

		[SerializeField]
		private AudioClip[] brakeSqueal;

		[SerializeField]
		private AudioClip[] doorOpen;

		[SerializeField]
		private AudioClip[] doorClose;

		[Range(0f, 1f)]
		public float engineVolume;

		[Range(0f, 1f)]
		public float engineVolumeInterior;

		[SerializeField]
		private AudioClip engineIdleExteriorLoop;

		[SerializeField]
		private AudioClip engineIdleInteriorLoop;

		[SerializeField]
		private AudioClip engineSpeedExteriorLoop;

		[SerializeField]
		private AudioClip engineSpeedInteriorLoop;

		public Transform engineTransform;

		public Transform cabMusicTransform;

		public Transform doorTransform;

		private ManagedAudioPlayer engineSource1;

		private ManagedAudioPlayer engineSource2;

		private ManagedAudioPlayer cabMusicSource;

		private IEnumerator engineCoroutine;

		private bool engineSource1UsedLast;

		[SerializeField]
		private AudioClip honkClip;

		[SerializeField]
		private AudioClip fenceMusic;

		public AnimationCurve duckCurve;

		[Range(0f, 4f)]
		public float duckTime;

		[Range(0f, 1f)]
		public float duckVolumeLevel;

		private IEnumerator duckCoroutine;

		private IEnumerator pushCoroutine;

		private float cashedBaseVolume;

		public AudioReverbData voidReverbData;

		public AudioReverbData cabReverbData;

		public MeshRenderer[] toggleObjects;

		[SerializeField]
		private Seat rearSeat;

		[SerializeField]
		private UnityEvent OnEngineStart;

		[SerializeField]
		private UnityEvent OnPlayerSeated;

		[SerializeField]
		private UnityEvent OnWhiteFlag;

		[SerializeField]
		private UnityEvent OnStopingStart;

		[SerializeField]
		private UnityEvent OnRideComplete;

		[SerializeField]
		private UnityEvent OnLoopComplete;

		[SerializeField]
		private UnityEvent OnDriveOff;

		public Grip[] gripsToDisable;

		private Rigidbody _frontLfRb;

		private Rigidbody _frontRtRb;

		private Rigidbody _backLfRb;

		private Rigidbody _backRtRb;

		private float _lastFrontLfPressure;

		private float _lastFrontRtPressure;

		private float _lastBackLfPressure;

		private float _lastBackRtPressure;

		private bool _exitedCab;

		private int loopCount;

		private int loopGoal;
	}
}
