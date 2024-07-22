using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Cart : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMoveTargetTransform_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cart _003C_003E4__this;

			public float direction;

			private WaitForFixedUpdate _003CfixedUpdate_003E5__2;

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
			public _003CCoMoveTargetTransform_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CCoLaunchDelayed_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cart _003C_003E4__this;

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
			public _003CCoLaunchDelayed_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CCoLaunch_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cart _003C_003E4__this;

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
			public _003CCoLaunch_003Ed__37(int _003C_003E1__state)
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

		[Header("Options")]
		public float maxSpeed;

		public float acceleration;

		public float launchReturnSeconds;

		public AudioClip launchClip;

		public AudioClip startClip;

		public AudioClip stopClip;

		[Tooltip("this determines what happens when reEnabled after it was disabled during it's motion.  isLauncher, tells it to GoBackward, Not isLauncher tells it to continue in the direction it was going.")]
		public bool isLauncher;

		public float launchDelay;

		public Renderer[] renderers;

		public int materialIndex;

		public Material offMat;

		public Material onMat;

		[Tooltip("end transform must be sibling of cart for setup to work correctly.")]
		[Header("References")]
		public Transform endTransform;

		[Header("After moving end transform, click Setup in the context menu")]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		public Rigidbody kinematicRB;

		private Coroutine _moveCoroutine;

		[ReadOnly(false)]
		[SerializeField]
		private float _lastDirection;

		[ReadOnly(false)]
		[SerializeField]
		private float _distance;

		[ReadOnly(false)]
		[SerializeField]
		private float _halfDistance;

		[SerializeField]
		[ReadOnly(false)]
		private float _linearTargetPosition;

		[ReadOnly(false)]
		[SerializeField]
		private SoftJointLimit limit;

		private float _velocity;

		public UnityEvent StopAction;

		private bool _isLaunchCancelable;

		public void Reset()
		{
		}

		[ContextMenu("Setup")]
		private void Setup()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveTargetTransform_003Ed__28))]
		public IEnumerator CoMoveTargetTransform(float direction)
		{
			return null;
		}

		public void Drop()
		{
		}

		public void GoForward()
		{
		}

		public void GoBackward()
		{
		}

		public void Go()
		{
		}

		public void DelayedLaunch()
		{
		}

		public void CancelLaunch()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunchDelayed_003Ed__35))]
		public IEnumerator CoLaunchDelayed()
		{
			return null;
		}

		[ContextMenu("Launch")]
		public void Launch()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunch_003Ed__37))]
		public IEnumerator CoLaunch()
		{
			return null;
		}

		private bool AlreadyAtTarget(float direction)
		{
			return false;
		}
	}
}
