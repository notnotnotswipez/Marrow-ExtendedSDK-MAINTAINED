using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.MLAgents
{
	[RequireComponent(typeof(WheelCollider))]
	public class RCC_WheelCollider : MonoBehaviour
	{
		public RCC_GroundMaterials RCCGroundMaterials;

		private WheelCollider _wheelCollider;

		public BaseVehicleUtils carController;

		private Rigidbody _rigid;

		private List<RCC_WheelCollider> allWheelColliders;

		public Transform wheelModel;

		public WheelHit wheelHit;

		public bool isGrounded;

		[Space]
		public bool canPower;

		[Range(-1f, 1f)]
		public float powerMultiplier;

		public bool canSteer;

		[Range(-1f, 1f)]
		public float steeringMultiplier;

		public bool canBrake;

		[Range(0f, 1f)]
		public float brakingMultiplier;

		public bool canHandbrake;

		[Range(0f, 1f)]
		public float handbrakeMultiplier;

		[Space]
		public float width;

		public float offset;

		internal float wheelRPM2Speed;

		[Range(-5f, 5f)]
		public float camber;

		[Range(-5f, 5f)]
		public float caster;

		[Range(-5f, 5f)]
		public float toe;

		internal float damagedCamber;

		internal float damagedCaster;

		internal float damagedToe;

		public RCC_GroundMaterials.GroundMaterialFrictions[] physicsFrictions;

		private SkidManager vehicleManager;

		private int lastSkidmark;

		public float wheelSlipAmountForward;

		public float wheelSlipAmountSideways;

		public float totalSlip;

		private WheelFrictionCurve forwardFrictionCurve;

		private WheelFrictionCurve sidewaysFrictionCurve;

		private AudioSource audioSource;

		public AudioClip audioClip;

		public AudioClip bumpClip;

		private float audioVolume;

		private int groundIndex;

		internal List<ParticleSystem> allWheelParticles;

		internal ParticleSystem.EmissionModule emission;

		internal float tractionHelpedSidewaysStiffness;

		private float minForwardStiffness;

		private float maxForwardStiffness;

		private float minSidewaysStiffness;

		private float maxSidewaysStiffness;

		private TerrainData mTerrainData;

		private int alphamapWidth;

		private int alphamapHeight;

		private float[,,] mSplatmapData;

		private float mNumTextures;

		public float bumpForce;

		public float oldForce;

		public WheelCollider wheelCollider => null;

		public Rigidbody rigid => null;

		private void Start()
		{
		}

		public void UpdateWheelData(VehicleSettings data)
		{
		}

		public static AudioSource NewAudioSource(AudioMixerGroup audioMixer, GameObject go, string audioName, float minDistance, float maxDistance, float volume, AudioClip audioClip, bool loop, bool playNow, bool destroyAfterFinished)
		{
			return null;
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void WheelAlign()
		{
		}

		private void SkidMarks()
		{
		}

		private void Drift()
		{
		}

		private void Audio()
		{
		}

		private bool isSkidding()
		{
			return false;
		}

		public WheelFrictionCurve SetFrictionCurves(WheelFrictionCurve curve, float extremumSlip, float extremumValue, float asymptoteSlip, float asymptoteValue)
		{
			return default(WheelFrictionCurve);
		}

		private void OnDrawGizmos()
		{
		}
	}
}
