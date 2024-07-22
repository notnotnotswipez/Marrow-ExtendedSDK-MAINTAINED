using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using SLZ.SFX;
using UnityEngine;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Bonelab
{
	public class ChopperSequenceController_LongRun : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWindForceBurst_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CWindForce_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003CVideoTimmer_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

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
		private struct _003CLerpBlend_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			public float fromCutoff;

			public float toCutoff;

			public float fromVol;

			public float toVol;

			public CancellationTokenSource cts;

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
		private struct _003CTargetPlayer_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			public CancellationTokenSource cts;

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
		private struct _003CSpawnOmnis_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			private Transform[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private Transform _003Ctran_003E5__4;

			private bool _003Cfired_003E5__5;

			private float _003Ctime_003E5__6;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003CRotorPowerUpdate_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChopperSequenceController_LongRun _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private YieldAwaitable.Awaiter _003C_003Eu__2;

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

		[Header("Animator")]
		public Animator animator;

		public GameObject chopper;

		public Rigidbody rotorRb;

		public Rigidbody tailRotorRb;

		public ConfigurableJoint mainJoint;

		public ConfigurableJoint rotorJoint;

		public ConfigurableJoint tailrotorJoint;

		public ObjectDestructible ObjectDestructible;

		public Transform rotorRayCaster;

		public GameObject rotorWahsObj;

		public ParticleSystem[] rotorWashParticles;

		public float rotorWashRange;

		public LayerMask layerMask;

		public float zeroRotorWashEmission;

		public float zeroRotorWashRadius;

		public ParticleSystem.MinMaxGradient zeroRotorWashAlpha;

		public float particleSmoothTime;

		public Transform windPoint;

		public float windForce;

		public ConfigurableJoint rampJoint;

		[SerializeField]
		private LayerMask layerFilter;

		private List<Rigidbody> filteredRBs;

		public PowerSource rotorDamagePower;

		public SimpleSFX kaxson;

		private bool hasWarningPlayed;

		[HideInInspector]
		public bool chopperDead;

		[Header("Turret")]
		public TurretHeadController turret;

		public Transform targetTransform;

		public TriggerRefProxy playerTRP;

		public Transform[] omniSpawnPos;

		public float fireCoolDown;

		[Header("Video")]
		public VideoURLSetter videoController;

		public float exitTimeOverride;

		[Header("Audio")]
		public AudioSource chopperAudioSource;

		public AudioLowPassFilter lpf;

		public AudioClip chopperFast;

		public AudioClip chopperSlow;

		private bool isSlowmoClip;

		public float volumeLerpTime;

		public float lowPassLerpTime;

		[Range(10f, 22000f)]
		public float cutoffFreqLow;

		[Range(10f, 22000f)]
		public float cutoffFreqHigh;

		[HideInInspector]
		[Header("AI")]
		public List<AgentLinkControl> omniAi;

		public bool omniRoam;

		private CancellationTokenSource lerpEnumerator;

		private float currentLerpVal;

		private float currentVolumeVal;

		private CancellationTokenSource targetPlayerCo;

		private static readonly int next;

		private static readonly int nextCaution;

		private float[] rotorWashEmissionCash;

		private float[] rotorWashRadiusCash;

		private Color[] rotorWashColorCash;

		private float rotorCastDist;

		private float currentRange;

		private float refVel;

		private float cashedMainDriveMaxForce;

		private float cashedMainSlerpDriveMaxForce;

		private static readonly int Speed;

		private CancellationTokenSource lerpBlend;

		private MarrowEntity agroEntity;

		private void Awake()
		{
		}

		public void STARTSEQUENCE(MarrowEntity entitiy)
		{
		}

		public void FADEIN()
		{
		}

		public void FADEOUT()
		{
		}

		public void STARTVIDEO()
		{
		}

		public void SPAWNOMNIS()
		{
		}

		public void AGROOMNIS()
		{
		}

		public void NEXTCAUTION()
		{
		}

		public void SECONDCAUTION()
		{
		}

		public void RAMPWINDBURST()
		{
		}

		[AsyncStateMachine(typeof(_003CWindForceBurst_003Ed__71))]
		private UniTaskVoid WindForceBurst()
		{
			return default(UniTaskVoid);
		}

		public void RAMPWIND()
		{
		}

		[AsyncStateMachine(typeof(_003CWindForce_003Ed__73))]
		private UniTaskVoid WindForce()
		{
			return default(UniTaskVoid);
		}

		public void ENDSEQUENCE()
		{
		}

		public void AddAgent(AgentLinkControl agent)
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CVideoTimmer_003Ed__77))]
		private UniTaskVoid VideoTimmer()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CLerpBlend_003Ed__78))]
		private UniTaskVoid LerpBlend(float fromCutoff, float toCutoff, float fromVol, float toVol, CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CTargetPlayer_003Ed__79))]
		private UniTaskVoid TargetPlayer(CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnOmnis_003Ed__80))]
		private UniTaskVoid SpawnOmnis()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CRotorPowerUpdate_003Ed__81))]
		private UniTaskVoid RotorPowerUpdate()
		{
			return default(UniTaskVoid);
		}

		public void ReceiveCollision(Collision collision)
		{
		}

		public void CHOPPERKILLED()
		{
		}

		private void Update()
		{
		}
	}
}
