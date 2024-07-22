using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class JimmyDoorController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoorSequence_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JimmyDoorController _003C_003E4__this;

			private Vector3 _003CstartPos_003E5__2;

			private Vector3 _003CendPos_003E5__3;

			private float _003CyoinkTime_003E5__4;

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
			public _003CDoorSequence_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CDoorSequenceByPass_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JimmyDoorController _003C_003E4__this;

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
			public _003CDoorSequenceByPass_003Ed__43(int _003C_003E1__state)
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

		public Seat seat;

		public Rigidbody rb;

		public Transform leashPoint;

		public GauntletElevator elevator;

		public GameControl_BigAnomalyA gameControl;

		public float seatingLength;

		public float yoinkLength;

		public AnimationCurve lerpDistanceCurve;

		public AnimationCurve lerpHeightCurve;

		public GameObject targetRot;

		public ParticleSystem windBlast;

		public AudioClip[] doorSFX;

		public AudioClip portalSFX;

		private AudioPlayer ap1;

		private AudioPlayer ap2;

		public UnityEvent YoinkEvent;

		public UnityEvent LeashEvent;

		private RigManager rM;

		private IEnumerator sequence;

		private int moduleIndex;

		private Renderer fxRenderer;

		private float sequenceStartTime;

		private LevelCrate level;

		private float animTime;

		private int triggerLayer;

		private bool unseat;

		private bool isSeated;

		private bool portalSound;

		private bool isInTrigger;

		private bool isYoinkReady;

		private bool canLeashPlayer;

		private Vector3 debugGizmo1;

		private Vector3 debugGizmo2;

		private Vector3 debugGizmo3;

		private Vector3 debugGizmo4;

		private Vector3 debugGizmo5;

		private Vector3 debugGizmo6;

		private void Start()
		{
		}

		public void TRIGGERENTER()
		{
		}

		public void TRIGGEREXIT()
		{
		}

		public void STARTYOINK()
		{
		}

		[IteratorStateMachine(typeof(_003CDoorSequence_003Ed__41))]
		private IEnumerator DoorSequence()
		{
			return null;
		}

		public void LeashPlayer()
		{
		}

		[IteratorStateMachine(typeof(_003CDoorSequenceByPass_003Ed__43))]
		private IEnumerator DoorSequenceByPass()
		{
			return null;
		}

		public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
		{
			return default(Vector3);
		}
	}
}
