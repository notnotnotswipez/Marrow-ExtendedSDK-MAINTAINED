using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[Obsolete("Superseded by VoidLogic")]
	[AddComponentMenu(null)]
	public class Convert_Voltage : OnOffSwitch
	{
		[Space(5f)]
		[Header("SETTINGS")]
		[Tooltip("Lever can be an OnOff Switch or -1,0,1 float")]
		public bool operation_Float;

		[Tooltip("Will return Lever to center position on letgo")]
		public bool operation_Momentary;

		private float voltage;

		public void INCOMINGVOLTAGE(float volts)
		{
		}

		private void CIRCUIT()
		{
		}
	}
}
