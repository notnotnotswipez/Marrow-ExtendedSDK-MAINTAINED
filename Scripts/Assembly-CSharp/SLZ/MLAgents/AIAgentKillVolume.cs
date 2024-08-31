using System;
using System.Collections.Generic;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class AIAgentKillVolume : MonoBehaviour
	{
		private void OnTriggerEnter(Collider other)
		{
		}

		public AIAgentKillVolume()
		{
		}

		private AIBrain tempAgent;

		private TriggerRefProxy tempTrp;

		private Dictionary<AIBrain, double> lastBrainUseage;
	}
}
