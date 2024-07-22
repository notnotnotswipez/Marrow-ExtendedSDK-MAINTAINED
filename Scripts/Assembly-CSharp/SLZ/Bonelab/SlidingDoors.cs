using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.Obsolete;
using SLZ.Marrow.AI;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SlidingDoors : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoWaitAndToggleEvent_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SlidingDoors _003C_003E4__this;

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
			public _003CCoWaitAndToggleEvent_003Ed__30(int _003C_003E1__state)
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
		private sealed class _003CCoSlide_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SlidingDoors _003C_003E4__this;

			public Vector3 startPosLeft;

			public Vector3 endPosLeft;

			public Vector3 startPosRight;

			public Vector3 endPosRight;

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
			public _003CCoSlide_003Ed__36(int _003C_003E1__state)
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

		[SerializeField]
		private Arena_GameController arenaGameController;

		public bool isLocked;

		public bool isOpen;

		public GameObject leftDoor;

		public GameObject rightDoor;

		public AudioClip openClip;

		public AudioClip closeClip;

		public AudioClip lockedClip;

		public Coroutine slideRoutine;

		private Vector3 openLeft;

		private Vector3 openRight;

		private Vector3 closeLeft;

		private Vector3 closeRight;

		public List<AIBrain> npcBrainList;

		public float eventDelayTime;

		public UnityEvent CloseEvent;

		public UnityEvent OpenEvent;

		private Coroutine waitRoutine;

		public Powerable_Joint doorJoint;

		private void Awake()
		{
		}

		public void TogglePlayerDoorLock(bool isLocking)
		{
		}

		public void CloseAndLockPlayerDoor()
		{
		}

		public void TogglePlayerDoor(bool open)
		{
		}

		public void LockPlayerDoor()
		{
		}

		public void UnlockPlayerDoor()
		{
		}

		public void CloseDoor()
		{
		}

		[ContextMenu("FastOpen")]
		public void FastOpen()
		{
		}

		[ContextMenu("ForceOpenPlayerDoor")]
		public void ForceOpenPlayerDoor()
		{
		}

		[ContextMenu("PlayerEnter")]
		public void PlayerEnter()
		{
		}

		[ContextMenu("PlayerExit")]
		public void PlayerExit()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitAndToggleEvent_003Ed__30))]
		private IEnumerator CoWaitAndToggleEvent()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void NPCEnter(AIBrain currBrain)
		{
		}

		public void NPCExit(AIBrain currBrain)
		{
		}

		[ContextMenu("ToggleDoor")]
		public void ToggleDoor()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSlide_003Ed__36))]
		private IEnumerator CoSlide(Vector3 startPosLeft, Vector3 endPosLeft, Vector3 startPosRight, Vector3 endPosRight)
		{
			return null;
		}
	}
}
