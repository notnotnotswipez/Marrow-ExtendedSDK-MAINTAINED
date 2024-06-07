using System;
using UnityEngine;

[Serializable]
public class MouseLook
{
	public float XSensitivity;

	public float YSensitivity;

	public bool clampVerticalRotation;

	public float MinimumX;

	public float MaximumX;

	public bool smooth;

	public float smoothTime;

	public bool lockCursor;

	private Quaternion m_CharacterTargetRot;

	private Quaternion m_CameraTargetRot;

	private bool m_cursorIsLocked;

	public void Init(Transform character, Transform camera)
	{
	}

	public void LookRotation(Transform character, Transform camera)
	{
	}

	public void SetCursorLock(bool value)
	{
	}

	public void UpdateCursorLock()
	{
	}

	private void InternalLockUpdate()
	{
	}

	private Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		return default(Quaternion);
	}
}
