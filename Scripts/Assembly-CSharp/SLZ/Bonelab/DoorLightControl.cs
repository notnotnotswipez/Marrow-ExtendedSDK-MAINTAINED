using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DoorLightControl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlickerLight_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DoorLightControl _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003CFlickerLight_003Ed__12(int _003C_003E1__state)
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

		public Renderer mat_Render;

		[ColorUsage(true, true)]
		public Color hdr_OnColor;

		[ColorUsage(true, true)]
		public Color hdr_BlinkColor;

		[ColorUsage(true, true)]
		public Color hdr_OffColor;

		public bool LightOn;

		public bool Flicker;

		private MaterialPropertyBlock propertyBlock;

		private int _colorHash;

		private void Awake()
		{
		}

		private void InitializePropertyBlock()
		{
		}

		private void Start()
		{
		}

		public void BeginFlicker()
		{
		}

		[IteratorStateMachine(typeof(_003CFlickerLight_003Ed__12))]
		private IEnumerator FlickerLight()
		{
			return null;
		}

		public void SetEmissive(bool On)
		{
		}
	}
}
