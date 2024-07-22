using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ShockTrap : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoBlinkCharge_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShockTrap _003C_003E4__this;

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
			public _003CCoBlinkCharge_003Ed__48(int _003C_003E1__state)
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
		private sealed class _003CCoChargeShock_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShockTrap _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003CchargeLerp_003E5__4;

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
			public _003CCoChargeShock_003Ed__49(int _003C_003E1__state)
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
		private sealed class _003CCoShock_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShockTrap _003C_003E4__this;

			private List<TriggerRefProxy>.Enumerator _003C_003E7__wrap1;

			private TriggerRefProxy _003Cproxy_003E5__3;

			private Material _003ClightningMat_003E5__4;

			private float _003ClightningProgress_003E5__5;

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
			public _003CCoShock_003Ed__55(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
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
		private sealed class _003CCoLightningFX_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShockTrap _003C_003E4__this;

			public Vector3 target;

			private Material _003ClightningMat_003E5__2;

			private float _003ClightningProgress_003E5__3;

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
			public _003CCoLightningFX_003Ed__59(int _003C_003E1__state)
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
		private sealed class _003CCoPortalPlay_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShockTrap _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003CscaleLerp_003E5__4;

			private Vector3 _003CstartScale_003E5__5;

			private Vector3 _003CendScale_003E5__6;

			private Vector3 _003CstartPos_003E5__7;

			private Vector3 _003CendPos_003E5__8;

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
			public _003CCoPortalPlay_003Ed__64(int _003C_003E1__state)
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

		public KeyReceiver keyReceiver;

		[SerializeField]
		private DoorLightControl[] doorLightControls;

		public ObjectiveBattery battery;

		private int minCharge;

		[SerializeField]
		public Spawnable blasterLightning;

		public GameObject[] shockPoints;

		public List<TriggerRefProxy> npcList;

		public List<TriggerRefProxy> deadProxyList;

		public HashSet<TriggerRefProxy> npcProxyHash;

		public GenGameControl_Trigger shockFieldTrigger;

		private Coroutine shockRoutine;

		[SerializeField]
		private GameObject batteryObj;

		[SerializeField]
		private bool isShockReady;

		[SerializeField]
		private int shockCost;

		[SerializeField]
		[Header("Audio")]
		private AudioClip shockClip;

		[SerializeField]
		private AudioClip hitClip;

		[SerializeField]
		private AudioClip denyClip;

		[SerializeField]
		private AudioClip chargeClip;

		[SerializeField]
		private AudioClip fullChargeClip;

		[SerializeField]
		[Header("FX")]
		private GameObject lightningBoltObj;

		[SerializeField]
		private MeshRenderer lightningRend;

		[SerializeField]
		private GameObject lightingHitParticles;

		[SerializeField]
		private GameObject lightingPathParticles;

		[SerializeField]
		private GameObject[] shockPointPartObjs;

		[SerializeField]
		private ParticleSystem[] shockPointParticles;

		public GameObject[] tankScalerObjs;

		private int currTank;

		private Vector3 maxTankScale;

		private Vector3 startBar;

		private Vector3 endBar;

		private float currTankEnergy;

		public GameObject voidHoleObj;

		public float initScaleDuration;

		[SerializeField]
		private DoorLightControl chargeLightControl;

		[SerializeField]
		private GameObject chargeIndicator;

		private Vector3 startScale;

		private Vector3 endScale;

		private Coroutine chargeRoutine;

		public UnityEvent OnBatteryAccepted;

		[SerializeField]
		private NPC_Objective[] chargers;

		[SerializeField]
		private DoorLightControl[] tankLights;

		[SerializeField]
		private GameObject padlockObj;

		public UnityEvent OnChargeStart;

		public UnityEvent OnFullCharge;

		private void Start()
		{
		}

		private void OnChargerKeyed(NPC_Objective charger)
		{
		}

		public void KeyRecieved(Key key)
		{
		}

		private void BlinkChargeLight()
		{
		}

		[IteratorStateMachine(typeof(_003CCoBlinkCharge_003Ed__48))]
		private IEnumerator CoBlinkCharge()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoChargeShock_003Ed__49))]
		private IEnumerator CoChargeShock()
		{
			return null;
		}

		private void ResetShockCharge()
		{
		}

		public void OnNPCEnter(TriggerRefProxy proxy)
		{
		}

		public void OnNPCExit(TriggerRefProxy proxy)
		{
		}

		private void SetShockReadiness(bool ready)
		{
		}

		public void ToggleShockField()
		{
		}

		[IteratorStateMachine(typeof(_003CCoShock_003Ed__55))]
		private IEnumerator CoShock()
		{
			return null;
		}

		[ContextMenu("ShockTest")]
		public void TestShock()
		{
		}

		public void ToggleShockPointFX()
		{
		}

		public void TargetLightning(Vector3 target)
		{
		}

		[IteratorStateMachine(typeof(_003CCoLightningFX_003Ed__59))]
		private IEnumerator CoLightningFX(Vector3 target)
		{
			return null;
		}

		public void ToggleBattery()
		{
		}

		private void SetTankCompletion()
		{
		}

		private void FillTank(int energy = 100)
		{
		}

		[ContextMenu("OPEN_THE_PORTAL")]
		public void OPEN_THE_PORTAL()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPortalPlay_003Ed__64))]
		private IEnumerator CoPortalPlay()
		{
			return null;
		}
	}
}
