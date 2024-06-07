using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PillarMirrorAnimationController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTurnOffMirror_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PillarMirrorAnimationController _003C_003E4__this;

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
			public _003CTurnOffMirror_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CMirroPulse_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PillarMirrorAnimationController _003C_003E4__this;

			public float percent;

			public bool permanent;

			private int _003Ci_003E5__2;

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
			public _003CMirroPulse_003Ed__23(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CstartSequence_async_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PillarMirrorAnimationController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public GameObject centerFragment;

		public GameObject mirrorColider;

		public List<GameObject> mirrorFragments;

		public Transform audioTransform;

		public float maxMirrorTicTime;

		public float randomRotationOffset;

		public Mirror mirror;

		public Spawnable avatarBlaster;

		public Spawnable hitBlaster;

		public ParticleSystemForceField forceField;

		public GameObject reflectionRoot;

		public AudioClip[] cryptidScream;

		public AudioClip[] mirrorBreak;

		public Encounter mirrorEncounter;

		public float startDelay;

		public Animator animator;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[ContextMenu("MirrorBlip")]
		public void MirrorBlip()
		{
		}

		[IteratorStateMachine(typeof(_003CTurnOffMirror_003Ed__19))]
		private IEnumerator TurnOffMirror()
		{
			return null;
		}

		private void PlayParticleSystem(SkinnedMeshRenderer meshRen, bool useForceField = true)
		{
		}

		[ContextMenu("Pulse100PrcOn")]
		public void Pulse100PrcOn()
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CMirroPulse_003Ed__23))]
		public IEnumerator MirroPulse(float percent, bool permanent = false)
		{
			return null;
		}

		public void PlayHitEffect()
		{
		}

		public void BurstBoids()
		{
		}

		public void startSequence()
		{
		}

		[AsyncStateMachine(typeof(_003CstartSequence_async_003Ed__27))]
		private UniTaskVoid startSequence_async()
		{
			return default(UniTaskVoid);
		}
	}
}
