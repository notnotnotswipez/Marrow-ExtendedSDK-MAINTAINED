using System.Collections.Generic;

namespace SLZ.MLAgents
{
	public class ASEInferenceAgent_Test : InferenceAgent
	{
		public string ase_latents_name;

		public string state_name;

		public int obsSize;

		public int tensorSize;

		private float[] incomingValues;

		private float[] incomingMus;

		private float[] incomingSigmas;

		protected override void Start()
		{
		}

		public override void Setup()
		{
		}

		public override void OnActionReceived(Dictionary<string, float[]> actionBuffers)
		{
		}

		public override void CollectObservations()
		{
		}
	}
}
