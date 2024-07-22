using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.Obsolete;
using SLZ.Marrow;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class TutorialElevator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDoorRoutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

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
			public _003CCoDoorRoutine_003Ed__46(int _003C_003E1__state)
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
		private sealed class _003CCoInitialBreakRoutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CCoInitialBreakRoutine_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CCoSwing_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

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
			public _003CCoSwing_003Ed__52(int _003C_003E1__state)
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
		private sealed class _003CCoFallRoutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CCoFallRoutine_003Ed__56(int _003C_003E1__state)
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
		private sealed class _003CCoFallingZeroG_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

			private Vector3 _003CcurrGrav_003E5__2;

			private Vector3 _003ClowGrav_003E5__3;

			private float _003CstartTime_003E5__4;

			private float _003CendTime_003E5__5;

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
			public _003CCoFallingZeroG_003Ed__57(int _003C_003E1__state)
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
		private sealed class _003CCoComplete_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialElevator _003C_003E4__this;

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
			public _003CCoComplete_003Ed__59(int _003C_003E1__state)
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
		private PlayableDirector director;

		[SerializeField]
		private float stage1Speed;

		[SerializeField]
		private float fallSpeed;

		private Vector3 gravityGoal;

		private Vector3 spikeGravGoal;

		public AnimationCurve xCurve;

		public AnimationCurve yCurve;

		public AnimationCurve zCurve;

		private float perc;

		private float xPos;

		private float yPos;

		private float zPos;

		private Coroutine vatorRoutine;

		private Coroutine moveUpRoutine;

		[SerializeField]
		[Header("Audio")]
		private AudioClip abortDoorClip;

		[SerializeField]
		private AudioClip doorCloseClip;

		public SpawnableCrateReference sparksCrate;

		[Header("Doors")]
		[SerializeField]
		public bool isClosing;

		[SerializeField]
		private float doorWaitDuration;

		[SerializeField]
		private Powerable_Joint[] powerableJoints;

		[SerializeField]
		private Rigidbody[] doorBodies;

		[SerializeField]
		private GameObject[] outerDoorObjs;

		[SerializeField]
		private Collider doorTrigCol;

		[SerializeField]
		private GameObject[] vatorColliders;

		public Coroutine doorRoutine;

		[SerializeField]
		private GameObject shaftColliderObj;

		public GameObject doorSeel;

		[Header("Shafts")]
		public TutorialShaft[] tutShafts;

		[SerializeField]
		private GameObject ogShaftObj;

		[SerializeField]
		private GameObject otherShaftObj;

		[SerializeField]
		private ConfigurableJoint vatorJoint;

		private Vector3 startGrav;

		private Player_Health pHealth;

		[SerializeField]
		private ElevatorDoorTrigger doorTrig;

		[SerializeField]
		private Rigidbody elevatorBody;

		[SerializeField]
		private ParticleSystem rightSparkler;

		[SerializeField]
		private ParticleSystem leftSparkler;

		private int hubSpawnLocation;

		public SLZ.Marrow.VoidLogic.PowerSource doorPower;

		public Transform emancipatorPoint;

		public Vector3 emancipatorBounds;

		public LayerMask layerMask;

		public bool playerInElevator;

		public AudioSource[] elevatorAudioSources;

		private void Start()
		{
		}

		[ContextMenu("StartElevator")]
		public void StartElevator()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDoorRoutine_003Ed__46))]
		private IEnumerator CoDoorRoutine()
		{
			return null;
		}

		public void SealDoors()
		{
		}

		public void StartMoveUpward()
		{
		}

		public void SlowUpwardMovement()
		{
		}

		[IteratorStateMachine(typeof(_003CCoInitialBreakRoutine_003Ed__50))]
		private IEnumerator CoInitialBreakRoutine()
		{
			return null;
		}

		public void ReleaseJointRot()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSwing_003Ed__52))]
		private IEnumerator CoSwing()
		{
			return null;
		}

		public void SwingImpact()
		{
		}

		public void LimitJointRot()
		{
		}

		public void StartMoveDownward()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFallRoutine_003Ed__56))]
		private IEnumerator CoFallRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFallingZeroG_003Ed__57))]
		private IEnumerator CoFallingZeroG()
		{
			return null;
		}

		public void StartImpact()
		{
		}

		[IteratorStateMachine(typeof(_003CCoComplete_003Ed__59))]
		private IEnumerator CoComplete()
		{
			return null;
		}

		[ContextMenu("OpenDoors")]
		public void OpenDoors()
		{
		}

		[ContextMenu("CloseDoors")]
		public void CloseDoors()
		{
		}

		public void StopDoorRoutine()
		{
		}

		public void DoorEmancipator()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDestroy()
		{
		}

		public void OPENCLOSEDOOR(bool open = true)
		{
		}

		public void EnterExitElevator(bool enter)
		{
		}
	}
}
