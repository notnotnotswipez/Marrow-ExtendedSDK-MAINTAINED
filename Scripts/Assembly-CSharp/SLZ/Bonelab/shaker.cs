using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Rigidbody))]
	public class shaker : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTimedShakeCo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float Shaketime;

			public float Frequency;

			public shaker _003C_003E4__this;

			public Vector3 AxisAlignedIntensity;

			public Quaternion Direction;

			private float _003Ct_003E5__2;

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
			public _003CTimedShakeCo_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CContinuousShaking_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CContinuousShaking_003Ed__9(int _003C_003E1__state)
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
		[Range(0f, 1f)]
		private float multiplier;

		[SerializeField]
		private Transform temptrans;

		[SerializeField]
		[HideInInspector]
		private Rigidbody bodyRB;

		private void Reset()
		{
		}

		public void TimedShake(float Shaketime)
		{
		}

		public void TimedShake(float Shaketime, float Frequency, Quaternion Direction)
		{
		}

		public void TimedShake(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
		{
		}

		public void ContinuousShake()
		{
		}

		[IteratorStateMachine(typeof(_003CTimedShakeCo_003Ed__8))]
		private IEnumerator TimedShakeCo(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CContinuousShaking_003Ed__9))]
		private IEnumerator ContinuousShaking()
		{
			return null;
		}
	}
}
