using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MirrorCheatCollider : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CReflectionCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MirrorCheatCollider _003C_003E4__this;

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
			public _003CReflectionCoroutine_003Ed__9(int _003C_003E1__state)
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

		public GameObject avatarRoot;

		public GameObject reflectionCollider;

		private List<GameObject> avatars;

		private bool doReflectionTrack;

		private IEnumerator reflectionTrackCoroutine;

		private static readonly WaitForSeconds waitPointOneSeconds;

		public void Start()
		{
		}

		public void StartReflectionTrack()
		{
		}

		public void StopReflectionTrack()
		{
		}

		[IteratorStateMachine(typeof(_003CReflectionCoroutine_003Ed__9))]
		private IEnumerator ReflectionCoroutine()
		{
			return null;
		}
	}
}
