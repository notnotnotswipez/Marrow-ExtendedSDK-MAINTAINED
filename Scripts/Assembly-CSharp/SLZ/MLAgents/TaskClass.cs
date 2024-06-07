using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.MLAgents
{
	public class TaskClass : MonoBehaviour
	{
		[Tooltip("Name of component on vehicle that is checked on passthrough of checkpoint")]
		public string vehicleComponentCpName;

		[HideInInspector]
		public float half_radius;

		[HideInInspector]
		public float x_z_max;

		[HideInInspector]
		public float x_z_min;

		[HideInInspector]
		public float y_max;

		[HideInInspector]
		public float y_min;

		[Header("Contestants Section")]
		public int nb_contestants;

		public GameObject contestantPrefab;

		public Contestant[] contestants;

		public List<Contestant> inactiveContestants;

		public Contestant[] finalPlacements;

		public int nb_completed;

		[Tooltip("Number of rows to spawn contestants in")]
		public int requested_rows;

		[Tooltip("Spacing between contestants in starting lineup")]
		public float contestantSpacing;

		[Header("Task Components/Prefabs")]
		public GameObject obstaclePrefab;

		public List<GameObject> obsList;

		public float obs_size;

		public float nb_obstacle_zones;

		public float obstacles_per_zone;

		public GameObject[] jumpArray;

		public GameObject jump;

		public float nb_jumps;

		public GameObject wallPrefab;

		public List<GameObject> wallsList;

		[Header("Countdown Section")]
		private bool startCountdown;

		[Tooltip("Current countdown time")]
		public float countdown;

		[Tooltip("total countdown time")]
		public float countdown_sec;

		[Header("Global Training Statistics")]
		public bool inferenceSwitch;

		public bool use_cur;

		public StatsRecorder statsRecorder;

		public EnvironmentParameters envParams;

		public float timeCollidedOther;

		public float timeCollidedCar;

		public float timeCollidedWall;

		public float timeCollidedTotal;

		public float totalCollisions;

		public float totalFalls;

		public float totalWrongCps;

		public float totalCorrectCps;

		public float nbCompletedLaps;

		public float totalCarCollisions;

		public float totalWallCollisions;

		public float totalOtherCollisions;

		public int nb_fails;

		public NavMeshSurface surface;

		[Header("Inference Section")]
		public BarracudaModelManagerMono bmm;

		public ModelManagerConfig bmmConfig;

		public bool ignoreAgents;

		public int ignoreAgentLayer;

		public event Action TaskComplete
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

		public event Action TaskResetComplete
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

		public void ConnectAgentToBmm(GameObject agent, int agentId)
		{
		}

		public virtual Vector3 GetLineUpPosition(int i, float start_distance, float spacing, float offset_spacing, GameObject temp_contestant, TrackClass trackClass, float additionalY = 0f)
		{
			return default(Vector3);
		}

		public virtual Vector3 GetLineUpPosition(int i, Vector3 start_pos, float spacing, float offset_spacing, GameObject temp_contestant, TrackClass trackClass, float additionalY = 0f)
		{
			return default(Vector3);
		}

		private void SetSizeRanges()
		{
		}

		protected virtual void Awake()
		{
		}

		private void InitTask()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void ContestantRegistration(Contestant temp_contestant, int c)
		{
		}

		protected virtual void ResetInactiveContestants()
		{
		}

		protected virtual void ClearContestants()
		{
		}

		protected virtual void PlaceObjective()
		{
		}

		public void RescaleObstacle(ref GameObject obsObj)
		{
		}

		protected virtual void ClearObstacles()
		{
		}

		protected virtual void PlaceObstacles()
		{
		}

		protected virtual void PlaceWalls()
		{
		}

		protected virtual void PlaceAndRegisterContestants()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public virtual void ResetTask()
		{
		}

		public virtual void GenerateTask()
		{
		}

		public void AddStats()
		{
		}
	}
}
