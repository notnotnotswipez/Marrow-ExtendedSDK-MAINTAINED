using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Input;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ControllerTutorialArt : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoBlinkHighlight_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Renderer renderer;

			public float cycles;

			public ControllerTutorialArt _003C_003E4__this;

			private MaterialPropertyBlock _003CpropertyBlock_003E5__2;

			private int _003Cdither_003E5__3;

			private float _003Cduration_003E5__4;

			private float _003Ctime_003E5__5;

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
			public _003CCoBlinkHighlight_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CFXChange_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerTutorialArt _003C_003E4__this;

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
			public _003CFXChange_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CControllerFollow_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerTutorialArt _003C_003E4__this;

			public RigManager manager;

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
			public _003CControllerFollow_003Ed__29(int _003C_003E1__state)
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

		public XRControllerType controllerType;

		public bool isRightHand;

		public Transform offset_text;

		[Header("CONTROLLER ART")]
		public GameObject controller;

		public Renderer joystick;

		public Renderer button_primary;

		public Renderer button_secondary;

		public Renderer trigger;

		public Renderer grip;

		public Renderer system;

		public Renderer outline;

		public float timeToHighlight;

		private float cur_TimeToHighlight;

		private bool _endOff;

		[ColorUsage(true, true)]
		public Color max_controller_color;

		[ColorUsage(true, true)]
		public Color min_controller_color;

		[ColorUsage(true, true)]
		private Color target_controller_color;

		[ColorUsage(true, true)]
		private Color cur_controller_color;

		public bool isHoldingObjectLeft;

		public bool isHoldingObjectRight;

		public Transform headPos;

		private bool _isRunning;

		private Coroutine blinkHighlightCoroutine;

		private void Start()
		{
		}

		public void HIGHLIGHTACTION(TutorialRig.InputHighlight highlightedAction, int flashRate = 1)
		{
		}

		public void AXISACTION()
		{
		}

		public void FADECONTROLLER(RigManager manager, bool turnOn = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCoBlinkHighlight_003Ed__27))]
		private IEnumerator CoBlinkHighlight(Renderer renderer, float cycles = 4f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__28))]
		private IEnumerator FXChange()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CControllerFollow_003Ed__29))]
		private IEnumerator ControllerFollow(RigManager manager)
		{
			return null;
		}

		private void HighlightOff(Renderer renderer)
		{
		}
	}
}
