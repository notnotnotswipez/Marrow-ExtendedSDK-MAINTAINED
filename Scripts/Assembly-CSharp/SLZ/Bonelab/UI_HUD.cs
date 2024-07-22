using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UI_HUD : MonoBehaviour
	{
		public enum AmmoDisplayLocation
		{
			None = 0,
			Belt = 1,
			Head = 2,
			Inventory = 3
		}

		[CompilerGenerated]
		private sealed class _003CAmmoFollow_Coroutine_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_HUD _003C_003E4__this;

			private bool _003CrunRoutine_003E5__2;

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
			public _003CAmmoFollow_Coroutine_003Ed__67(int _003C_003E1__state)
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
		private sealed class _003CResetLevel_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool opening;

			public UI_HUD _003C_003E4__this;

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
			public _003CResetLevel_003Ed__69(int _003C_003E1__state)
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
		private sealed class _003CProgressBar_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_HUD _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private float _003CprogressLength_003E5__3;

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
			public _003CProgressBar_003Ed__70(int _003C_003E1__state)
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
		private sealed class _003CHUD_SoftFollow_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_HUD _003C_003E4__this;

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
			public _003CHUD_SoftFollow_003Ed__74(int _003C_003E1__state)
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
		private sealed class _003CHeadFollowTimmer_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_HUD _003C_003E4__this;

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
			public _003CHeadFollowTimmer_003Ed__75(int _003C_003E1__state)
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

		[Header("GENERAL")]
		public UIRig uiRig;

		public Transform target_HEADFOLLOWER;

		public float offset_HeadDistance;

		private Transform _playerHead;

		private Vector3 _offset_headPlacement;

		private Vector3 _offset_headDirection;

		private Vector3 _lastHead;

		private Vector3 _headGimbalVel;

		private Vector3 _headGimbleAccel;

		private Vector3 _headGimbalOffset;

		private IEnumerator _co_follow_head;

		private bool _followingHead;

		private IEnumerator _co_headFollowTimmer;

		private float _headFollowCountDown;

		[HideInInspector]
		[Header("MODULE - UI AMMO")]
		public bool showLowAmmoPopup;

		[HideInInspector]
		public bool lowAmmoPopupRight;

		public string emptyNote;

		public TextMeshPro text_ammo_light;

		public TextMeshPro text_ammo_medium;

		public TextMeshPro text_ammo_heavy;

		public GameObject hud_AMMO;

		public Transform target_ammo_inventory;

		public Transform target_ammo_head_left;

		public Transform target_ammo_head_right;

		public Transform target_ammo_belt;

		public int lowAmmoLight;

		public int lowAmmoMedium;

		public int lowAmmoHeavy;

		private IEnumerator _co_ammo_follow;

		public AmmoDisplayLocation ammo_displayLocation;

		private Transform _cur_ammo_displayLocation;

		[Header("MODULE - RESET")]
		public GameObject hud_RESETLEVEL;

		public MeshRenderer hud_ResetProgressBar;

		public AudioClip clip_resetLevel_cancel;

		public AudioClip clip_resetLevel_hold;

		public AudioSource sfx_resetLevel;

		public Transform target_resetLevel_head;

		public AnimationCurve curve_scale;

		public float timeToScale;

		private IEnumerator _co_resetLevel_follow;

		private IEnumerator _co_progressBar;

		private float _resetLevel_timeToScale;

		private float _cur_resetLevel_timeToScale;

		private Vector3 _cur_resetLevel_scale;

		private Vector3 _tar_resetLevel_scale;

		private bool _resetting;

		private static readonly int Float0;

		private WeaponSlot rightGun;

		private WeaponSlot leftGun;

		private void Awake()
		{
		}

		private void OnLevelLoad()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UIHudSetup()
		{
		}

		public void UpdateUI()
		{
		}

		private void DisplayAmmo()
		{
		}

		private void DisplayReloadLevel()
		{
		}

		private void OnHandItemSlotRight(InventorySlot slot)
		{
		}

		public void OnHandItemSlotRemovedRight(InventorySlot slot)
		{
		}

		private void OnHandItemSlotLeft(InventorySlot slot)
		{
		}

		public void OnHandItemSlotRemovedLeft(InventorySlot slot)
		{
		}

		private void GetWeaponFromSlot(InventorySlot slot, bool rightHand, bool grab)
		{
		}

		private void CheckAmmoForHeldGuns()
		{
		}

		private bool IsAmmoLowByCartridge(CartridgeData cartridge)
		{
			return false;
		}

		public void SHOWAMMO(AmmoDisplayLocation ammoLocation = AmmoDisplayLocation.None)
		{
		}

		[IteratorStateMachine(typeof(_003CAmmoFollow_Coroutine_003Ed__67))]
		private IEnumerator AmmoFollow_Coroutine()
		{
			return null;
		}

		public void POPUPRELOADSCENE(bool display = false)
		{
		}

		[IteratorStateMachine(typeof(_003CResetLevel_003Ed__69))]
		private IEnumerator ResetLevel(bool opening)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CProgressBar_003Ed__70))]
		private IEnumerator ProgressBar()
		{
			return null;
		}

		public void INVENTORYOPEN(bool opened)
		{
		}

		public void HEADHUDFOLLOW(bool followHead = false)
		{
		}

		public void HEADHUDFOLLOWTIMED(float seconds)
		{
		}

		[IteratorStateMachine(typeof(_003CHUD_SoftFollow_003Ed__74))]
		private IEnumerator HUD_SoftFollow()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHeadFollowTimmer_003Ed__75))]
		private IEnumerator HeadFollowTimmer()
		{
			return null;
		}

		protected Vector3 SmoothDamp2(Vector3 target, ref Vector3 lastTarget, ref Vector3 gimbaledVelocity, ref Vector3 gimbalAccel, ref Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}
	}
}
