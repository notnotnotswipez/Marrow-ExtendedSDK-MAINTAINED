using UnityEngine;

namespace SLZ.MLAgents
{
	[CreateAssetMenu(fileName = "VehicleData", menuName = "StressLevelZero / VehicleData", order = 1)]
	public class VehicleSettings : ScriptableObject
	{
		[Header("Wheel Frictions Forward")]
		public float forwardExtremumSlip;

		public float forwardExtremumValue;

		public float forwardAsymptoteSlip;

		public float forwardAsymptoteValue;

		[Header("Wheel Frictions Sideways")]
		public float sidewaysExtremumSlip;

		public float sidewaysExtremumValue;

		public float sidewaysAsymptoteSlip;

		public float sidewaysAsymptoteValue;
	}
}
