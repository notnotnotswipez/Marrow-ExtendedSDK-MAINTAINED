using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UI_Rhythm : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFLASH_DOWNBEAT_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_Rhythm _003C_003E4__this;

			private float _003CElapsedTime_003E5__2;

			private float _003CTotalTime_003E5__3;

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
			public _003CFLASH_DOWNBEAT_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CFLASH_STEP_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_Rhythm _003C_003E4__this;

			private float _003CElapsedTime_003E5__2;

			private float _003CTotalTime_003E5__3;

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
			public _003CFLASH_STEP_003Ed__17(int _003C_003E1__state)
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

		public bool runUI;

		public ClockBPM masterClock;

		public TextMeshPro txt_BPM;

		public TextMeshPro txt_timeSignature;

		public TextMeshPro txt_totSteps;

		public TextMeshPro txt_2step;

		public TextMeshPro txt_4step;

		public TextMeshPro txt_8step;

		public TextMeshPro txt_scoreMult;

		public TextMeshPro txt_transitionState;

		public SpriteRenderer img_downBeat;

		public SpriteRenderer img_step;

		public void Update()
		{
		}

		public void DISPLAY_UI()
		{
		}

		public void STEP()
		{
		}

		public void DOWNBEAT()
		{
		}

		[IteratorStateMachine(typeof(_003CFLASH_DOWNBEAT_003Ed__16))]
		private IEnumerator FLASH_DOWNBEAT()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFLASH_STEP_003Ed__17))]
		private IEnumerator FLASH_STEP()
		{
			return null;
		}
	}
}
