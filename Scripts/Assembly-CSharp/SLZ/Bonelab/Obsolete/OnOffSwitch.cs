using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[Obsolete("OLD POWERABLE SYSTEM - DO NOT USE!")]
	[AddComponentMenu(null)]
	public class OnOffSwitch : MonoBehaviour
	{
		public Powerable[] ElectricalObj;

		private void Awake()
		{
		}

		public virtual void OnOffEvent(bool isOn)
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
