using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.SFX;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaPopFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GachaPopFX _003C_003E4__this;

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
			public _003CFXChange_003Ed__24(int _003C_003E1__state)
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

		public TextMeshPro text_unlockedItemType;

		public TextMeshPro text_unlockedItemName;

		public SpriteRenderer image_item;

		public string unlockedItemType;

		public string unlockedItemName;

		public AnimationCurve curve_colorSize;

		public float holdTime;

		private float stopTime;

		public GameObject particlers;

		public Vector3 scale_target;

		private Vector3 scale_start_img;

		private Vector3 scale_start_uit;

		private Vector3 scale_start_uin;

		public Color32 color_transparent;

		private Color32 color_start_img;

		private Color32 color_start_uit;

		private Color32 color_start_uin;

		public SimpleSFX sfx_gacha;

		public Transform textTransform;

		public bool followHUD;

		public UI_HUD UIHUD;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void PLAYFX(string itemType = "", string itemName = "")
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__24))]
		private IEnumerator FXChange()
		{
			return null;
		}
	}
}
