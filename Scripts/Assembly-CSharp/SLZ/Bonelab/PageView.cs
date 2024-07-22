using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PageView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoChangePage_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PageView _003C_003E4__this;

			public Page page;

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
			public _003CCoChangePage_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CCoCloseAnimation_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PageView _003C_003E4__this;

			private float[] _003Cvelocities_003E5__2;

			private float[] _003Cdamps_003E5__3;

			private float[] _003Cdurations_003E5__4;

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
			public _003CCoCloseAnimation_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CCoSummonAnimation_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PageView _003C_003E4__this;

			private float[] _003Cvelocities_003E5__2;

			private float[] _003Cdamps_003E5__3;

			private float[] _003Cdurations_003E5__4;

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
			public _003CCoSummonAnimation_003Ed__26(int _003C_003E1__state)
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

		[Header("References")]
		public GameObject audioPlacementOverride;

		public AudioClip clip_hover;

		public AudioClip clip_select;

		public AudioClip clip_closeDown;

		public AudioClip clip_summon;

		public PageItemView[] buttons;

		public PageElementView cancelButton;

		public Feedback_Audio feedback_audio;

		public Feedback_Tactile feedback_tactile;

		[HideInInspector]
		public BaseController controller;

		public GameObject TextCanvas;

		[ColorUsage(true, true)]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		private bool m_IsActivated;

		private PageItemView m_SelectedButton;

		private Page m_HomePage;

		private bool clip_closeDownFirstPlay;

		public Action<PageView> onActivated;

		public Action<PageView> onDeactivated;

		private void Start()
		{
		}

		public void SetHomePage(Page page)
		{
		}

		public Page GetHomePage()
		{
			return null;
		}

		private void CheckRefs()
		{
		}

		public void ChangePage(Page page)
		{
		}

		[IteratorStateMachine(typeof(_003CCoChangePage_003Ed__24))]
		private IEnumerator CoChangePage(Page page)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCloseAnimation_003Ed__25))]
		private IEnumerator CoCloseAnimation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSummonAnimation_003Ed__26))]
		private IEnumerator CoSummonAnimation()
		{
			return null;
		}

		public void Render(Page page)
		{
		}

		public void UpdateCursor(Vector2 uiCursorPosition)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void ShutOff()
		{
		}

		public void Clear()
		{
		}

		public bool Trigger()
		{
			return false;
		}

		public void RadialText(bool activation)
		{
		}

		private void PlayAudioClip(AudioClip clipToPlay, Transform buttonTransform = null)
		{
		}

		private void PlayHaptic(int hapticAction = 0)
		{
		}
	}
}
