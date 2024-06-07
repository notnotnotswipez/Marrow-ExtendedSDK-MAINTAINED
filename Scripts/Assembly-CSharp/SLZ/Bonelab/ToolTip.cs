using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ToolTip : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoShowPopup_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ToolTip _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CCoShowPopup_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoHidePopup_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ToolTip _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CCoHidePopup_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public float popupTime;

		public float popdownTime;

		public bool isEditorOnly;

		public int numberOfPopups;

		public AudioClip popupClip;

		public AudioClip popdownClip;

		public UnityEvent OnFocus;

		public UnityEvent OnBlur;

		protected Action OnFocusDelegate;

		protected Action OnBlurDelegate;

		private int _popupCount;

		private bool _isPopup;

		private Coroutine _popupCoroutine;

		private Coroutine _hidePopupCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnToolFocus()
		{
		}

		public void OnToolBlur()
		{
		}

		[IteratorStateMachine(typeof(_003CCoShowPopup_003Ed__17))]
		private IEnumerator CoShowPopup()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoHidePopup_003Ed__19))]
		private IEnumerator CoHidePopup()
		{
			return null;
		}
	}
}
