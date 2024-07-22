using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.VFX
{
	public class VFX_AuraHighlight : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VFX_AuraHighlight _003C_003E4__this;

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
			public _003CFXChange_003Ed__46(int _003C_003E1__state)
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

		[Header("CONTROL")]
		public bool playOnStart;

		public float timeToHighlight;

		private float cur_TimeToHighlight;

		public bool use_Particles;

		public bool use_Haze;

		public bool use_Flare;

		public bool highlightOnHover;

		public bool pingpong;

		private bool canHighlight;

		private int cur_status;

		private int tar_status;

		[Header("FLARE")]
		public AnimationCurve curve_flare;

		public GameObject fx_flare;

		public float flare_ScaleMult;

		private Vector3 start_flare_scale;

		private Vector3 target_flare_scale;

		private Vector3 cur_flare_scale;

		private Material flare_Material;

		[ColorUsage(true, true)]
		private Color start_flare_color;

		[ColorUsage(true, true)]
		private Color target_flare_color;

		[ColorUsage(true, true)]
		private Color cur_flare_color;

		[ColorUsage(true, true)]
		public Color flare_color;

		[Header("Haze")]
		public AnimationCurve curve_haze;

		public GameObject fx_haze;

		public float haze_ScaleMult;

		private Vector3 start_haze_scale;

		private Vector3 target_haze_scale;

		private Vector3 cur_haze_scale;

		private Material haze_Material;

		[ColorUsage(true, true)]
		private Color start_haze_color;

		[ColorUsage(true, true)]
		private Color target_haze_color;

		[ColorUsage(true, true)]
		private Color cur_haze_color;

		[ColorUsage(true, true)]
		public Color haze_color;

		[Header("PARTICLES")]
		public ParticleSystem fx_particles;

		public float max_particles;

		public float min_particles;

		private float cur_particles;

		private float target_particles;

		[Header("AUDIO")]
		public AudioClip clip_spawn;

		public AudioClip clip_break;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnSpawn()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void HIGHLIGHT(int condition = 0)
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__46))]
		private IEnumerator FXChange()
		{
			return null;
		}
	}
}
