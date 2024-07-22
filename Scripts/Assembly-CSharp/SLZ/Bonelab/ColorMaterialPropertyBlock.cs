using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ColorMaterialPropertyBlock : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLerpColorCo_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float LerpTime;

			public ColorMaterialPropertyBlock _003C_003E4__this;

			public Color Base;

			public Color Target;

			private float _003Ctime_003E5__2;

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
			public _003CLerpColorCo_003Ed__15(int _003C_003E1__state)
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
		private Renderer[] Renderers;

		[SerializeField]
		private string[] PropertyNames;

		[SerializeField]
		private bool ColorOnAwake;

		[SerializeField]
		[ColorUsage(true, true)]
		private Color DefaultColor;

		private int[] propIDs;

		private MaterialPropertyBlock propertyBlock;

		private void Awake()
		{
		}

		public void SetAllColors(Color color)
		{
		}

		public void SetDefaultColors()
		{
		}

		public void SetColorsToBlack()
		{
		}

		public void LerpClearToWhite(float Time)
		{
		}

		public void LerpWhiteToClear(float Time)
		{
		}

		public void LerpColor(Color Target)
		{
		}

		public void LerpColor(Color Target, float Time)
		{
		}

		public void LerpColor(Color Base, Color Target, float Time)
		{
		}

		[IteratorStateMachine(typeof(_003CLerpColorCo_003Ed__15))]
		private IEnumerator LerpColorCo(Color Base, Color Target, float LerpTime)
		{
			return null;
		}
	}
}
