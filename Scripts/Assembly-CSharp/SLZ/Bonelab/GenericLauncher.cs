using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class GenericLauncher : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMeasureError_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeToTarg;

			public GenericLauncher _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

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
			public _003CCoMeasureError_003Ed__28(int _003C_003E1__state)
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

		public Rigidbody[] allRBs;

		public Transform target;

		public float height;

		public Vector3 totalRevs;

		public bool DrawDebugPath;

		public bool DrawDebugMesh;

		public bool applyCorrectiveThrust;

		[SerializeField]
		private GameObject simLaunchObj;

		[SerializeField]
		private int splineResolution;

		public Vector3[] positions;

		public Vector3[] directions;

		public float gizmosSize;

		[SerializeField]
		private GameObject targetSphere;

		[SerializeField]
		private float error;

		[SerializeField]
		private float thrustThreshold;

		[SerializeField]
		private float failThreshold;

		private float xError;

		private float yError;

		private float zError;

		private Vector3[] initPos;

		private Quaternion[] initRot;

		[Header("TestDummy")]
		public GameObject testGO;

		public Mesh previewMesh;

		public Seat seat;

		public void SetInitVals()
		{
		}

		public void ResetToInitVals()
		{
		}

		public void SetupAndLaunchAll(GameObject parentGO, Vector3 targPos, float h)
		{
		}

		[ContextMenu("TestAllSetup")]
		public void TestAll()
		{
		}

		[ContextMenu("LaunchAll")]
		public void LaunchAll()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMeasureError_003Ed__28))]
		private IEnumerator CoMeasureError(float timeToTarg)
		{
			return null;
		}

		private void ApplyCorrectiveThrust()
		{
		}

		[ContextMenu("RandThrust")]
		public void TestRandomFailThrust()
		{
		}

		public TrajectoryData CalcInitialVelocity()
		{
			return null;
		}

		public Vector3 CalculateLaunchTorque(float timeToTarget, Vector3 totalRevs)
		{
			return default(Vector3);
		}

		private void DrawPath()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public TrajectoryData CalcInitialVelocityDebug(Transform targ, GameObject launchObj, float h)
		{
			return null;
		}

		public void GetAllRBs(GameObject go)
		{
		}

		public void OnPlayerEnter()
		{
		}
	}
}
