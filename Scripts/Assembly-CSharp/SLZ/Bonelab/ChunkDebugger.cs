using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.SceneStreaming;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChunkDebugger : MonoBehaviour
	{
		private class Box
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 extends;
		}

		private class TriggerBox : Box
		{
			public ChunkTrigger chunkTrigger;
		}

		private class TrackerBox : Box
		{
			public ChunkTracker chunkTracker;

			public Collider collider;
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CStart_003Ed__9(int _003C_003E1__state)
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

		public Grip triggerGrip;

		private List<TriggerBox> _triggerBox;

		private List<TrackerBox> _trackerBox;

		private Vector3 _boundsCenter;

		private float _scale;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnTrackerAdd(ChunkTracker tracker)
		{
		}

		private void OnTrackerRemove(ChunkTracker tracker)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
