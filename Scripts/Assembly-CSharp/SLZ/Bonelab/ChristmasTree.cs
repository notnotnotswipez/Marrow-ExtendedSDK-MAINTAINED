using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChristmasTree : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPLAY_MUSIC_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChristmasTree _003C_003E4__this;

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
			public _003CPLAY_MUSIC_003Ed__13(int _003C_003E1__state)
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

		private int timeScaleStep;

		private int maxTimeScaleStep;

		private bool tree_A;

		private bool tree_B;

		private bool tree_C;

		public ConfigurableJoint jnt_tree_A;

		public ConfigurableJoint jnt_tree_B;

		public ConfigurableJoint jnt_tree_C;

		private float targetRot_A;

		private float targetRot_B;

		private float targetRot_C;

		public AudioSource musicPlayer;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CPLAY_MUSIC_003Ed__13))]
		public IEnumerator PLAY_MUSIC()
		{
			return null;
		}

		public void SlowTime(int target)
		{
		}

		private void SetRotation()
		{
		}

		private void ToggleTimeScale()
		{
		}

		private void DecreaseTimeScale()
		{
		}

		private void IncreaseTimeScale()
		{
		}

		private void SetTimeScale(int step)
		{
		}

		private void AutoDecrease()
		{
		}
	}
}
