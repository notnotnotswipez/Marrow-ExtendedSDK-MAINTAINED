using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HighlightUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoFadeToColors_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Color c1;

			public Color c2;

			public HighlightUI _003C_003E4__this;

			public float duration;

			private float _003Ctime_003E5__2;

			private Vector3 _003CtoHSV1_003E5__3;

			private Vector3 _003CtoHSV2_003E5__4;

			private Vector3 _003CfromHSV1_003E5__5;

			private Vector3 _003CfromHSV2_003E5__6;

			private float _003CtoAlpha1_003E5__7;

			private float _003CtoAlpha2_003E5__8;

			private float _003CfromAlpha1_003E5__9;

			private float _003CfromAlpha2_003E5__10;

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
			public _003CCoFadeToColors_003Ed__14(int _003C_003E1__state)
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

		private static MaterialPropertyBlock m_PropertyBlock;

		private static int m_Color1ID;

		private static int m_Color2ID;

		private Renderer m_Renderer;

		[ColorUsage(true, true)]
		[Header("Options")]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		private Coroutine fadeToColorsCoroutine;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		public void DisableMesh()
		{
		}

		public void EnableMesh()
		{
		}

		public void SetColors(Color c1, Color c2)
		{
		}

		public void FadeToColors(Color c1, Color c2, float duration)
		{
		}

		public void FadeToColors(Color c1, Color c2)
		{
		}

		[IteratorStateMachine(typeof(_003CCoFadeToColors_003Ed__14))]
		private IEnumerator CoFadeToColors(Color c1, Color c2, float duration = 0.15f)
		{
			return null;
		}
	}
}
