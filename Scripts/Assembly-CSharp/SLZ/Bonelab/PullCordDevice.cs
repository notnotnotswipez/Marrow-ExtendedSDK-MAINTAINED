using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.UI;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PullCordDevice : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHologramAnimation_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PullCordDevice _003C_003E4__this;

			private Color _003ChologramDipColor_003E5__2;

			private float _003CanimTime_003E5__3;

			private bool _003CpreviewMeshSet_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CHologramAnimation_003Ed__151(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CAvatarTransformationSequence_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int stopIndex;

			public PullCordDevice _003C_003E4__this;

			public AvatarCrateReference avatarRef;

			private float _003CanimTime_003E5__2;

			private float _003CanimLength_003E5__3;

			private int _003ClastGlyphProgress_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CAvatarTransformationSequence_003Ed__153(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CAddAvatarAnimation_003Ed__155 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PullCordDevice _003C_003E4__this;

			public SpawnableCrate addCrate;

			public Transform addPosition;

			private GameObject _003CaddObject_003E5__2;

			private GameObject _003CaddMeshObj_003E5__3;

			private Quaternion _003CavatarAddRotation_003E5__4;

			private MeshRenderer _003CaddRenderer_003E5__5;

			private Vector3 _003Cscale_003E5__6;

			private Vector3 _003CoffsetStart_003E5__7;

			private Vector3 _003CscaleEnd_003E5__8;

			private Vector3 _003CoffsetEnd_003E5__9;

			private float _003CanimTime_003E5__10;

			private float _003CanimLength_003E5__11;

			private Color _003ChologramDipColor_003E5__12;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CAddAvatarAnimation_003Ed__155(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CRetractBall_003Ed__159 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PullCordDevice _003C_003E4__this;

			public bool quiet;

			private float _003CinitialDist_003E5__2;

			private float _003Ctime_003E5__3;

			private float _003Clength_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CRetractBall_003Ed__159(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CLerpAnchor_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PullCordDevice _003C_003E4__this;

			public float lerpTime;

			private float _003Ctime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CLerpAnchor_003Ed__166(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpdateAllPreviewMeshes_003Ed__170 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PullCordDevice _003C_003E4__this;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__172 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarCrateReference avatarCrateRef;

			public PullCordDevice _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public AvatarsPanelView apv;

		[Header("Joint Stuff")]
		public ConfigurableJoint ballJoint;

		private ConfigurableJoint worldJoint;

		private Rigidbody ballRb;

		private HandJointConfiguration savedHandJointConfiguration;

		public Transform ballStartTrans;

		private SimpleTransform initialBallTransform;

		public InteractableHost ballHost;

		[Header("Grips")]
		public Grip ballGrip;

		public Collider ballGripCollider;

		public Collider ballGripCollider2;

		[Header("References")]
		public GameObject ballArt;

		public GameObject fxLineGroup;

		public GameObject ballLine;

		public LineRenderer lineRenderer;

		public GameObject[] tickLines;

		public GameObject[] dialGlyphs;

		[Header("VFX")]
		public ParticleSystem coreVFX;

		public ParticleSystem coreBlastVFX;

		public ParticleSystem blastVFX;

		public ParticleSystem miniBlastVFX;

		public Spawnable avatarBlaster;

		[Header("Audio")]
		[SerializeField]
		[Range(0f, 1f)]
		private float incrementVolume;

		[SerializeField]
		private AudioClip[] incrementOutTick;

		[SerializeField]
		private AudioClip[] incrementInTick;

		[Range(0f, 1f)]
		[SerializeField]
		private float gripVolume;

		[SerializeField]
		private AudioClip[] gripGrab;

		[SerializeField]
		private AudioClip[] gripRelease;

		[Range(0f, 1f)]
		[SerializeField]
		private float activateVolume;

		[SerializeField]
		private AudioClip[] activateBodyLog;

		[Range(0f, 1f)]
		[SerializeField]
		private float glyphVolume;

		[SerializeField]
		private AudioClip[] glyphActive;

		[SerializeField]
		[Range(0f, 1f)]
		private float lockVolume;

		[SerializeField]
		private AudioClip[] lockBodyLog;

		[Range(0f, 1f)]
		[SerializeField]
		private float switchVolume;

		[SerializeField]
		private AudioClip[] switchAvatar;

		[SerializeField]
		[Range(0f, 1f)]
		private float addAvatarVolume;

		[SerializeField]
		private AudioClip[] addAvatar;

		[SerializeField]
		[Range(0f, 1f)]
		private float retractVolume;

		[SerializeField]
		private AudioClip[] retractShort;

		[SerializeField]
		private AudioClip[] retractLong;

		private ManagedAudioPlayer _map0;

		private ManagedAudioPlayer _map1;

		private ManagedAudioPlayer _map2;

		private ManagedAudioPlayer _map3;

		private ManagedAudioPlayer _map4;

		[Header("Haptics")]
		public int hapticsPerIncrement;

		[SerializeField]
		[Range(0f, 1f)]
		private float incrementAmplitudeMin;

		[SerializeField]
		[Range(0f, 1f)]
		private float incrementAmplitudeMax;

		[Range(0f, 2000f)]
		[SerializeField]
		private float incrementFrequencyMin;

		[SerializeField]
		[Range(0f, 2000f)]
		private float incrementFrequencyMax;

		[SerializeField]
		[Range(0f, 1f)]
		private float incrementDurationMin;

		[Range(0f, 1f)]
		[SerializeField]
		private float incrementDurationMax;

		[Header("Avatars")]
		public AvatarCrateReference[] avatarCrateRefs;

		[Header("Preview Hologram")]
		public Transform preivewMeshRoot;

		public Transform previewMeshPosition;

		public Transform previewMeshSpin;

		public Transform previewMeshRock;

		public MeshFilter previewBounds;

		public MeshFilter previewMesh;

		public MeshRenderer previewMeshRenderer;

		public Transform previewPoint;

		public float previewMeshScaleTune;

		public float previewMeshSpinSpeed;

		public float previewMeshSpinAmp;

		public float previewMeshRockSpeed;

		public float previewMeshRockAmp;

		[Header("General Settings")]
		public bool lookMode;

		public bool leftHanded;

		[Range(-1f, 1f)]
		public float lookDot;

		[Range(0.05f, 1f)]
		public float handShowDist;

		public float armLengthMultiplier;

		public AnimationCurve hologramScaleCurve;

		public AnimationCurve hologramShaderCurve;

		public float hologramAnimLength;

		public Vector3 hologramAnimDisplacement;

		[Range(0f, 1f)]
		public float retractSpeed;

		[Header("Joint Settings")]
		public Vector3 jointLimitMin;

		public Vector3 jointLimitMax;

		public Vector3 jointMinDrive;

		public Vector3 jointMaxDrive;

		public Vector3 jointReturnDrive;

		public AnimationCurve jointDetentCurve;

		[Header("Avatar Add Setting")]
		public AnimationCurve addAvatarCurve;

		public AnimationCurve addAvatarOffCurve;

		public AnimationCurve addAvatarFlickerCurve;

		public RigManager rm;

		public bool isHandleInReceiver;

		public bool isBallInReceiver;

		public Transform receiverTransform;

		public bool bodyLogFirstUse;

		private SlotContainer _slotContainer;

		private bool _bodyLogEnabled;

		private bool ballShown;

		private bool ballHeld;

		private float dist;

		private float remap;

		private float detent;

		private float resistance;

		private float subRemap;

		private float subDetent;

		private int avatarIndex;

		private int lastAvatarIndex;

		private int detentIndex;

		private int lastDetentIndex;

		private JointDrive drive;

		private Vector3 jointDriverTarget;

		private SoftJointLimit jointLimit;

		private Vector3 deviceScale;

		private bool hasIncrementedDetent;

		private bool hasIncrementedSegment;

		private IEnumerator anchorCoroutine;

		private bool anchorLerp;

		private float cashedResistance;

		private int lastTickNumber;

		private float lastDist;

		private Vector3 jointDriver;

		private Vector3 driveVel;

		private IEnumerator hologramCoroutine;

		private float scanLineSize;

		private float depthFade;

		private Color hologramTint;

		private float spinTime;

		private float rockTime;

		private SpawnableCrate[] previewMeshCrates;

		private static readonly int EmissionColor;

		private static readonly int DepthFader;

		private static readonly int ScanlineSize;

		private Transform cameraRef;

		private float ballMass;

		private IEnumerator ballRetraction;

		private bool canShowBall;

		private IEnumerator addAnimation;

		private SpawnableCrate avatarAddPreviewMeshCrate;

		private Vector3 avatarAddLocation;

		private IEnumerator avatarTransformationSequence;

		private float handDist;

		private float armLength;

		private List<string> defaultFavoriteAvatarsBarcodes;

		public bool bodyLogEnabled
		{
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void SetBodySegment()
		{
		}

		private void Update()
		{
		}

		private void OnBallGripAttached(Hand hand)
		{
		}

		private void OnBallGripDetached(Hand hand)
		{
		}

		private void OnBallGripUpdate(Hand hand)
		{
		}

		public void BodyVitalsUpdateEvent()
		{
		}

		[IteratorStateMachine(typeof(_003CHologramAnimation_003Ed__151))]
		private IEnumerator HologramAnimation()
		{
			return null;
		}

		public void ForceAvatarChange(AvatarCrateReference avatarRef, int stopIndex = -1)
		{
		}

		[IteratorStateMachine(typeof(_003CAvatarTransformationSequence_003Ed__153))]
		private IEnumerator AvatarTransformationSequence(AvatarCrateReference avatarRef, int stopIndex = -1)
		{
			return null;
		}

		public void AddAvatarToPCD(Transform addPosition, SpawnableCrate addCrate)
		{
		}

		[IteratorStateMachine(typeof(_003CAddAvatarAnimation_003Ed__155))]
		private IEnumerator AddAvatarAnimation(Transform addPosition, SpawnableCrate addCrate)
		{
			return null;
		}

		public void EnableBall()
		{
		}

		private void DisableBall()
		{
		}

		private void ResetBall()
		{
		}

		[IteratorStateMachine(typeof(_003CRetractBall_003Ed__159))]
		private IEnumerator RetractBall(bool quiet = false)
		{
			return null;
		}

		private void JointToWorld()
		{
		}

		public void BreakWorldJoint()
		{
		}

		public void BreakWorldJointHand()
		{
		}

		private void SetJointDrives(Vector3 settings)
		{
		}

		private void SetJointLimits(Vector3 settings)
		{
		}

		public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
		{
			return default(Vector3);
		}

		[IteratorStateMachine(typeof(_003CLerpAnchor_003Ed__166))]
		private IEnumerator LerpAnchor(float lerpTime)
		{
			return null;
		}

		private void HapticEvent(float driver)
		{
		}

		public void BodyMallUpdate()
		{
		}

		private void LoadFavoriteAvatars()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateAllPreviewMeshes_003Ed__170))]
		private UniTaskVoid UpdateAllPreviewMeshes()
		{
			return default(UniTaskVoid);
		}

		private void SetPreviewMesh(int crateIndex)
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__172))]
		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrateRef)
		{
			return default(UniTaskVoid);
		}

		private void PlayAvatarParticleEffects()
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}
