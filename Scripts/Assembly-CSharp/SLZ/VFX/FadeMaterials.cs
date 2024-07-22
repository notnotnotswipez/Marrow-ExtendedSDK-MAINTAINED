using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.VFX
{
	public class FadeMaterials : MonoBehaviour
	{
		private enum Fade
		{
			In = 0,
			Out = 1
		}

		[CompilerGenerated]
		private sealed class _003CFader_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FadeMaterials _003C_003E4__this;

			public Fade fadeType;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private float _003CTimer_003E5__4;

			private float _003Cstep_003E5__5;

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
			public _003CFader_003Ed__8(int _003C_003E1__state)
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
		[Range(0f, 5f)]
		private float TimeToFullyFade;

		[SerializeField]
		private string TargetVariable;

		public Renderer[] MaterialsToFade;

		private float currentAlpha;

		private void Start()
		{
		}

		public void FadeIn()
		{
		}

		public void FadeOut()
		{
		}

		[IteratorStateMachine(typeof(_003CFader_003Ed__8))]
		private IEnumerator Fader(Fade fadeType)
		{
			return null;
		}
	}
}
