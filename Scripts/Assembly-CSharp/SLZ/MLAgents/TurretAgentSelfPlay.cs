using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TurretAgentSelfPlay : TurretAgent
	{
		private float episodeLength;

		private Rigidbody _rb;

		private bool canShoot;

		private float shootCoolDown;

		private Vector3 bulletSpawnLoc;

		private int barrelLayerMask_1;

		private int barrelLayerMask_2;

		private int barrelLayerMask_3;

		private new int finalMask;

		private RaycastHit barrelOnTarget;

		private float lookingAtTarget;

		public TurretAreaSelfPlay turretArea_SP;

		private void Start()
		{
		}

		public override void OnMiss()
		{
		}

		private void TurretReset()
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

		public void OnWin()
		{
		}

		public void OnLoss()
		{
		}

		public void OnTie()
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
