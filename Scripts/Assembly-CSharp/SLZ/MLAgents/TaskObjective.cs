using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TaskObjective : MonoBehaviour
	{
		public delegate void OnProxChangeDelegate(float newVal);

		public delegate void OnGoalChangeDelegate(float newVal);

		[CompilerGenerated]
		private sealed class _003CRadiusStateController_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaskObjective _003C_003E4__this;

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
			public _003CRadiusStateController_003Ed__41(int _003C_003E1__state)
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

		[Header("Radii Section")]
		[Tooltip("The collider component name that will tell task that contestant has entered")]
		public string vehicleComponentCpName;

		[Tooltip("Goal is the inner radius")]
		public float goal_radius;

		[Tooltip("Value used for nomalizing observations")]
		public float max_goal_radius;

		public float min_goal_radius;

		[Tooltip("Prox is the outer radius")]
		public float prox_radius;

		[Tooltip("Value used for nomalizing observations")]
		public float max_prox_radius;

		public float min_prox_radius;

		[Tooltip("Multiplyer on how fast the lerp between radii sizes is")]
		public float lerpRate;

		[Tooltip("Updates prox radi")]
		public bool useRadiusController;

		[Tooltip("Probability of triggering a radius update (curriculum val)")]
		public float radiusUpdateProb;

		private bool radiusUpdating;

		[Header("Task Timer Section")]
		[Tooltip("Attempt timer will terminate a session if an attemt is not made (radii not entered)")]
		public bool useTimer;

		[Tooltip("Has a contestant entered this task")]
		public bool attemptStarted;

		[Tooltip("Amount of time to allow while the task is active and attempt has started")]
		public float maxInitTime;

		[Tooltip("How much time the task has been active for (attempt started)")]
		public float currentInitTime;

		[Tooltip("Time before a task session is ended for this task")]
		public float maxAttemptTime;

		[Tooltip("Clock time of no attempt made on this task")]
		public float currentAttemptTime;

		[Tooltip("To show the radii of the task")]
		public bool debug_gizmos;

		public bool trainingMode;

		[HideInInspector]
		public EnvironmentParameters envParams;

		private bool decreasing;

		private float lerp_scale;

		private SphereCollider col;

		public float ProxRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float GoalRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event Action<bool> TaskCompleted
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

		public event OnProxChangeDelegate OnProxChange
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

		public event OnGoalChangeDelegate OnGoalChange
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

		protected virtual void OnDrawGizmos()
		{
		}

		[IteratorStateMachine(typeof(_003CRadiusStateController_003Ed__41))]
		public IEnumerator RadiusStateController()
		{
			return null;
		}

		public virtual void SetEnvParams()
		{
		}

		protected void Awake()
		{
		}

		public virtual void Init()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void InitObjective()
		{
		}

		public virtual void MoveCheckpoint()
		{
		}

		public virtual void SubmitTaskInfo()
		{
		}

		public virtual void HandleAttemptTimer()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void TaskCompleteInterface(bool val)
		{
		}

		protected virtual void SubmitTaskInfo(GameObject gameObj)
		{
		}
	}
}
