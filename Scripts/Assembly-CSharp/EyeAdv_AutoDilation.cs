using UnityEngine;

public class EyeAdv_AutoDilation : MonoBehaviour
{
	public bool enableAutoDilation;

	public Transform sceneLightObject;

	public float lightSensitivity;

	public float dilationSpeed;

	public float maxDilation;

	private Light sceneLight;

	private float lightIntensity;

	private float lightAngle;

	private float dilateTime;

	private float pupilDilation;

	private float currTargetDilation;

	private float targetDilation;

	private float currLightSensitivity;

	private Renderer eyeRenderer;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
