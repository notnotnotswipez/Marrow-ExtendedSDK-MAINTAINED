using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class Manager_Circuit : MonoBehaviour
	{
		[Space(5f)]
		[Header("ELECTRONICS")]
		[Tooltip("Used if you don't want a powerSource connected.")]
		public bool isPowerSource;

		[Tooltip("The minumum voltage required to power this circuit")]
		public float MinimumVoltage;

		public float TotalVoltage;

		[Space(3f)]
		public List<PowerSocket> PowerSockets;

		public List<Powerable> Electronics;

		[Tooltip("Checked if you want it to only work with a specific Power Source.")]
		[Header("SPECIFIC POWERSOURCE")]
		[Space(10f)]
		public bool SpecificPSMode;

		public bool hasPowerSources => false;

		public bool isInfinitePower => false;

		public bool hasReqCharge => false;

		private void Awake()
		{
		}

		public void CurrentOnOff(bool isOn)
		{
		}

		public void DestroyedPowerable(Powerable obj)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
