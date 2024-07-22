using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BowlingResetMechanism : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CScoreAndResetCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BowlingResetMechanism _003C_003E4__this;

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
			public _003CScoreAndResetCoroutine_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CPinResetCycle_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BowlingResetMechanism _003C_003E4__this;

			private ConfigurableJoint[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CPinResetCycle_003Ed__35(int _003C_003E1__state)
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

		public GameObject[] pins;

		private ConfigurableJoint[] joints;

		private ConfigurableJoint[] closeJoints;

		public Vector3 jointDriveSettings;

		public float cycleTime;

		public float maxResetTime;

		public float scoreTimmer;

		public float posEpsilon;

		public float rotEpsilon;

		private IEnumerator pinCycle;

		private JointDrive minDrive;

		private JointDrive maxDrive;

		public Collider[] pinColliders;

		public PhysicMaterial normalFriction;

		public PhysicMaterial noFriction;

		public AudioClip pullSFX;

		public AudioClip dropSFX;

		private ManagedAudioPlayer _mapPins;

		public SpawnableCrateReference[] whiteListCrates;

		private Dictionary<Barcode, int> whiteListObjects;

		private Dictionary<int, Poolee> objectsInTrigger;

		private List<Poolee> objectsToSweep;

		private Vector3[] pinOriginalPos;

		private bool isScoring;

		private bool isPlayerInTrigger;

		private bool isBallInTrigger;

		public void Start()
		{
		}

		public void PINAWOKEN()
		{
		}

		[IteratorStateMachine(typeof(_003CScoreAndResetCoroutine_003Ed__28))]
		private IEnumerator ScoreAndResetCoroutine()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private int CheckScore()
		{
			return 0;
		}

		private bool PinDownCheck(GameObject pin)
		{
			return false;
		}

		private void CheckPinReset()
		{
		}

		public void RESETPINS()
		{
		}

		[IteratorStateMachine(typeof(_003CPinResetCycle_003Ed__35))]
		private IEnumerator PinResetCycle()
		{
			return null;
		}
	}
}
