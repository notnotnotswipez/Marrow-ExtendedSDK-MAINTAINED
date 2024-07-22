using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BallThrustPointManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitFrame_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BallThrustPointManager _003C_003E4__this;

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
			public _003CWaitFrame_003Ed__39(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CNoiseRoutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BallThrustPointManager _003C_003E4__this;

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
			public _003CNoiseRoutine_003Ed__43(int _003C_003E1__state)
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

		public Rigidbody parentRb;

		public Thruster x;

		public Thruster negx;

		public Thruster y;

		public Thruster negy;

		public Thruster z;

		public Thruster negz;

		public string gameObjectName;

		public CounterTorque gyro;

		public Thruster[] thrusters;

		public CounterTorque[] gyros;

		public bool goToDest;

		public GameObject destination;

		public bool useMinHeight;

		private Vector3 destinationError;

		private float dest_dist;

		private float dest_dist_2d;

		private float cached_dest_dist;

		private int layer_mask;

		public bool useStationaryNoise;

		public float lerpStrength;

		public float noiseRadius;

		public float noiseDestThreshold;

		private bool noiseRunning;

		private Vector3 noiseVector;

		private Vector3 cachedDestination;

		private Vector3 noisePosition;

		private Coroutine noiseRoutine;

		public bool activated;

		public bool speedGovern;

		public float maxVelMag;

		public float governMod;

		private Vector3 maxVel;

		private Vector3 velError;

		public float destThresh;

		[ContextMenu("Deactivate Thrusters")]
		public void DeactivateThrusters()
		{
		}

		[ContextMenu("Activate Thrusters")]
		public void ActivateThrusters()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__39))]
		private IEnumerator WaitFrame()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		[ContextMenu("Start Noise")]
		public void StartNoise()
		{
		}

		[ContextMenu("Stop Noise")]
		public void StopNoise()
		{
		}

		[IteratorStateMachine(typeof(_003CNoiseRoutine_003Ed__43))]
		private IEnumerator NoiseRoutine()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
