using UnityEngine;

namespace SLZ.MLAgents
{
	public class Thruster : MonoBehaviour
	{
		public bool isActive;

		public float hoverHeight;

		public bool preventDestCrash;

		public float crashDistanceThreshold;

		public float rayCastLength;

		public Transform groundCastTrans;

		public float currentGroundDistance;

		private float groundDifference;

		private float normalizedHover;

		private float weight;

		public Rigidbody parentRb;

		public bool gravityBool;

		public Vector3 baseThrustVector;

		private Vector3 newThrustVector;

		public bool blockingHoverThrust;

		public bool blockPullForce;

		public float hoverMod;

		public float destMod;

		public float stoppingMod;

		public int layer_mask;

		public int[] excludeLayerMask;

		public Vector3 finalHoverForce;

		public Vector3 finalDestinationForce;

		public Vector3 stoppingForce;

		public float additionalMass;

		public string rayIgnoreTag;

		public int noCollideLayer;

		public Thruster opposingThruster;

		public bool trackRb;

		private Vector3 mountingPoint;

		private int axisInd;

		private Vector3 thrustAxis;

		public bool debugLog;

		public bool calcGroundDist;

		private Vector3 tempRot;

		private void Start()
		{
		}

		public void UpdateWeight()
		{
		}

		private void FixedUpdate()
		{
		}

		public float GetBreakVelocity(float distance)
		{
			return 0f;
		}

		public float GetBreakingDistance(float velocity)
		{
			return 0f;
		}

		public float GetStoppingForce(float distance, float velocity)
		{
			return 0f;
		}

		private void CalcGroundDistance()
		{
		}

		private void HandleHoverForce()
		{
		}

		public void StoppingForce()
		{
		}

		public void HandleDestinationForce(float sign, float destError)
		{
		}

		public void HandleVelocityError(float velError)
		{
		}
	}
}
