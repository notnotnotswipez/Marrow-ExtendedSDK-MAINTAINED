using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class ThrowPrediction : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMeasureError_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeToTarg;

			public ThrowPrediction _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CCoMeasureError_003Ed__38(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public RigManager rigManager;

		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private Grip grip;

		[SerializeField]
		private Transform reboundTarget;

		[SerializeField]
		[Header("Trajectory")]
		private TrajectoryData trajData;

		[SerializeField]
		private float height;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private GameObject simObject;

		[SerializeField]
		[Header("Error")]
		private bool applyCorrectiveThrust;

		[SerializeField]
		private float thrustFactor;

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

		private Coroutine errorRoutine;

		[SerializeField]
		[Header("Prediction")]
		private float predictionTime;

		[SerializeField]
		private bool isDrawingPrediction;

		[SerializeField]
		private int splineResolution;

		[SerializeField]
		private float gizmoScale;

		[SerializeField]
		private Vector3 releaseVelocity;

		public Vector3[] positions;

		public Vector3[] predictedPositions;

		public Vector3[] predictedDirections;

		public Vector3[] oldPositions;

		public Vector3[] oldDirections;

		[SerializeField]
		private LineRenderer predictLineRend;

		[SerializeField]
		private LineRenderer idealLineRend;

		private int lerpValInt;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		private void OnDrop(Hand hand)
		{
		}

		[ContextMenu("TestDrop")]
		public void TestDrop()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMeasureError_003Ed__38))]
		private IEnumerator CoMeasureError(float timeToTarg)
		{
			return null;
		}

		private void Rebound_TeleportToPlayer()
		{
		}

		private void ApplyCorrectiveThrust()
		{
		}

		public TrajectoryData CalcInitialVelocity()
		{
			return null;
		}

		private void DrawPredictedPath()
		{
		}

		private void DrawIdealPath()
		{
		}
	}
}
