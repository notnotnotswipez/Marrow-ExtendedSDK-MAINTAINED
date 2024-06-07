using UnityEngine;

namespace SLZ.MLAgents
{
	public class HeightThruster : MonoBehaviour
	{
		public Vector3 baseThrustVector;

		[Tooltip("Distance to hover above starting height")]
		public float hoverHeight;

		[Tooltip("Strength of ground distance target force (weight of rb is pulled in calc of force)")]
		public float hoverMod;

		[Tooltip("Strength of velocity dampen force")]
		public float velDifMod;

		[Tooltip("Min positive velocity for dampen force to trigger")]
		public float upperVelThresh;

		[Tooltip("Min negative velocity for dampen force to trigger")]
		public float lowerVelThresh;

		[Tooltip("Offset value used in groundDistance calculation (set on start)")]
		public float startHeight;

		[Tooltip("Derived value used in force calculation to get object to hover height")]
		public float currentGroundDistance;

		[Tooltip("Rigidbody the thruster is connected to")]
		public Rigidbody parentRb;

		[Tooltip("Controls how the weight value is calculated")]
		public bool gravityBool;

		[Tooltip("Whether to dampen positive velocity (prevent trampoline)")]
		public bool dampUpper;

		[Tooltip("Whether to dampen negative velocity (prevent trampoline)")]
		public bool dampLower;

		[Tooltip("Whether to block thrust completely")]
		public bool blockingThrust;

		[Tooltip("Whether to block force pulling to target hover height")]
		public bool blockPullForce;

		[Tooltip("Additional force to add to hover force")]
		private Vector3 slowForce;

		public bool debugLog;

		private float weight;

		public void SetHoverHeight(float val)
		{
		}

		public void SetHoverMod(float val)
		{
		}

		public void SetVelDifMod(float val)
		{
		}

		public void SetUpperVelThresh(float val)
		{
		}

		public void SetLowerVelThresh(float val)
		{
		}

		public void SetStartHeight(float val)
		{
		}

		public void SetGravityBool(bool val)
		{
		}

		public void SetUpDamper(bool val)
		{
		}

		public void SetLowDamper(bool val)
		{
		}

		public void SetBlockThrust(bool val)
		{
		}

		public void SetBlockPullForce(bool val)
		{
		}

		private void SetFromConfig()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CalcGroundDistance()
		{
		}

		public void HandleHoverForce()
		{
		}
	}
}
