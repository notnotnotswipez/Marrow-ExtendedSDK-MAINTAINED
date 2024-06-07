using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.SFX
{
	public class RollingSFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateSound_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RollingSFX _003C_003E4__this;

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
			public _003CUpdateSound_003Ed__18(int _003C_003E1__state)
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

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		public MarrowBody[] mbWheels;

		public GameObject sourceObj;

		public float maxAngularV;

		public float realtimeUpdateFrequency;

		public float wheelRadius;

		public float minSpeed;

		public float maxSpeed;

		private ManagedAudioPlayer _mapLoop;

		private bool _hasAp;

		public AudioClip spinningNotColliding;

		public AudioClip rollingWithCollision;

		private bool wheelColliding;

		private WaitForSecondsRealtime _wfsRealtime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter()
		{
		}

		private void OnCollisionExit()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateSound_003Ed__18))]
		private IEnumerator UpdateSound()
		{
			return null;
		}
	}
}
