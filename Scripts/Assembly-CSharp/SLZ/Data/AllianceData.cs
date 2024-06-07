using System;
using UnityEngine;

namespace SLZ.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "NPC_Alliance_Data", menuName = "StressLevelZero / AllianceData", order = 1)]
	public class AllianceData : ScriptableObject
	{
		public string species;

		public float agression;
	}
}
