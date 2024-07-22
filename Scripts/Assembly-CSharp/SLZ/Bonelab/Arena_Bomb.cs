using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Arena_Bomb : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCountdown_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Arena_Bomb _003C_003E4__this;

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
			public _003CCoCountdown_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CCoExpand_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Arena_Bomb _003C_003E4__this;

			private float _003CexpandLerp_003E5__2;

			private float _003CstartTime_003E5__3;

			private float _003CendTime_003E5__4;

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
			public _003CCoExpand_003Ed__13(int _003C_003E1__state)
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

		private Coroutine countdownRoutine;

		[SerializeField]
		private float timeValue;

		[SerializeField]
		private AudioClip initClip;

		[SerializeField]
		private AudioClip explodeClip;

		[SerializeField]
		private TMP_Text timerText;

		[SerializeField]
		private UnityEvent explodeEvent;

		[SerializeField]
		private GameObject expandSphereObj;

		private Vector3 endScale;

		public void StartCountdown(float seconds = 20f)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCountdown_003Ed__9))]
		private IEnumerator CoCountdown()
		{
			return null;
		}

		private void UpdateTimeDisplay()
		{
		}

		[ContextMenu("DEFUSE")]
		public void DefuseCountdown()
		{
		}

		[ContextMenu("ExplodeBomb")]
		public void ExplodeBomb()
		{
		}

		[IteratorStateMachine(typeof(_003CCoExpand_003Ed__13))]
		private IEnumerator CoExpand()
		{
			return null;
		}
	}
}
