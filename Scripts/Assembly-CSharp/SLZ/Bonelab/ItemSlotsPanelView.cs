using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ItemSlotsPanelView : PanelView
	{
		[CompilerGenerated]
		private sealed class _003CCoCloseAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
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

			[DebuggerHidden]
			public _003CCoCloseAnimation_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CCoSummonAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
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

			[DebuggerHidden]
			public _003CCoSummonAnimation_003Ed__13(int _003C_003E1__state)
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

		public UIRig uiRig;

		public Transform[] slotTargets;

		private Inventory inventory;

		public PageElementView[] slots;

		public bool displayHud;

		public UI_HUD objectHud;

		[HideInInspector]
		public bool isInventoryOpen;

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

		public void HOTSWAP(bool tempMove = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCloseAnimation_003Ed__12))]
		private IEnumerator CoCloseAnimation(Action callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSummonAnimation_003Ed__13))]
		private IEnumerator CoSummonAnimation()
		{
			return null;
		}
	}
}
