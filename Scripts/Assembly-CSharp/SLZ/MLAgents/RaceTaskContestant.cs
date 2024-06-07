using UnityEngine;

namespace SLZ.MLAgents
{
	public class RaceTaskContestant : Contestant
	{
		public delegate void LapCompletedDelegate(RaceTaskContestant contestant, int currentLap);

		public new delegate void CheckpointCompletedDelegate(RaceTaskContestant contestant, int cp_ind, float currentCpTime);

		public new delegate void WrongCheckpointDelegate();

		[HideInInspector]
		private BaseVehicle_SlicedTrainer trainingAgent;

		[Tooltip("Where amongst other contestants does this one place during/at the end of a race")]
		public int standing;

		[Tooltip("The list of split times that this agent has for each of the checkpoints on a task race class")]
		public float[] split_times;

		[Tooltip("Number of laps completed by this contestant on a track")]
		public int currentLap;

		[Tooltip("The race task that this contestant belongs to")]
		public TrackRaceTaskClass raceTask;

		[Tooltip("Whether to set the reward to -1 for an agent when it fails the task and is respawned")]
		public bool penalizeOnReset;

		public LapCompletedDelegate lapCompletedDelegate;

		public new CheckpointCompletedDelegate checkpointCompletedDelegate;

		public new WrongCheckpointDelegate wrongCheckpointDelegate;

		public ConfigurableJoint lockJoint;

		private void Awake()
		{
		}

		public override void SoftReset()
		{
		}

		protected override void TimeoutTicker()
		{
		}

		private void FixedUpdate()
		{
		}

		public void LapCompleted()
		{
		}

		public void RaceCompleted()
		{
		}

		private void WrongCheckpoint()
		{
		}

		public void HandleCheckpoint(RaceObjective temp_cp)
		{
		}
	}
}
