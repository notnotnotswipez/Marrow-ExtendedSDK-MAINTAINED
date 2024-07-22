using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[AddComponentMenu(null)]
	[Obsolete("OLD POWERABLE SYSTEM - DO NOT USE!")]
	public class PowerSource : MonoBehaviour
	{
		[SerializeField]
		private bool m_InfinitePower;

		[Header("VOLTAGE")]
		[Space(5f)]
		[Tooltip("The Capcity of the PowerSource in Watts-min")]
		[SerializeField]
		private float m_Capacity;

		[Tooltip("Only for reading, functions for charging/drawing should be the mutator")]
		public float BatteryCharge;

		public bool InfinitePower => false;

		public float Capacity => 0f;

		public bool CanCharge => false;

		public void LOADCURRENTCHARGE(float savedCharge)
		{
		}
	}
}
