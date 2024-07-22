using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PageElementView : MonoBehaviour, IPopUpElementable
	{
		[CompilerGenerated]
		private sealed class _003CBlip_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PageElementView _003C_003E4__this;

			public float time;

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
			public _003CBlip_003Ed__17(int _003C_003E1__state)
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
		[ColorUsage(true, true)]
		public Color highlightColor1;

		[ColorUsage(true, true)]
		public Color highlightColor2;

		[ColorUsage(true, true)]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		public AnimationCurve blipCurve;

		private float blipTime;

		private float blipProgress;

		private Vector3 cashedScale;

		[Header("References")]
		public HighlightUI[] elements;

		private bool m_IsShown;

		[HideInInspector]
		public bool isShown => false;

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void Show(float duration)
		{
		}

		public void Hide()
		{
		}

		public void Hide(float duration)
		{
		}

		[IteratorStateMachine(typeof(_003CBlip_003Ed__17))]
		public IEnumerator Blip(float time)
		{
			return null;
		}

		public void SetTransform(Vector3 position, Quaternion rotation)
		{
		}
	}
}
