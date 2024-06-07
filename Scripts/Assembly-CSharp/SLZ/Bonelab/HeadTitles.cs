using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HeadTitles : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HeadTitles _003C_003E4__this;

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
			public _003CFXChange_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CFollow_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HeadTitles _003C_003E4__this;

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
			public _003CFollow_003Ed__51(int _003C_003E1__state)
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

		public RigManager manager;

		public Transform headFollower;

		public float defaultTime;

		public float offsetDistance;

		[Header("HEAD TITLES DEFAULT")]
		public GameObject defaultTitles;

		public TextMeshPro text_Title;

		public TextMeshPro text_SubTitle;

		public SpriteRenderer sr_element;

		public SpriteRenderer sr_background;

		public Sprite defaultElementSprite;

		public Sprite defaultBackgroundSprite;

		[HideInInspector]
		public bool displayDefault;

		[Header("HEAD TITLES CUSTOM")]
		public GameObject avatarTitles;

		public SpriteRenderer spriterA;

		public SpriteRenderer spriterB;

		public SpriteRenderer spriterC;

		public SpriteRenderer spriterD;

		[HideInInspector]
		public Sprite spriteA;

		[HideInInspector]
		public Sprite spriteB;

		[HideInInspector]
		public Sprite spriteC;

		[HideInInspector]
		public Sprite spriteD;

		private string _string_Title;

		private string _string_SubTitle;

		private Sprite _spriteToDisplay;

		private Sprite _backgroundSpriteToDisplay;

		private Transform playerHead;

		private Vector3 _offsetPlacement;

		private Vector3 _offsetDirection;

		private int _actionPhase;

		private float _curTimeToHold;

		private float _timeToHold;

		[Header("SCALE")]
		public AnimationCurve curveScale;

		public float timeToScale;

		private Vector3 _curFollowerScale;

		private Vector3 _tarFollowerScale;

		private float _curTimeToScale;

		private Vector3 _lastHead;

		private Vector3 _headGimbalVel;

		private Vector3 _headGimbleAccel;

		private Vector3 _headGimbalOffset;

		[Header("AUDIO")]
		private AudioClip _clip;

		public AudioClip clip_enable;

		public AudioClip clip_disable;

		private void Start()
		{
		}

		public void OnDisable()
		{
		}

		public void CUSTOMDISPLAY(string incomingTitle = "", string incomingSubTitle = "", Sprite incomingSprite = null, float holdTime = 0f, AudioClip audioClip = null, bool isAvatarLevel = false, Sprite sprite_A = null, Sprite sprite_B = null, Sprite sprite_C = null, Sprite sprite_D = null)
		{
		}

		public void OPENDISPLAY()
		{
		}

		public void CLOSEDISPLAY()
		{
		}

		private void UpdateDisplay()
		{
		}

		private void PlayAudio(AudioClip clipToPlay)
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__50))]
		private IEnumerator FXChange()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFollow_003Ed__51))]
		private IEnumerator Follow()
		{
			return null;
		}

		protected Vector3 SmoothDamp2(Vector3 target, ref Vector3 lastTarget, ref Vector3 gimbaledVelocity, ref Vector3 gimbalAccel, ref Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}
	}
}
