using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidBumper : MonoBehaviour
	{
		public bool castAll;

		public BoidController boidController;

		[Tooltip("Rigidbody to apply forces onto")]
		public Rigidbody _rb;

		[Tooltip("Force Magnifier")]
		public float reflectForce;

		[Tooltip("Dampen the current velocity")]
		public float dampenFactor;

		[Tooltip("Size of spherecast")]
		public float maxRayDistance;

		[Tooltip("Layers that will trigger a bumper response")]
		public int[] detectableLayers;

		[Tooltip("Max number of detections per cast")]
		public int maxColliders;

		[Tooltip("How many fixed updates to wait till the next cast")]
		public int fixedUpdateDelay;

		public bool drawGizmos;

		public RaycastHit[] tempRayHits;

		public RaycastHit[] directionalRayHits;

		private int numColliders;

		private int fixedCounter;

		private int layerMask;

		private Vector3 collisionPosition;

		private Vector3 reflectVel;

		private Color gizmoColor;

		public Vector3[] directions;

		private int directionCounter;

		private bool blockForce;

		public float anglePerc;

		private Vector3 reflect_vel;

		private Vector3 force;

		private void OnDrawGizmos()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionStay(Collision collision)
		{
		}

		protected void CastRay(int ind, Vector3 direction)
		{
		}

		protected void CastAllRays()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
