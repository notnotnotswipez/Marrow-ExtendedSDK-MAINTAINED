using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[AddComponentMenu(null)]
	[Obsolete("Superseded by VoidLogic")]
	public class PowerSource : MonoBehaviour
	{
		[SerializeField]
		private bool m_InfinitePower;

		[Tooltip("The Capcity of the PowerSource in Watts-min")]
		[Header("VOLTAGE")]
		[SerializeField]
		[Space(5f)]
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
