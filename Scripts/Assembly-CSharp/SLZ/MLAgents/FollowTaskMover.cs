using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class FollowTaskMover : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveTaskOnPath_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FollowTaskMover _003C_003E4__this;

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
			public _003CMoveTaskOnPath_003Ed__34(int _003C_003E1__state)
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

		public TrackGenerator trackGen;

		public FollowObjective followObjective;

		public float desiredSpeed;

		public float minTaskSpeed;

		public float maxTaskSpeed;

		private float stepDistance;

		private float stepPercent;

		public float delayedStart;

		private float start_timer;

		public float percent;

		private float total_track_length;

		public bool needsCountdown;

		public bool rndmStartDistance;

		public bool rndmInnerSpeed;

		public bool rndmSideMovement;

		public float speedUpdateProb;

		public float speedUpdateMod;

		public float sideUpdateProb;

		public float sideUpdateMod;

		public float difficulty;

		private float next_distance;

		private float next_width;

		private float current_width;

		private float next_speed;

		private Vector3 tempEuler;

		private Vector3 next_position;

		private Quaternion next_rotation;

		private Vector3 next_rot;

		private Vector3 lastPos;

		[HideInInspector]
		public EnvironmentParameters envParams;

		private void SetEnvParams()
		{
		}

		private void Awake()
		{
		}

		private void SideMovement()
		{
		}

		private void SpeedModulation()
		{
		}

		[IteratorStateMachine(typeof(_003CMoveTaskOnPath_003Ed__34))]
		public IEnumerator MoveTaskOnPath()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
