using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ItemSlotsPanelView : PanelView
	{
		[CompilerGenerated]
		private sealed class _003CCoCloseAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ItemSlotsPanelView _003C_003E4__this;

			public Action callback;

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
			public _003CCoCloseAnimation_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CCoSummonAnimation_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ItemSlotsPanelView _003C_003E4__this;

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
			public _003CCoSummonAnimation_003Ed__25(int _003C_003E1__state)
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

		public UIRig uiRig;

		public SimpleSFX SimpleSfx;

		private Inventory inventory;

		private List<UnityAction> EnableActiveHoverEleActions;

		private List<UnityAction> DisableActiveHoverEleActions;

		private List<UnityAction> DisableInactiveHoverEleActions;

		private List<UnityAction> EnableInactiveHoverEleActions;

		private UnityAction PlayActiveSoundAction;

		private UnityAction PlayDropSoundAction;

		public Transform[] slotTargets;

		public PageElementView[] slots;

		public GameObject[] activeHoverEleObjs;

		public GameObject[] inactiveHoverEleObjs;

		public bool displayHud;

		public UI_HUD objectHud;

		[HideInInspector]
		public bool isInventoryOpen;

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public override bool Trigger()
		{
			return false;
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void RegisterBodySlotEvents()
		{
		}

		private void UnregisterBodySlotEvents()
		{
		}

		public void HOTSWAP(bool tempMove = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCloseAnimation_003Ed__24))]
		private IEnumerator CoCloseAnimation(Action callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSummonAnimation_003Ed__25))]
		private IEnumerator CoSummonAnimation()
		{
			return null;
		}
	}
}
