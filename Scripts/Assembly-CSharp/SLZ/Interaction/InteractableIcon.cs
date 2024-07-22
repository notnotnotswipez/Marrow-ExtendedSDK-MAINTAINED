using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableIcon : MonoBehaviour
	{
		private enum Flip
		{
			On = 0,
			Off = 1
		}

		[CompilerGenerated]
		private sealed class _003CCoBlendIconScaleFromTo_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float from;

			public float to;

			public InteractableIcon _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CCoBlendIconScaleFromTo_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CSwitch_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InteractableIcon _003C_003E4__this;

			public Flip flip;

			private float _003CTargetScale_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CSwitch_003Ed__26(int _003C_003E1__state)
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

		private Grip m_Grip;

		public Transform targetCenter;

		public GripIconType gripIconType;

		[HideInInspector]
		[SerializeField]
		private GameObject iconObj;

		private Renderer iconRenderer;

		[HideInInspector]
		public int hoverCount;

		[HideInInspector]
		public int farHoverCount;

		[Header("Overrides default settings")]
		[SerializeField]
		private bool LocalOverride;

		[SerializeField]
		[Tooltip("Override default icon")]
		private Texture IconTex;

		[SerializeField]
		private float IconSize;

		[SerializeField]
		private float AnimationDuration;

		private float scaledIconSize;

		private MaterialPropertyBlock Mblock;

		private int _sizeHash;

		private Coroutine iconBlendCoroutine;

		public void Awake()
		{
		}

		public void MyHandHoverBegin(Hand hand)
		{
		}

		public void MyHandHoverEnd(Hand hand)
		{
		}

		public void MyHandHoverUpdate(Hand hand)
		{
		}

		public void MyFarHandHoverBegin(Hand hand)
		{
		}

		public void MyFarHandHoverEnd(Hand hand)
		{
		}

		public void MyFarHandHoverUpdate(Hand hand)
		{
		}

		private void Reset()
		{
		}

		private void BlendIcondScaleFromTo(float targetScale)
		{
		}

		[IteratorStateMachine(typeof(_003CCoBlendIconScaleFromTo_003Ed__24))]
		private IEnumerator CoBlendIconScaleFromTo(float from, float to)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSwitch_003Ed__26))]
		private IEnumerator Switch(Flip flip)
		{
			return null;
		}

		private void AddIcon()
		{
		}

		private Mesh GetQuad()
		{
			return null;
		}

		private static Mesh BuildQuad(float width, float height)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RemoveIcon()
		{
		}
	}
}
