using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TrackFollowTaskClass : TaskClass
	{
		[CompilerGenerated]
		private sealed class _003CCheckVP_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TrackFollowTaskClass _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCheckVP_003Ed__17(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public FollowObjective followObjective;

		private GameObject objectiveObj;

		public GameObject objectivePrefab;

		public float[] currentParams;

		public InfiniteTrackClass infTrack;

		private VehicleSceneContextManager context;

		private float spawnDistance;

		private float maxSpeed;

		public float spawnBuffer;

		[Header("Timer Section")]
		[Tooltip("Master clock for how long this track task objective has been active")]
		public float currentTrackTime;

		[Tooltip("The max amount of time this task can be active for before resetting")]
		public float maxTrackTime;

		[Tooltip("To use the master timer or not")]
		public bool useTrackTimer;

		private bool firstTime;

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

		[IteratorStateMachine(typeof(_003CCheckVP_003Ed__17))]
		private IEnumerator CheckVP()
		{
			return null;
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

		private void HandleTaskCompleted(bool successful)
		{
		}

		private void UpdateContestantSpeeds(float desiredSpeed)
		{
		}

		private void UpdateContestantGoalRadius(float goalRadius)
		{
		}

		private void UpdateContestantProxRadius(float proxRadius)
		{
		}

		private void HandleTrackTimer()
		{
		}

		private void InitObjective()
		{
		}

		protected override void PlaceObjective()
		{
		}

		public override Vector3 GetLineUpPosition(int i, float start_distance, float spacing, float offset_spacing, GameObject temp_contestant, TrackClass trackClass, float additionalY = 0f)
		{
			return default(Vector3);
		}

		protected override void PlaceAndRegisterContestants()
		{
		}
	}
}
