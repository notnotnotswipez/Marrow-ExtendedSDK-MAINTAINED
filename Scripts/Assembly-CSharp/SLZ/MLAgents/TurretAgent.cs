using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TurretAgent : Agent
	{
		public TurretArea turretArea;

		public GameObject head;

		public bool useHitReward;

		public bool useMissPenalty;

		public bool endEpOnMiss;

		public float hitReward;

		public float killReward;

		public float missPenalty;

		public float shootInterval;

		public float bulletSpeed;

		public float min_x_rot;

		public float max_x_rot;

		public float max_y_rot;

		public float min_y_rot;

		public GameObject bullet_prefab;

		public GameObject bullet_spawn;

		public ObjectPool BulletPool;

		public int nb_bullets;

		private float episodeLength;

		private Rigidbody _rb;

		private bool canShoot;

		private float shootCoolDown;

		private Vector3 bulletSpawnLoc;

		[HideInInspector]
		public float killCount;

		[HideInInspector]
		public float missCount;

		private int barrelLayerMask_1;

		private int barrelLayerMask_2;

		private int barrelLayerMask_3;

		public int finalMask;

		private RaycastHit barrelOnTarget;

		public float max_barrel_distance;

		private float lookingAtTarget;

		public BufferSensorComponent m_BufferSensor;

		public bool use_buffer_sensor;

		public TurretBufferManager buffer_manager;

		private void TurretReset()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private float CheckBarrelRay()
		{
			return 0f;
		}

		private void RecenterTurret()
		{
		}

		public void RewardOnHit()
		{
		}

		public virtual void OnMiss()
		{
		}

		public void KillConfirmed()
		{
		}

		private void ManageCoolDown()
		{
		}

		private void ShootBullet()
		{
		}

		private float NormRot(float rot)
		{
			return 0f;
		}

		private void MovementSignal(float x_val, float y_val)
		{
		}
	}
}
