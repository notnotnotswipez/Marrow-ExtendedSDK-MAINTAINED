using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class RayInferenceSensor : BaseInferenceSensor
	{
		[CompilerGenerated]
		private sealed class _003CSlicedSensorsUpdate_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RayInferenceSensor _003C_003E4__this;

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
			public _003CSlicedSensorsUpdate_003Ed__20(int _003C_003E1__state)
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

		[Tooltip("Reference to the ML-Agents Ray Sensor Component")]
		public RayPerceptionSensorComponent3D raySensor;

		private int obs_counter;

		[Tooltip("To encode observations class as a single integer (more obs) or a float value (one ob)")]
		public bool useOneHot;

		[Tooltip("Print how many observations total are counted for rays")]
		public bool debugRayCount;

		[Tooltip("Spread the collection of ray data over multiple fixed updates")]
		public bool useSlices;

		[Tooltip("Total number of fixed update calls to use for ray collection")]
		public int nbSlices;

		[Tooltip("The final fraction of slices to use for collection")]
		public float delayFraction;

		private int delayCounter;

		[Tooltip("Total number of rays to fire per fixed update")]
		public int raysPerSlice;

		private int sliceInd;

		private BarracudaModelManagerMono bmm;

		public bool isActive;

		private int outputCounter;

		private RayPerceptionOutput eyes_output;

		private int nbRays;

		private int hot_index;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public override void Get()
		{
		}

		private void RaySensorsUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CSlicedSensorsUpdate_003Ed__20))]
		public IEnumerator SlicedSensorsUpdate()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
