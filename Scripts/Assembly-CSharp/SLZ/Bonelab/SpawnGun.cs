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
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnGun : Gun
	{
		[CompilerGenerated]
		private sealed class _003CCoFireFlash_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpawnGun _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CCoFireFlash_003Ed__85(int _003C_003E1__state)
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
		private struct _003CSpawnCrate_003Ed__87 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Action<GameObject> callback;

			public SpawnGun _003C_003E4__this;

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

		[SerializeField]
		[Header("Spawn Options")]
		private Spawnable _spawnGunUISpawnable;

		public LayerMask collisionLayers;

		public float effectiveRange;

		public bool wackySpinWhenUpsideDown;

		public bool isDespawnMode;

		public GameObject laserPointerGameObject;

		public Transform previewMeshPosition;

		public Transform previewMeshSpin;

		public Transform previewMeshRock;

		public MeshFilter previewBounds;

		public MeshFilter previewMesh;

		public Transform previewPoint;

		public float previewMeshScaleTune;

		public float previewMeshSpinSpeed;

		public float previewMeshRockSpeed;

		public float previewMeshRockAmp;

		public float xenCrystalSpinSpeed;

		public Transform fanBladesTransform;

		public Transform xenCrystalTransform;

		public AudioClip[] chargeSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		[ColorUsage(true, true)]
		public Color screenPlacerColor;

		[ColorUsage(true, true)]
		public Color screenRemoveerColor;

		public MeshRenderer[] gunBodyRenderers;

		[ColorUsage(true, true)]
		public Color placerValidColor;

		[ColorUsage(true, true)]
		public Color placerInvalidColor;

		public Transform placerRoot;

		public GameObject placerPreview;

		public GameObject placerPreview2;

		public MeshFilter placerPreviewMesh;

		public MeshFilter placerPreviewMesh2;

		public MeshRenderer placerPreivewRenderer;

		public BoxCollider placerPreviewBoxCollider;

		public GameObject placerPreviewBoundsArt;

		public LineRenderer[] placerPreviewBoundsLines;

		public Transform[] boundPoints;

		public float dampTimePos;

		public float dampTimeRot;

		[Header("Audio")]
		[SerializeField]
		private AudioClip[] blip;

		public float blipIncrement;

		private SpawnableCrate _selectedCrate;

		private SpawnableCrate _lastSelectedCrate;

		private bool _isOptionsActive;

		private UtilityModes _selectedMode;

		private RaycastHit _hitInfo;

		private Hand currentHand;

		private float time;

		private Color startColor;

		private ManagedAudioPlayer map;

		private ManagedAudioPlayer map2;

		private bool canFireGunDown;

		private bool placerValid;

		private float colorLerpTime;

		private float screenColorLerpTime;

		private Color targetColor;

		private Color targetScreenColor;

		private Color boundColor;

		private Vector3 lastKneePos;

		private Vector3 kneeOffsetPos;

		private bool wallMode;

		private Vector3 truePlacePosition;

		private Quaternion truePlaceRotation;

		private Vector3 posVelocity;

		private Vector3 lastHitPoint;

		private float accumulatedDist;

		private static readonly int EmissionColor;

		private static readonly int ColorTint;

		private static readonly int FlashCoroutine;

		private Mesh[] loadedMesh;

		private BoneTag playerTag;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		protected override void OnTriggerGripAttached(Hand hand)
		{
		}

		protected override void OnTriggerGripDetached(Hand hand)
		{
		}

		protected void OnSpawnableSelected(SpawnableCrate crate)
		{
		}

		protected void OnModeSelect(UtilityModes mode)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void Fire()
		{
		}

		protected override void OnFire()
		{
		}

		public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
		{
			return default(Vector3);
		}

		public void Flash()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFireFlash_003Ed__85))]
		private IEnumerator CoFireFlash()
		{
			return null;
		}

		private void SetPreviewMesh()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnCrate_003Ed__87))]
		private UniTaskVoid SpawnCrate(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Action<GameObject> callback = null)
		{
			return default(UniTaskVoid);
		}
	}
}
