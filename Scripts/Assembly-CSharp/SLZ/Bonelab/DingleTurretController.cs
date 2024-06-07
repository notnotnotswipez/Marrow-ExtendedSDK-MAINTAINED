using UnityEngine;

namespace SLZ.Bonelab
{
	public class DingleTurretController : MonoBehaviour
	{
		public SplineBody splineBody;

		public TurretHeadController turret;

		public Transform testTarget;

		public float fireRate;

		private float _lastFireTime;

		private void Update()
		{
		}
	}
}
