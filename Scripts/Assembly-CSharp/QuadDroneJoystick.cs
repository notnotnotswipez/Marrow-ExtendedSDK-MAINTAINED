using SLZ.MLAgents;
using SLZ.Marrow;
using UnityEngine;

public class QuadDroneJoystick : MonoBehaviour
{
	public BallThrustPointManager thrustMngr;

	public float maxControlRadius;

	public float maxJoyOffset;

	public Rigidbody joyRb;

	public Rigidbody droneRb;

	public bool drawGizmos;

	public bool ballHeld;

	[Header("Grips")]
	public Grip ballGrip;

	public ConfigurableJoint ballDroneJoint;

	public ConfigurableJoint droneBallJoint;

	public Collider ballGripCollider;

	public Collider ballGripCollider2;

	public float distanceBreak;

	public float torqueMod;

	private Vector3 joystickOffset;

	private Vector3 joyCenterPos;

	private Vector3 joyDelta;

	private Color centerColor;

	private Color joyDirectionColor;

	private Color joyTransformColor;

	private JointDrive ballDroneCachedDrive;

	private JointDrive droneBallCachedDrive;

	private JointDrive tempDrive;

	private SoftJointLimit ballDroneCachedLimit;

	private SoftJointLimit droneBallCachedLimit;

	private SoftJointLimit tempLinearLimit;

	private SoftJointLimitSpring ballDroneCachedSpringLimit;

	private SoftJointLimitSpring droneBallCachedSpringLimit;

	private SoftJointLimitSpring tempSpringLimit;

	private void OnDrawGizmos()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void SetJointDrives(ConfigurableJoint joint, JointDrive tempDrive)
	{
	}

	private void SetJointLimits(ConfigurableJoint joint, SoftJointLimit limit, SoftJointLimitSpring springLimit)
	{
	}

	private void OnBallGripAttached(Hand hand)
	{
	}

	private void OnBallGripDetached(Hand hand)
	{
	}

	private void OnBallGripUpdate(Hand hand)
	{
	}
}
