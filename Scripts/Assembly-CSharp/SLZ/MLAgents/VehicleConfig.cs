using System;
using UnityEngine;

namespace SLZ.MLAgents
{
	[Serializable]
	[CreateAssetMenu(fileName = "VehicleConfig", menuName = "VehicleConfig", order = 1)]
	public class VehicleConfig : ScriptableObject
	{
		public float maxTorque;

		public float maxReverseTorque;

		public float maxBrakeTorque;

		public float maxSteerAngle;

		public int NoOfGears;

		public float downForce;

		public float topSpeed;

		public float topReverseSpeed;
	}
}
