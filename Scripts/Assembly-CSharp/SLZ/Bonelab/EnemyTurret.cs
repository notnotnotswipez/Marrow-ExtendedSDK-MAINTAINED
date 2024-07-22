using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class EnemyTurret : MonoBehaviour
	{
		private enum TurretStates
		{
			NONE = 0,
			PATROL = 1,
			ALERT = 2,
			TIPPED = 3,
			DEAD = 4,
			PANIC = 5,
			SLEEP = 6
		}

		[CompilerGenerated]
		private sealed class _003CCoSetState_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TurretStates nextState;

			public EnemyTurret _003C_003E4__this;

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
			public _003CCoSetState_003Ed__73(int _003C_003E1__state)
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
		private sealed class _003CCoPanicSequence_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private float _003CsoundTime_003E5__4;

			private float _003CsoundDuration_003E5__5;

			private float _003CwarmupDuration_003E5__6;

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
			public _003CCoPanicSequence_003Ed__78(int _003C_003E1__state)
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
		private sealed class _003CCoFlipSequence_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			private int _003CflipTries_003E5__2;

			private float _003Ctime_003E5__3;

			private float _003Cduration_003E5__4;

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
			public _003CCoFlipSequence_003Ed__81(int _003C_003E1__state)
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
		private sealed class _003CCoAlertSequence_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			private float _003ClastBurstTime_003E5__2;

			private float _003CwaitDuration_003E5__3;

			private float _003Ctime_003E5__4;

			private float _003CblinkTime_003E5__5;

			private float _003C_reloadTimer_003E5__6;

			private int _003C_calculatedBurst_003E5__7;

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
			public _003CCoAlertSequence_003Ed__84(int _003C_003E1__state)
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
		private sealed class _003CCoSearchAnimation_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			public float duration;

			private float _003CangleLimit_003E5__2;

			private float _003ChalfAngleLimit_003E5__3;

			private float _003CstartAngle_003E5__4;

			private float _003CdvtDuration_003E5__5;

			private float _003Ctime_003E5__6;

			private float _003ClastBeepTime_003E5__7;

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
			public _003CCoSearchAnimation_003Ed__87(int _003C_003E1__state)
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
		private sealed class _003CCoTippedCheck_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			public Action<bool> callback;

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
			public _003CCoTippedCheck_003Ed__91(int _003C_003E1__state)
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
		private sealed class _003CCoPackLegs_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			private Vector3 _003CstartSpine_003E5__2;

			private Quaternion _003CstartLegRear_003E5__3;

			private Quaternion _003CstartLegHingLeft_003E5__4;

			private Quaternion _003CstartLegLeft_003E5__5;

			private Quaternion _003CstartLegHingRight_003E5__6;

			private Quaternion _003CstartLegRight_003E5__7;

			private Vector3 _003CendSpine_003E5__8;

			private Quaternion _003CendLegRear_003E5__9;

			private Quaternion _003CendLegHingLeft_003E5__10;

			private Quaternion _003CendLegLeft_003E5__11;

			private Quaternion _003CendLegHingRight_003E5__12;

			private Quaternion _003CendLegRight_003E5__13;

			private float _003Cduration_003E5__14;

			private float _003Ctime_003E5__15;

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
			public _003CCoPackLegs_003Ed__93(int _003C_003E1__state)
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
		private sealed class _003CCoUnPackLegs_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyTurret _003C_003E4__this;

			private Vector3 _003CstartSpine_003E5__2;

			private Quaternion _003CstartLegRear_003E5__3;

			private Quaternion _003CstartLegHingLeft_003E5__4;

			private Quaternion _003CstartLegLeft_003E5__5;

			private Quaternion _003CstartLegHingRight_003E5__6;

			private Quaternion _003CstartLegRight_003E5__7;

			private Vector3 _003CendSpine_003E5__8;

			private Quaternion _003CendLegRear_003E5__9;

			private Quaternion _003CendLegHingLeft_003E5__10;

			private Quaternion _003CendLegLeft_003E5__11;

			private Quaternion _003CendLegHingRight_003E5__12;

			private Quaternion _003CendLegRight_003E5__13;

			private float _003Cduration_003E5__14;

			private float _003Ctime_003E5__15;

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
			public _003CCoUnPackLegs_003Ed__94(int _003C_003E1__state)
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
		public LayerMask raycastMask;

		public bool isRotateTowardsLastTargetOnJump;

		public float visionRadius;

		public float visionAngle;

		public int maxUnflipTries;

		public int _burstCount;

		public float _reloadDelay;

		public float _burstDelay;

		[ColorUsage(true, true)]
		public Color idleColor;

		[ColorUsage(true, true)]
		public Color alertColor;

		[Header("References")]
		public InteractableHost host;

		public Collider[] ignoreColliders;

		public GameObject laserPointer;

		public Transform visionPointTransform;

		public Gun gun;

		[Header("Joint References")]
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

		public Action OnDeath;

		public Action OnResurrection;

		private ConfigurableJoint _flipJoint;

		private bool _isPacked;

		private bool _isTipped;

		private bool _hasBeenTipped;

		private Collider[] _collectedColliders;

		private int _maxCollidersCollected;

		private Quaternion _gunJntStartRotation;

		private Quaternion _bodyJntStartRotation;

		private Transform _targetTransform;

		private RigidbodySettings _rigidbodySettings;

		private Rigidbody _rigidbody;

		private bool _immediateFlip;

		private GenericTurretSFX _sfx;

		private float _timeLastSleep;

		private Coroutine _flipSequenceCoroutine;

		private Coroutine _alertSequenceCoroutine;

		private Coroutine _searchCoroutine;

		private Coroutine _visionCheckCoroutine;

		private Coroutine _packLegsCoroutine;

		private Coroutine _setStateCoroutine;

		private Coroutine _panicSequenceCoroutine;

		private Coroutine _tippedCheckCoroutine;

		private SimpleTransform _bodyLocal;

		private SimpleTransform _barrelLocal;

		private SimpleTransform _hingeLLocal;

		private SimpleTransform _legLLocal;

		private SimpleTransform _hingeRLocal;

		private SimpleTransform _legRLocal;

		private SimpleTransform _rearSliderLocal;

		private SimpleTransform _rearLegLocal;

		private TurretStates state;

		private TurretStates bufferState;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void TriggerFire()
		{
		}

		public void ToggleSleep()
		{
		}

		public void Kill()
		{
		}

		private void SetState(TurretStates nextState)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSetState_003Ed__73))]
		private IEnumerator CoSetState(TurretStates nextState)
		{
			return null;
		}

		private void LookAtTarget()
		{
		}

		private void JointLookRotation(ConfigurableJoint joint, Quaternion startRotation, Quaternion lookRotation)
		{
		}

		private void StartPanicSequence()
		{
		}

		private void StopPanicSequence()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPanicSequence_003Ed__78))]
		private IEnumerator CoPanicSequence()
		{
			return null;
		}

		private void StartFlipSequence()
		{
		}

		private void StopFlipSequence()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFlipSequence_003Ed__81))]
		private IEnumerator CoFlipSequence()
		{
			return null;
		}

		private void StartAlertSequence()
		{
		}

		private void StopAlertSequence()
		{
		}

		[IteratorStateMachine(typeof(_003CCoAlertSequence_003Ed__84))]
		private IEnumerator CoAlertSequence()
		{
			return null;
		}

		private void StartSearchAnimation()
		{
		}

		private void StopSearchAnimation()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSearchAnimation_003Ed__87))]
		private IEnumerator CoSearchAnimation(float duration = 10f)
		{
			return null;
		}

		private void StopVisionCheck()
		{
		}

		private void StartTippedCheck(Action<bool> callback)
		{
		}

		private void StopTippedCheck()
		{
		}

		[IteratorStateMachine(typeof(_003CCoTippedCheck_003Ed__91))]
		private IEnumerator CoTippedCheck(Action<bool> callback)
		{
			return null;
		}

		private void PackLegs(bool isPacking = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCoPackLegs_003Ed__93))]
		private IEnumerator CoPackLegs()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoUnPackLegs_003Ed__94))]
		private IEnumerator CoUnPackLegs()
		{
			return null;
		}
	}
}
