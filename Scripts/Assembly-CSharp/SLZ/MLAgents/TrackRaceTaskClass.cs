using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TrackRaceTaskClass : TaskClass
	{
		[CompilerGenerated]
		private sealed class _003CCheckVP_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TrackRaceTaskClass _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckVP_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[Tooltip("The context of the current task")]
		[Header("Objective Section")]
		private VehicleSceneContextManager context;

		[Tooltip("Objective not currently being used in race since the checkpoints are spawned by the track generator")]
		private GameObject objectiveObj;

		[Tooltip("Objective not currently being used in race since the checkpoints are spawned by the track generator")]
		public GameObject objectivePrefab;

		[Header("Timer Section")]
		[Tooltip("Master clock for how long this track task objective has been active")]
		public float currentTrackTime;

		[Tooltip("The max amount of time this task can be active for before resetting")]
		public float maxTrackTime;

		[Tooltip("To use the master timer or not")]
		public bool useTrackTimer;

		[Header("Race Specific Section")]
		[Tooltip("The actual race track that is generated")]
		public InfiniteTrackClass infTrack;

		[Tooltip("Best times for each checkpoint")]
		public float[] checkpointTimes;

		[Tooltip("To use both a reward for completing a lap and finishing a race (max laps)")]
		public bool useLapRewards;

		[Tooltip("The reward for completing a single lap")]
		public float singleLapReward;

		[Tooltip("The reward for completing maxLaps number of laps")]
		public float raceCompleteReward;

		[Tooltip("Total laps before race is complete and track is reset")]
		public int maxLaps;

		[Tooltip("The farthest checkpoint indicie thats been passed through")]
		public int currentMaxCp;

		[Tooltip("The farthest contestant on the track")]
		public RaceTaskContestant leader;

		private bool firstTime;

		private RaceUtils raceUtils;

		public event Action RaceComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action RaceResetComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void FixedUpdate()
		{
		}

		public override void GenerateTask()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckVP_003Ed__26))]
		private IEnumerator CheckVP()
		{
			return null;
		}

		private void LinkCheckpoints()
		{
		}

		private void PopulateTask()
		{
		}

		protected override void ClearContestants()
		{
		}

		private void ClearTask()
		{
		}

		private void ClearObjective()
		{
		}

		[ContextMenu("ResetTask")]
		public override void ResetTask()
		{
		}

		private void CheckPointCompleted(RaceTaskContestant contestant, int cp_ind, float currentCpTime)
		{
		}

		private void HandleTaskCompleted(bool successful)
		{
		}

		private void UpdateContestantSpeeds(float desiredSpeed)
		{
		}

		private void HandleTrackTimer()
		{
		}

		protected void ContestantRegistration(RaceTaskContestant temp_contestant, int c)
		{
		}

		protected override void PlaceAndRegisterContestants()
		{
		}

		private void ContestantLapCompleted(Contestant contestant, int lap_number)
		{
		}

		private void SetSizeRanges()
		{
		}

		public new void AddStats()
		{
		}

		public float SplitTime(int checkpointCounter, float cp_time)
		{
			return 0f;
		}
	}
}
