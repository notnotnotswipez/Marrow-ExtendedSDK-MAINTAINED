using UnityEngine;

namespace SLZ.MLAgents
{
	public class FollowTaskContestant : Contestant
	{
		[HideInInspector]
		public BaseVehicle_SlicedTrainer trainingAgent;

		[Tooltip("Where amongst other contestants does this one place during/at the end of a race")]
		public int standing;

		[Tooltip("The race task that this contestant belongs to")]
		public TrackFollowTaskClass followTask;

		[Tooltip("Whether to set the reward to -1 for an agent when it fails the task and is respawned")]
		public bool penalizeOnReset;

		public float startLength;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected override void TimeoutTicker()
		{
		}

		private void FixedUpdate()
		{
		}

		public override void SoftReset()
		{
		}

		public void UpdateProxRadius(float radius)
		{
		}

		public void UpdateGoalRadius(float radius)
		{
		}
	}
}
