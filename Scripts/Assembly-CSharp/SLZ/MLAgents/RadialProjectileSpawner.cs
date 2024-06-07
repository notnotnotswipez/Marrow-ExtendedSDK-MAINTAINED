using UnityEngine;

namespace SLZ.MLAgents
{
	public class RadialProjectileSpawner : MonoBehaviour
	{
		private BoidBallManager mngr;

		public ObjectPool BulletPool;

		public GameObject projectile;

		public int amountToPool;

		public float proj_speed;

		public float proj_scale;

		private bool canShoot;

		private float shootCoolDown;

		public float shootInterval;

		private float positionCoolDown;

		public float positionInterval;

		public float shootRadius;

		public float shootRadiusMin;

		public float shootRadiusMax;

		public bool rndmShootRadius;

		private Vector3 shootingPosition;

		private Quaternion shootingRotation;

		private Vector3 unitPosition;

		private void Start()
		{
		}

		private void GetRadialPosition()
		{
		}

		private void Update()
		{
		}

		private void ShootBullet(Vector3 pos, Quaternion euler_rot)
		{
		}

		private void ManageCoolDown()
		{
		}
	}
}
