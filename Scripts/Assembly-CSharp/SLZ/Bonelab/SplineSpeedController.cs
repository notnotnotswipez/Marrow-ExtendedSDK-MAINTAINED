using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineSpeedController : MonoBehaviour
	{
		public SplineBody splineBody;

		public Rigidbody turretRb;

		public Rigidbody baseRb;

		public GameObject currentObjective;

		public float targetVel;

		private Vector3 previousTargetPos;

		[Tooltip("velocity to go when outside of zone")]
		public float outerVelScale;

		[Tooltip("distance away from target to activate pid controller")]
		public float activationDistance;

		[Tooltip("Min velocity the target has to be going for velocity match, otherwise use min vel")]
		public float minTargetVel;

		[Tooltip("Radius of area to repell spline body away from target")]
		public float distanceBuffer;

		private float currentDistance;

		private Vector3 distanceVector;

		private float lastDistance;

		private int direction;

		private void OnDrawGizmos()
		{
		}

		private void Awake()
		{
		}

		public void FixedUpdate()
		{
		}

		private void GetTargetVel()
		{
		}

		private void CheckZone()
		{
		}
	}
}
