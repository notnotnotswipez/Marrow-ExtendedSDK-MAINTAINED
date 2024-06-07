using UnityEngine;

namespace SLZ.MLAgents
{
	public class HeightThruster1 : MonoBehaviour
	{
		public float thrustValue;

		public bool thrustOverride;

		public float minHover;

		public float maxHover;

		public float hoverHeight;

		public float maxHeightVelocity;

		public float currentGroundDistance;

		public float maxSpeed;

		private float weight;

		public Vector2 thrustDir;

		public Rigidbody parentRb;

		public bool gravityBool;

		public Vector3 baseThrustVector;

		public bool blockingThrust;

		public bool blockPullForce;

		public float hoverMod;

		public float startHeight;

		public bool useSigmoidDecay;

		public float minVel;

		public float maxVel;

		public float velMod;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CalcGroundDistance()
		{
		}

		public static float Sigmoid(double value)
		{
			return 0f;
		}

		private float MinMaxPolar(float val, float min, float max)
		{
			return 0f;
		}

		private void HandleHoverForce()
		{
		}

		public void HandleVelocityError(float velError)
		{
		}
	}
}
