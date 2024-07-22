using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class LaserCursor : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
	{
		[Serializable]
		public struct CursorRegion
		{
			public Transform center;

			public Bounds bounds;
		}

		[CompilerGenerated]
		private sealed class _003CFireRayPulse_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LaserCursor _003C_003E4__this;

			private bool _003CmidFire_003E5__2;

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
			public _003CFireRayPulse_003Ed__65(int _003C_003E1__state)
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

		protected bool m_isActive;

		private bool m_IsActiveThisFrame;

		private bool m_IsTriggeredDown;

		private bool m_IsTrigger;

		public PageElementView cursorStart;

		public PageElementView cursorEnd;

		public PageElementView cursorMid;

		public PageElementView cursorMid2;

		public PageElementView cursorBez;

		public PageElementView rayPulse;

		public PageElementView lineEnd;

		public LineRenderer cursorLine;

		public DrawBezierCurve bezCurve;

		private Quaternion rayRotation;

		public float pulseLength;

		private float pulseProgress;

		private float curentPulseTime;

		private bool isFireingPulse;

		public AnimationCurve pulseAceleration;

		public AudioClip[] pulseSound;

		public AudioClip[] raySpawn;

		public AudioClip[] rayDespawn;

		public PrismaticSFX prismaticSFX;

		private int _last_pulse;

		private int _last_spawn;

		private int _last_despawn;

		private Transform location;

		[Range(0f, 1f)]
		[Tooltip("Is the sound 2d or 3d?")]
		[Header("AudioSettings")]
		public float spatialBlend;

		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		[Range(0f, 1f)]
		public float _sourceVolume;

		[Range(0.1f, 10f)]
		[Space(10f)]
		public float _sourceRadius;

		public bool cursorHidden;

		public bool canShowCursor;

		public CursorRegion[] regions;

		private Vector3 m_StartCursorVel;

		private Vector3 m_EndCursorVel;

		private Vector3 m_MidCursorVel;

		private Vector3 m_MidCursorVel2;

		private Vector3 m_bezCurveVel;

		private Vector3 m_RayLookDir;

		private Vector3 m_RayLookVel;

		private Vector3 m_CursorHeight;

		private Vector3 m_lockedToButton;

		[Header("Knoll Filter")]
		[Range(0f, 200f)]
		public float maxMillimeters;

		private BaseController activeController;

		private Plane startPlane;

		private Transform planeTransform;

		private Ray ray;

		private bool isOnPlane;

		private bool isRegionActive;

		private Vector3 startPosition;

		private Vector3 endPosition;

		private Dictionary<BaseController, Transform> controllerInput;

		private bool controllerFocused;

		private bool holdForStart;

		private VRStandaloneInputModule _module;

		private BaseController[] controllers;

		private VRStandaloneInputModule module => null;

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		public virtual void Activate()
		{
		}

		public virtual void Deactivate()
		{
		}

		public virtual bool Trigger()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CFireRayPulse_003Ed__65))]
		private IEnumerator FireRayPulse()
		{
			return null;
		}

		public void UpdateCursor(Vector3 origin, Vector3 forward, bool isPressed)
		{
		}

		public void Clear()
		{
		}

		public void ShowCursor()
		{
		}

		public void HideCursor()
		{
		}

		private void CalcCursor()
		{
		}

		private void Update()
		{
		}

		private void KnollFilter(Transform filter, Vector3 trackedPos, float grip = 1f)
		{
		}

		public void AUDIOSEND(int soundAction = 0)
		{
		}

		private void PlayAudio(AudioClip clipToPlay, Vector3 location)
		{
		}
	}
}
