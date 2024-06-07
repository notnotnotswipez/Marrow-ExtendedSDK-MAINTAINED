using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_BigAnomalyA : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003CCoLightingPos_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_BigAnomalyA _003C_003E4__this;

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
			public _003CCoLightingPos_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CCoLightningFX_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_BigAnomalyA _003C_003E4__this;

			public Vector3 target;

			private Material _003ClightningMat_003E5__2;

			private float _003ClightningProgress_003E5__3;

			private float _003ClightningTime_003E5__4;

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
			public _003CCoLightningFX_003Ed__15(int _003C_003E1__state)
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

		[Header("Animation Stuff")]
		[SerializeField]
		private GameObject bodyLogObj;

		[SerializeField]
		private GameObject lightingRoot;

		[SerializeField]
		private GameObject targetObj;

		[SerializeField]
		[Header("FX")]
		private GameObject lightningBoltObj;

		[SerializeField]
		private MeshRenderer lightningRend;

		[SerializeField]
		private GameObject lightingHitParticles;

		[SerializeField]
		private GameObject lightingHitParticles2;

		[SerializeField]
		private GameObject lightingPathParticles;

		[Header("Audio")]
		[SerializeField]
		private AudioClip shockClip;

		[SerializeField]
		private AudioClip hitClip;

		public override void Awake()
		{
		}

		public void AquireBodyLog()
		{
		}

		[ContextMenu("TestStrike")]
		public void TestStrike()
		{
		}

		public void TargetLightning(Vector3 target)
		{
		}

		[IteratorStateMachine(typeof(_003CCoLightingPos_003Ed__14))]
		private IEnumerator CoLightingPos()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoLightningFX_003Ed__15))]
		private IEnumerator CoLightningFX(Vector3 target)
		{
			return null;
		}
	}
}
