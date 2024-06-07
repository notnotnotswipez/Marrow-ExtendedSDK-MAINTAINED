using UnityEngine;

namespace SLZ.MLAgents
{
	public class HeightThrustPointManager : MonoBehaviour
	{
		public Rigidbody parentRb;

		[Tooltip("If all thrusters are active")]
		public bool activated;

		[Tooltip("Distance to hover above starting height")]
		public float hoverHeight;

		[Tooltip("Drag your height thrusters here")]
		public HeightThruster[] y_neg_thrusters;

		[Tooltip("Strength of ground distance target force")]
		public float hoverMod;

		[Tooltip("Strength of velocity dampen force")]
		public float velDifMod;

		[Tooltip("Min positive velocity for dampen force to trigger")]
		public float upperVelThresh;

		[Tooltip("Min negative velocity for dampen force to trigger")]
		public float lowerVelThresh;

		[Tooltip("Offset value used in groundDistance calculation (set on start)")]
		public float startHeight;

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

		[Tooltip("Whether to limit the velocity on the parent rigidbody")]
		public bool speedGovern;

		[Tooltip("Way to limit the velocity on the parent rigidbody")]
		public float maxVelMag;

		private Vector3 maxVel;

		private Vector3 velError;

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

		private void DeactivateThrusters(HeightThruster[] thrusters)
		{
		}

		public void DeactivateAll()
		{
		}

		public void ActivateAll()
		{
		}

		public void ActivateThrusters(HeightThruster[] thrusters)
		{
		}

		private void Start()
		{
		}

		private void CallSetAll()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
