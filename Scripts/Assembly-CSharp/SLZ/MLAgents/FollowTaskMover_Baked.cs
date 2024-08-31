using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class FollowTaskMover_Baked : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveCarOnPath_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FollowTaskMover_Baked _003C_003E4__this;

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
			public _003CMoveCarOnPath_003Ed__25(int _003C_003E1__state)
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

		public float desiredSpeed;

		public float minSpeed;

		public float maxSpeed;

		private float stepDistance;

		private float stepPercent;

		public float delayedStart;

		public bool rndmStartDistance;

		private float start_timer;

		public float percent;

		private float total_track_length;

		private bool needsCountdown;

		public float sideUpdateProb;

		public float sideUpdateMod;

		public float difficulty;

		private float next_distance;

		private float next_width;

		private Vector3 next_position;

		private Vector3 next_rot;

		private Vector3 lastPos;

		public bool reverseSwitch;

		public float roadWidth;

		private int currentInd;

		private int WrapAroundInd(int ind, int len)
		{
			return 0;
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CMoveCarOnPath_003Ed__25))]
		public IEnumerator MoveCarOnPath()
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
