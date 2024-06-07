using SLZ.Marrow.Interaction;
using UnityEngine;

public class SplineDriverToggle : MonoBehaviour
{
	public SplineJoint[] splineJoints;

	[Header("LinearXDrive Speed/Damper/MaxForce")]
	public Vector3 minLinearXDrivers;

	public Vector3 maxLinearXDrivers;

	public bool setMinOnAwake;

	private bool toggle;

	public void Awake()
	{
	}

	public void ToggleDriver()
	{
	}
}
