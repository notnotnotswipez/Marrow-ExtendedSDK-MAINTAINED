using Unity.MLAgents;
using UnityEngine;

namespace Unity.MLAgentsExamples
{
	[DisallowMultipleComponent]
	public class GroundContact : MonoBehaviour
	{
		[HideInInspector]
		public Agent agent;

		[Header("Ground Check")]
		public bool agentDoneOnGroundContact;

		public bool penalizeGroundContact;

		public float groundContactPenalty;

		public bool touchingGround;

		private const string k_Ground = "ground";

		private void OnCollisionEnter(Collision col)
		{
		}

		private void OnCollisionExit(Collision other)
		{
		}
	}
}
