using UnityEngine;

public class CounterTorque : MonoBehaviour
{
	public Rigidbody droneRb;

	public GameObject forwardObj;

	public GameObject destination;

	public bool useOpposing;

	public float opposeFactor;

	public bool useUpright;

	public float uprightFactor;

	public float minXZAngle;

	public float maxXZAngle;

	public bool scaleUpright;

	public bool scaleUprightGrabOnly;

	public float maxScaleFactor;

	public float uprightMod;

	public bool rotateTowardsMovement;

	public float forwardVelThresh;

	public float forwardAdjustFactor;

	public bool tiltTowardsMovement;

	public float tiltStrength;

	public float maxVel;

	public float tiltDistanceScale;

	public float tiltMod;

	public bool tiltLock;

	public float maxDistance;

	public float normDistance;

	public bool useCounterThrust;

	public float minCounterDistance;

	public float counterThrustPerc;

	public float counterThrustDistance;

	public float additionalMass;

	public float maxAdditionalMass;

	public float maxWeightModifier;

	private float weight;

	private float initialWeight;

	private float weightRatio;

	private Vector3 upAxis;

	private float upAngle;

	private Quaternion upDeltaQuat;

	private float maxRot;

	private float normRot;

	private float additionalUp;

	private Vector3 forwardAxis;

	private float forwardAngle;

	private Quaternion forwardDeltaQuat;

	private Vector3 tempVelocity;

	private Vector3 opposingTorque;

	private Vector3 uprightTorque;

	private Vector3 velocityForwardTorque;

	private Vector3 tiltForwardTorque;

	private Quaternion tiltQuat;

	private Vector3 tiltAxis;

	private float tiltAngle;

	private bool counterTilt;

	private float counterDistNorm;

	private float rawDistance;

	private Vector3 tempDest;

	private float normVel;

	private void Awake()
	{
	}

	private void OpposeTorque()
	{
	}

	private void UprightTorque()
	{
	}

	private void VelocityForwardTwist()
	{
	}

	private void TiltForwardTorque()
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateWeight()
	{
	}
}
