using UnityEngine;

public class TetherController : MonoBehaviour
{
	[Tooltip("The art representing the Teather")]
	public GameObject tetherObject;

	[Tooltip("To use keyboard control")]
	public bool heuristicMode;

	[Header("Movement Type Switches")]
	public bool canBackwards;

	public bool canForwards;

	public bool canRoll;

	public bool canPitch;

	public bool canYaw;

	[Header("Default States")]
	[Tooltip("Position the controller will want to return to")]
	public Vector3 defaultPosition;

	[Tooltip("Rotation the controller will want to return to")]
	public Quaternion defaultRotation;

	[Tooltip("Tether Position to go towards")]
	public Vector3 updatePosition;

	[Tooltip("Tether Rotation to go towards")]
	public Vector3 updateRotation;

	[Tooltip("Current Tether Position")]
	public Vector3 tetherPosition;

	[Tooltip("Current Tether Rotation")]
	public Quaternion tetherRotation;

	[Tooltip("Update Rate for Position Translation")]
	public float positionLerpRate;

	[Tooltip("Update Rate for Rotation Translation")]
	public float rotationLerpRate;

	[Header("Input Values")]
	public int forward;

	public int backward;

	public int yawLeft;

	public int yawRight;

	public int pitchUp;

	public int pitchDown;

	public int rollRight;

	public int rollLeft;

	private Color centerColor;

	private Color bubbleColor;

	private Color tetherColor;

	private float controllerRadius;

	private void OnDrawGizmos()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}
}
