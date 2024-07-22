using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ControllerToolTip : ToolTip
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerToolTip _003C_003E4__this;

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
			public _003CFXChange_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CFollowing_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerToolTip _003C_003E4__this;

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
			public _003CFollowing_003Ed__36(int _003C_003E1__state)
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

		public float timeToHighlight;

		private float cur_TimeToHighlight;

		[HideInInspector]
		public Sprite image_Sprite;

		public Sprite image_DefaultSprite;

		public SpriteRenderer spriteDisplay;

		public TextMeshPro text_ToolTip;

		public Transform lock_lineStart;

		public Transform lock_lineEnd;

		public LineRenderer line;

		[ColorUsage(true, true)]
		public Color max_text_color;

		[ColorUsage(true, true)]
		public Color min_text_color;

		[ColorUsage(true, true)]
		private Color target_text_color;

		[ColorUsage(true, true)]
		private Color cur_text_color;

		public Transform img_background;

		public AnimationCurve curve_bg;

		private Vector3 min_bg_scale;

		private Vector3 max_bg_scale;

		private Vector3 cur_bg_scale;

		private Vector3 target_bg_scale;

		[HideInInspector]
		public Transform offset_text;

		[HideInInspector]
		public bool isHoldingObject;

		[HideInInspector]
		public AudioClip clip_tutorial;

		public AudioClip clip_enable;

		public AudioClip clip_disable;

		private bool _isRunning;

		private Vector3 _lastHand;

		private Vector3 _handGimbalVel;

		private Vector3 _handGimbleAccel;

		private Vector3 _handGimbalOffset;

		private void Start()
		{
		}

		public void SETTEXT(string displaytext)
		{
		}

		public void SETLINE(bool lineActive = false, Transform lockLocation = null)
		{
		}

		public void FADETEXT(bool turnOn, bool useAudio = true)
		{
		}

		private void ClipDelay()
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__34))]
		private IEnumerator FXChange()
		{
			return null;
		}

		public void FOLLOWART(bool follow = true)
		{
		}

		[IteratorStateMachine(typeof(_003CFollowing_003Ed__36))]
		private IEnumerator Following()
		{
			return null;
		}

		private Vector3 ClampDistance(Vector3 currentpos)
		{
			return default(Vector3);
		}

		protected Vector3 SmoothDamp2(Vector3 target, ref Vector3 lastTarget, ref Vector3 gimbaledVelocity, ref Vector3 gimbalAccel, ref Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}
	}
}
