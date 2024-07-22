using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BoardGenerator : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBoardSpawnerAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BoardGenerator _003C_003E4__this;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003Clineloop_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoardGenerator _003C_003E4__this;

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
			public _003Clineloop_003Ed__40(int _003C_003E1__state)
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

		[SerializeField]
		private bool isUsingAmmo;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private Transform FirePoint;

		[SerializeField]
		private float RaycastDistance;

		[SerializeField]
		private float breakforce;

		[SerializeField]
		private Material LineMaterial;

		[SerializeField]
		private Spawnable[] boardSpawnable;

		[SerializeField]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private GameObject laserPointer;

		public AudioClip[] startSFX;

		public AudioClip[] endSFX;

		public AudioClip[] misfireSFX;

		private ManagedAudioPlayer _mapActions;

		private bool ButtonDown;

		private bool Valid;

		private Vector3 firstPoint;

		private Vector3 EndPoint;

		private MarrowBody FirstRb;

		private MarrowBody EndRb;

		private float distance;

		public float ammoDistance;

		private Vector3 upDir;

		public LineRenderer line;

		private int playerLayer;

		private int enemyLayer;

		public HashSet<ObjectDestructible> destBoardHash;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CBoardSpawnerAsync_003Ed__29))]
		private UniTaskVoid BoardSpawnerAsync()
		{
			return default(UniTaskVoid);
		}

		private void OnBoardDestruction(ObjectDestructible destObj)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void PrimaryButtonDown()
		{
		}

		private void PrimaryButtonUp()
		{
		}

		public void CeaseFire()
		{
		}

		private void Thingy()
		{
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		[IteratorStateMachine(typeof(_003Clineloop_003Ed__40))]
		private IEnumerator lineloop()
		{
			return null;
		}

		private void SetJoint(Vector3 position, MarrowBody bodyB, MarrowBody bodyA)
		{
		}
	}
}
