using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleAttractorBhv : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CParticleAttractor_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ParticleAttractorBhv _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CParticleAttractor_003Ed__11(int _003C_003E1__state)
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

		[HideInInspector]
		[SerializeField]
		private ParticleSystem AffectedParticles;

		public float LerpTime;

		private Transform m_rTransform;

		private ParticleSystem.Particle[] m_rParticlesArray;

		private bool m_bWorldPosition;

		private int m_iNumActiveParticles;

		private Transform m_vParticlesTarget;

		private float m_fCursor;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CParticleAttractor_003Ed__11))]
		private IEnumerator ParticleAttractor()
		{
			return null;
		}

		public void Setup()
		{
		}
	}
}
