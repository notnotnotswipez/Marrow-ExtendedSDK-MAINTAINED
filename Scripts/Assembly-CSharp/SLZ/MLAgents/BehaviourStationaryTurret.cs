using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.PuppetMasta;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BehaviourStationaryTurret : BehaviourGrabbableBaseNav
	{
		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__41(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CSearchAnimationRoutine_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CSearchAnimationRoutine_003Ed__94(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelayedInvestigate_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CDelayedInvestigate_003Ed__95(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoPanicSequence_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CCoPanicSequence_003Ed__118(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoPackSequence_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CCoPackSequence_003Ed__119(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoUnPackSequence_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CCoUnPackSequence_003Ed__120(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CBurstFire_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CBurstFire_003Ed__121(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRestingLightPulse_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourStationaryTurret _003C_003E4__this;

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
			public _003CRestingLightPulse_003Ed__123(int _003C_003E1__state)
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

		[Header("Settings")]
		[Header("References")]
		public InteractableHost host;

		public Collider[] ignoreColliders;

		public Rigidbody _rigidbody;

		[Header("Joint References")]
		public bool foldableJoints;

		public bool crumbleDeath;

		public bool blockLook;

		public ConfigurableJoint spineSlideJnt;

		public ConfigurableJoint legRearJnt;

		public ConfigurableJoint legHingeLeftJnt;

		public ConfigurableJoint legHingeRightJnt;

		public ConfigurableJoint legLeftJnt;

		public ConfigurableJoint legRightJnt;

		public ConfigurableJoint bodyJnt;

		public ConfigurableJoint gunJnt;

		[Header("Joint Rigidbody References")]
		public Rigidbody bodyRB;

		public Rigidbody barrelRB;

		public Rigidbody hingeLRB;

		public Rigidbody legLRB;

		public Rigidbody hingeRRB;

		public Rigidbody legRRB;

		public Rigidbody rearSliderRB;

		public Rigidbody rearLegRB;

		private Rigidbody[] rbs;

		public MeshRenderer innerGlowRender;

		public MeshRenderer outerGlowRender;

		public GenericTurretSFX _sfx;

		public bool debugDrawLine;

		private AIBrain aiBrain;

		private float _timeLastSleep;

		private float _tempDamage;

		private Muscle.Group _tempGroup;

		private Coroutine _panicSequenceCoroutine;

		public int maxUnflipTries;

		private float _agroTime;

		[Header("Mental State")]
		public float searchDuration;

		public float panicDuration;

		public float panicSoundDuration;

		public float panicGunfireDuration;

		public float panicFireRate;

		public int burstCount;

		public float reloadDelay;

		public float burstDelay;

		public float burstWaitDuration;

		private bool _isBursting;

		private float _lastBurstTime;

		private int _calculatedBurst;

		[Header("Gun")]
		public bool useRaycastAgro;

		public GameObject laserPointer;

		public BoxCollider laserCollider;

		public Gun gun;

		private float _reloadTimer;

		private float _searchTime;

		private int _searchTicker;

		private float _lastBeepTime;

		private bool _hasSearchStarted;

		private float _searchStartAngle;

		private ConfigurableJoint _flipJoint;

		private bool _isTipped;

		private float _bodyAngleLimit;

		private Quaternion _tempLookRot;

		private JointDrive tempXDrive;

		private JointDrive tempYZDrive;

		public float unpackSpring;

		public float unpackDamper;

		private float _tempVel;

		private float _panicTime;

		private float _panicSoundTime;

		private float _panicFireTime;

		private float _unpackTime;

		private float _unpackDuration;

		private float _unpackSpring;

		private float _unpackDamper;

		private int _fireCount;

		private void InitFunctions()
		{
		}

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		protected override void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		public override void KillStart()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__41))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillEnd()
		{
		}

		protected override void RestoreFromCrumbleDeath()
		{
		}

		protected override void DoCrumbleDeath()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		public override void OnPoolSpawn()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		private void OnDisable()
		{
		}

		private void IgnoreColliders()
		{
		}

		[ContextMenu("Force Investigate")]
		private void ForceInvestigate()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		private void LookAtTarget()
		{
		}

		private void JointLookRotation(int muscleInd, Quaternion lookRotation)
		{
		}

		private bool TippedCheck()
		{
			return false;
		}

		private int SearchTickerConversion()
		{
			return 0;
		}

		private void InitForSearch(float duration = 10f)
		{
		}

		private void SearchAnimationStepper(float duration = 10f)
		{
		}

		private void SearchAnimationStepper_Physics(float duration = 10f)
		{
		}

		[IteratorStateMachine(typeof(_003CSearchAnimationRoutine_003Ed__94))]
		private IEnumerator SearchAnimationRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayedInvestigate_003Ed__95))]
		private IEnumerator DelayedInvestigate()
		{
			return null;
		}

		[ContextMenu("Pack Legs True")]
		private void PackLegsTrue()
		{
		}

		[ContextMenu("Pack Legs False ")]
		private void PackLegsFalse()
		{
		}

		[ContextMenu("Force Unpack")]
		private void ForceUnpackLegs()
		{
		}

		[ContextMenu("Force Pack")]
		private void ForcePackLegs()
		{
		}

		[ContextMenu("Trigger Fire")]
		public void TriggerFire()
		{
		}

		[ContextMenu("Toggle Sleep")]
		public void ToggleSleep()
		{
		}

		private void InitGlowMaterials()
		{
		}

		private void SetGlowMaterials(bool agro = true)
		{
		}

		private void NullCoroutines()
		{
		}

		private void StartPanicSequence()
		{
		}

		private void StopPanicSequence()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPanicSequence_003Ed__118))]
		private IEnumerator CoPanicSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoPackSequence_003Ed__119))]
		private IEnumerator CoPackSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoUnPackSequence_003Ed__120))]
		private IEnumerator CoUnPackSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBurstFire_003Ed__121))]
		private IEnumerator BurstFire()
		{
			return null;
		}

		private float Oscillate(float minValue, float maxValue, float frequency, float t)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CRestingLightPulse_003Ed__123))]
		private IEnumerator RestingLightPulse()
		{
			return null;
		}
	}
}
