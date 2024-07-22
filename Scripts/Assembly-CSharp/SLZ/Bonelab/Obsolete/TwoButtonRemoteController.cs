using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[Obsolete("OLD POWERABLE SYSTEM - DO NOT USE!")]
	[AddComponentMenu(null)]
	public class TwoButtonRemoteController : OnOffSwitch
	{
		private float voltage;

		private float lastVoltage;

		public void ENERGIZEJOINT()
		{
		}

		public void ENERGIZEJOINTNEGATIVE()
		{
		}

		public void DEENERGIZEJOINT()
		{
		}

		private void Update()
		{
		}
	}
}
