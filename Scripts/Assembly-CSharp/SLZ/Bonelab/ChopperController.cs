using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChopperController : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CManagedUpdate_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFireTurret_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperController _003C_003E4__this;

			public CancellationTokenSource cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAudioLowPassLerp_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationTokenSource cancelToken;

			public ChopperController _003C_003E4__this;

			public float fromCutoff;

			public float toCutoff;

			private float _003Ctime_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAudioVolumeLerp_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationTokenSource cancelToken;

			public ChopperController _003C_003E4__this;

			public float fromVol;

			public float toVol;

			private float _003Ctime_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[Header("References")]
		public SLZ.Marrow.Interaction.SplineJoint splineJoint;

		public ConfigurableJoint mainJoint;

		public ConfigurableJoint rotorJoint;

		public ConfigurableJoint tailRotorJoint;

		public Rigidbody bodyRb;

		public Rigidbody rotorRb;

		public Rigidbody tailRotorRb;

		public Rigidbody turretRb;

		public TurretHeadController turret;

		public ObjectDestructible ObjectDestructible;

		public Transform targetTransform;

		public Transform firePointTransform;

		public Transform firePointTransformRaw;

		[Header("Chopper Behavior (Speed/Damper/MaxForce)")]
		public Vector3 fastDriveSettings;

		public Vector3 slowDriveSettings;

		public float speedTransitionTime;

		[Header("Turret Behavior")]
		public float fireRange;

		public float slowRange;

		public float chargeTime;

		public float burstLength;

		public float fireRate;

		public float burstCoolDown;

		[Range(0f, 10f)]
		public float maxBulletSpread;

		[Range(0f, 10f)]
		public float minBulletSpread;

		public LayerMask chopperLayerMask;

		[Header("VFX")]
		public float rotorWashRange;

		public LayerMask layerMask;

		public Transform rotorRayCaster;

		public GameObject rotorWahsObj;

		public ParticleSystem[] rotorWashParticles;

		public ParticleSystem.MinMaxGradient zeroRotorWashAlpha;

		public float particleSmoothTime;

		[Header("Audio")]
		public AudioClip[] turretCharge;

		public AudioSource chopperAudioSource;

		public AudioClip chopperFast;

		public AudioClip chopperSlow;

		public AudioLowPassFilter chopperLowPassFilter;

		[Range(10f, 22000f)]
		public float cutoffFreqLow;

		[Range(10f, 22000f)]
		public float cutoffFreqHigh;

		[Range(0f, 1f)]
		public float minVolume;

		[Range(0f, 1f)]
		public float maxVolume;

		public float lerpTime;

		private float currentCutoffVal;

		private float currentVolumeVal;

		public PowerSource rotorDamagePower;

		[HideInInspector]
		public bool chopperDead;

		private bool isSlowmoClip;

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private CancellationTokenSource fireSequenceCancellationToken;

		private CancellationTokenSource volumeLerpCancellationToken;

		private CancellationTokenSource lowPassLerpCancellationToken;

		private bool killMode;

		private Vector3 splineDriveCurrent;

		private Vector3 splineDrivePrevious;

		private Vector3 splineDriveLastSet;

		private Vector3 splineDriveTarget;

		private Vector3 splineDriveVel;

		private float mainDriveLastSet;

		private float mainSlerpLastSet;

		private float[] rotorWashEmissionCash;

		private float[] rotorWashRadiusCash;

		private Color[] rotorWashColorCash;

		private float rotorCastDist;

		private float currentRange;

		private float refVel;

		private float cashedMainDriveMaxForce;

		private float cashedMainSlerpDriveMaxForce;

		private MarrowEntity agroEntity;

		private float lastTargetDist;

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void AGRO(MarrowEntity entitiy)
		{
		}

		public void UNAGRO()
		{
		}

		private void PlayerDeath()
		{
		}

		[AsyncStateMachine(typeof(_003CManagedUpdate_003Ed__77))]
		private UniTaskVoid ManagedUpdate()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CFireTurret_003Ed__78))]
		private UniTaskVoid FireTurret(CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CAudioLowPassLerp_003Ed__79))]
		private UniTaskVoid AudioLowPassLerp(float fromCutoff, float toCutoff, CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CAudioVolumeLerp_003Ed__80))]
		private UniTaskVoid AudioVolumeLerp(float fromVol, float toVol, CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		public void StartLowPass(bool startStop = false)
		{
		}

		public void StartVolume(bool startStop = false)
		{
		}

		public void StartVolumeInside(bool startStop = false)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void CHOPPERKILLED()
		{
		}

		public void KILLMODE(bool killOn)
		{
		}
	}
}
