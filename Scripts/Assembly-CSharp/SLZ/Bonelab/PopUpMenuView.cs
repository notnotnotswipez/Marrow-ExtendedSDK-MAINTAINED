using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.UI;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PopUpMenuView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoShowCursor_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpMenuView _003C_003E4__this;

			public float duration;

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
			public _003CCoShowCursor_003Ed__76(int _003C_003E1__state)
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
		private sealed class _003CCoHideCursor_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopUpMenuView _003C_003E4__this;

			public float duration;

			private Vector3 _003ClocStartPos_003E5__2;

			private Vector3 _003ClocMidPos_003E5__3;

			private Vector3 _003ClocEndPos_003E5__4;

			private Quaternion _003ClocStartRot_003E5__5;

			private Quaternion _003ClocMidRot_003E5__6;

			private Quaternion _003ClocEndRot_003E5__7;

			private float _003Ctime_003E5__8;

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
			public _003CCoHideCursor_003Ed__77(int _003C_003E1__state)
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
		public PageView radialPageView;

		public ItemSlotsPanelView itemSlotsPanelView;

		public PreferencesPanelView preferencesPanelView;

		public SpawnablesPanelView spawnablesPanelView;

		public LevelsPanelView levelsPanelView;

		public AvatarsPanelView avatarsPanelView;

		public bool canFireGun;

		public PageElementView cursorStart;

		public PageElementView cursorEnd;

		public PageElementView cursorMid;

		private float dis_uiSpawn_Near;

		private float dis_uiSpawn_Far;

		private float uiDistanceFromPlayer;

		private UIControllerInput _lastCursor;

		[HideInInspector]
		public float cur_avatarArmScaleMult;

		private Dictionary<UIControllerInput, Action> _ejectActions;

		private Transform m_RootTransform;

		private SimpleTransform m_UITransform;

		private Vector3 m_StartUIDirection;

		private Plane m_StartUIPlane;

		private bool m_IsActivated;

		private bool m_IsCursorShown;

		private bool m_IsCursorHidden;

		private float m_CursorDampModifier;

		private Vector3 m_StartCursorVel;

		private Vector3 m_EndCursorVel;

		private Vector3 m_MidCursorVel;

		private Vector3 m_RayLookDir;

		private Vector3 m_RayLookVel;

		private Vector3 m_CursorHeight;

		private bool m_IsRadialMenu;

		private bool _hasPrimaryTriggeredThisFrame;

		private bool _hasSecondaryTriggeredThisFrame;

		private float m_TimeActive;

		private float m_DurationToBlend;

		private bool m_Triggered;

		public Vector3 testVector;

		[Header("DEV TOOLS")]
		public GenericCrateReference crate_Nimbus;

		public GenericCrateReference crate_SpawnGun;

		public static Action OnDevToolSpawn;

		public static PopUpMenuView instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isActive => false;

		private Transform m_CursorTransform => null;

		private static PlayerUnlocks u => null;

		private static PlayerProgression Progression => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateStartPosition()
		{
		}

		public void Trigger(bool isDown, bool isSecondaryDown = true, UIControllerInput controllerInput = null)
		{
		}

		private void LateUpdate()
		{
		}

		public void Activate(Transform headTransform, Transform rootTransform, UIControllerInput controllerInput, BaseController controller)
		{
		}

		public void Deactivate()
		{
		}

		public void BypassToPreferences()
		{
		}

		public void DefaultRadial()
		{
		}

		public void AddPreferencesMenu()
		{
		}

		public void AddInventoryMenu()
		{
		}

		public void AddDevMenu(Action spawnDelegate)
		{
		}

		public void RemoveDevMenu()
		{
		}

		public void AddSpawnMenu()
		{
		}

		public void RemoveSpawnMenu()
		{
		}

		public void AddMagEjectMenu(UIControllerInput uiInput, Action action)
		{
		}

		public void RemoveMagEjectMenu(UIControllerInput uiInput)
		{
		}

		public void AddScenesMenu()
		{
		}

		public void RemoveScenesMenu()
		{
		}

		public void AddAvatarsMenu()
		{
		}

		public void RemoveAvatarsMenu()
		{
		}

		public void ForceHideCursor()
		{
		}

		public void ShowCursor()
		{
		}

		public void HideCursor()
		{
		}

		[IteratorStateMachine(typeof(_003CCoShowCursor_003Ed__76))]
		private IEnumerator CoShowCursor(float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoHideCursor_003Ed__77))]
		private IEnumerator CoHideCursor(float duration)
		{
			return null;
		}
	}
}
