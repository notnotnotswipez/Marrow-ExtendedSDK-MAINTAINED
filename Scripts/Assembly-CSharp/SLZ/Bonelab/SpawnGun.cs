using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnGun : Gun
	{
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

		public void FlashScreen()
		{
		}

		private IEnumerator CoFireFlash()
		{
			return null;
		}

		private void SetPreviewMesh()
		{
		}

		private UniTaskVoid SpawnCrate([Optional] Vector3 position, [Optional] Quaternion rotation, [Optional] Action<GameObject> callback)
		{
			return default(UniTaskVoid);
		}

		public SpawnGun()
		{
		}

		[Header("Spawn Options")]
		[SerializeField]
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

		[SerializeField]
		[Header("Audio")]
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
	}
}
