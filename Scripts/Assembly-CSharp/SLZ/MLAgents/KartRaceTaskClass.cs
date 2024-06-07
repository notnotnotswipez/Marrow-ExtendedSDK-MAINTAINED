using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class KartRaceTaskClass : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAcademyShutdownDelay_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KartRaceTaskClass _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CAcademyShutdownDelay_003Ed__38(int _003C_003E1__state)
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

		private ContestantPrefabSpawner contestantSpawner;

		private RaceCountdownDisplay countdownDisplay;

		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable playerKart;

		[SerializeField]
		[Tooltip("Spawnable")]
		private Spawnable aiKart;

		public string vehicleComponentName;

		public GameObject[] spawnLocations;

		public GameObject[] checkpointArray;

		public RaceTaskContestant[] contestants;

		public int nb_contestants;

		public Contestant[] finalPlacements;

		public int nb_completed;

		public GameObject countdownButton;

		[Header("Inference Section")]
		public BarracudaModelManagerMono bmm;

		public ModelManagerConfig bmmConfig;

		public int nbNetworkSlices;

		public int actionMaskSize;

		public int trainedDelay;

		public int displayedContestants;

		[Tooltip("Best times for each checkpoint")]
		[Header("Race Specific Section")]
		public float[] checkpointTimes;

		[Tooltip("The farthest contestant on the track")]
		public RaceTaskContestant leader;

		public float defaultSeatedMass;

		private bool firstTime;

		private RaceUtils raceUtils;

		private int firstRaysPerSlice;

		private int firstNbSlices;

		private int shutdownCount;

		public event Action RaceStart
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

		public event Action IncrementContestants
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

		public event Action DecrementContestants
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

		private void ShutdownAcademy()
		{
		}

		protected void Awake()
		{
		}

		private void BMMSetup()
		{
		}

		[IteratorStateMachine(typeof(_003CAcademyShutdownDelay_003Ed__38))]
		public IEnumerator AcademyShutdownDelay()
		{
			return null;
		}

		protected void Start()
		{
		}

		public void ConnectAgentToBmm(GameObject agent, int agentId)
		{
		}

		private void StartBMM()
		{
		}

		public void MoveContestant(RaceTaskContestant contestant, GameObject contestantGo, GameObject spawn)
		{
		}

		[ContextMenu("More Contestants")]
		public void MoreContestants()
		{
		}

		[ContextMenu("Less Contestants")]
		public void LessContestants()
		{
		}

		[ContextMenu("Reset Contestants")]
		public void ResetContestants()
		{
		}

		private void SpawnAllContestants()
		{
		}

		private void FixedUpdate()
		{
		}

		public void SpawnContestant(Spawnable spawnable, int ind)
		{
		}

		private void SetLockJoint(ConfigurableJoint lockJoint)
		{
		}

		private void UnsetLockJoint(ConfigurableJoint lockJoint)
		{
		}

		public void UnfreezeContestants()
		{
		}

		[ContextMenu("Assign Checkpoints")]
		private void AssignCheckpoints()
		{
		}

		private void LinkCheckpoints()
		{
		}

		protected virtual void PlaceAndRegisterContestants()
		{
		}

		private void PopulateTask()
		{
		}

		private void UpdateContestantSpeeds(float desiredSpeed)
		{
		}

		public float SplitTime(int checkpointCounter, float cp_time)
		{
			return 0f;
		}

		[ContextMenu("Increase Slices")]
		public void IncreaseSlices()
		{
		}

		[ContextMenu("Decrease Slices")]
		public void DecreaseSlices()
		{
		}

		[ContextMenu("Increase Sim Steps")]
		public void IncreaseSimSteps()
		{
		}

		[ContextMenu("Decrease Sim Steps")]
		public void DecreaseSimSteps()
		{
		}

		[ContextMenu("Increase Rays Per Slice")]
		public void IncreaseRaysPerSlice()
		{
		}

		[ContextMenu("Decrease Rays Per Slice")]
		public void DecreaseRaysPerSlice()
		{
		}
	}
}
