using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LocoController : MonoBehaviour
{
	[Tooltip("The art representing the Tether")]
	public GameObject tetherObject;

	[Tooltip("To use keyboard control")]
	public bool heuristicMode;

	[Tooltip("To use GamePad Controller")]
	public bool useGamePad;

	[Header("Movement Type Switches")]
	public bool canBack;

	public bool canFront;

	public bool canLeft;

	public bool canRight;

	public bool canUp;

	public bool canDown;

	public bool canRollLeft;

	public bool canRollRight;

	public bool canPitchUp;

	public bool canPitchDown;

	public bool canYawLeft;

	public bool canYawRight;

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
	public float forward;

	public float backward;

	public float left;

	public float right;

	public float up;

	public float down;

	public float yawLeft;

	public float yawRight;

	public float pitchUp;

	public float pitchDown;

	public float rollRight;

	public float rollLeft;

	public int action1;

	public int action2;

	public int action3;

	public int action4;

	public int action5;

	public int action6;

	public int action7;

	public int action8;

	[Header("Game Pad Input Values")]
	public float horizontal;

	public float vertical;

	public float rightHorizontal;

	public float rightVertical;

	public bool aButton;

	public bool bButton;

	public bool xButton;

	public bool yButton;

	public float dPadHorizontal;

	public float dPadVertical;

	public float leftTrigger;

	public float rightTrigger;

	public bool leftBumper;

	public bool rightBumper;

	private Color centerColor;

	private Color bubbleColor;

	private Color tetherColor;

	private float controllerRadius;

	public bool flatMode;

	public event Action inputUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ControlInput(float f, float b, float l, float r, float u, float d, float pu, float pd, float yl, float yr, float rl, float rr)
	{
	}

	private void Update()
	{
	}

	private void CollectGamePadData()
	{
	}
}
