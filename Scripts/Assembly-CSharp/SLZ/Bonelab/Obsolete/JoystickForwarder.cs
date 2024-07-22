using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[Obsolete("Uses old Powerable system.")]
	public class JoystickForwarder : MonoBehaviour
	{
		public Powerable[] xObjs;

		public Powerable[] yObjs;

		public Powerable[] zObjs;

		private float lastZVoltage;

		[Tooltip("The size of center swtich dead zone where output will be 0, 0 is no dead zone.")]
		public float deadZoneSize;

		public bool canForward;

		public void JOYSTICK(PropJoystick.JoystickData joystickData)
		{
		}

		public void LEVER(float leverData)
		{
		}

		private void Update()
		{
		}

		private void SendVoltage(Powerable[] objs, float voltage)
		{
		}
	}
}
