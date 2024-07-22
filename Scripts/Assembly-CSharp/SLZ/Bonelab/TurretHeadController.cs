using SLZ.Marrow;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TurretHeadController : MonoBehaviour
	{
		public enum FireType
		{
			Cartridge = 0,
			GachaLauncher = 1
		}

		[Header("Settings")]
		public FireType fireType;

		public float rotationSpeed;

		[Header("References")]
		public Transform firePointTransform;

		public Spawnable muzzleFlareSpawnable;

		public GunSFX gunSfx;

		public Rigidbody rb;

		public ConfigurableJoint joint;

		public Transform rootArtTransform;

		public Transform pitchArtTransform;

		public Transform yawArtTransform;

		public Transform rollArtTransform;

		[Header("Projectile References")]
		public CartridgeData cartridge;

		[Header("Gacha Launcher Settings")]
		public float launchSpeed;

		public float launchAngularSpeed;

		public Spawnable gachaProjectileSpawnable;

		public Spawnable gachaSpawnable;

		public ChopperSequenceController_LongRun optionalChopperContoller;

		public Transform optionalSpawnDirection;

		private Quaternion _startRotation;

		private Quaternion _targetRotation;

		private Quaternion _initalTargetRotation;

		private Quaternion _initalRbRotation;

		private Vector3 _initalRbPosition;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void LookAt(Vector3 worldPos)
		{
		}

		public void Fire()
		{
		}

		private void Update()
		{
		}
	}
}
