using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.MLAgents
{
	[Obsolete("Uses obsolete zone components")]
	public class BoidGun : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChargeShot_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoidGun _003C_003E4__this;

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
			public _003CChargeShot_003Ed__39(int _003C_003E1__state)
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

		[Header("Gun Specific Section")]
		[Tooltip("Total number of boids that can be out in the scene and amount of ammo")]
		public int maxMagSize;

		private int currentMagSize;

		[Tooltip("Rate at which boids will do the spin attack (boidBehaviour)")]
		public float attackProb;

		[Tooltip("Hand Grip")]
		public Grip triggerGrip;

		[Tooltip("Min amount of time it takes to summon a boid")]
		public float minChargeTime;

		[Tooltip("Max amount of time it takes to summon a boid")]
		public float maxChargeTime;

		[Tooltip("Max Amount of Force that will be applied to boid when shot")]
		public float maxLaunchForce;

		private float currentChargeTime;

		private bool charging;

		public Spawnable boid;

		[Tooltip("Where Spawn VFX and Boid will appear while charging/launching")]
		public GameObject spawnPointObject;

		[Header("Gun Specific Section")]
		public float bulletAliveTime;

		public Rigidbody _rb;

		[Header("FX Section")]
		[Tooltip("VFX that spawn where the boid will appear")]
		public Spawnable chargingVFX;

		[Tooltip("VFX that spawn where the boid will appear after boids been spawned")]
		public Spawnable blastVFX;

		[Tooltip("VFX that spawn where the boid will appear after boids been spawned")]
		public Spawnable despawnVFX;

		[Tooltip("Sound affect for shooting the boid")]
		public GunSFX launchSFX;

		[Tooltip("Sound affect for indicating an empty mag")]
		public GunSFX emptySFX;

		[Tooltip("Sound affect for when charge is initialized")]
		public GunSFX triggerSFX;

		[Tooltip("Sound affect for charging the gun")]
		public GunSFX chargingSFX;

		[Tooltip("Sound affect for powering up gun")]
		public GunSFX powerUpSFX;

		[Tooltip("Sound affect for powering down gun")]
		public GunSFX powerDownSFX;

		[Header("Inference Section")]
		[Tooltip("The model manager that this spawner is associated with")]
		public BarracudaModelManagerMono bmm;

		[Tooltip("Scriptable object that holds model manager/spawner variable and model references")]
		public ModelManagerConfig bmmConfig;

		[Tooltip("The boids that have been spawned and are in the scene")]
		public List<BehaviourBoidAgent_SlicedInference> dispatchedBoidList;

		[Tooltip("Whether to initialize bmm on Start()")]
		public bool bmmInitOnStart;

		private int sliceSizeMin;

		private int sliceSizeMax;

		private bool bmmActive;

		private BehaviourBoidAgent_SlicedInference temp_agent;

		private BoidBullet temp_bullet;

		private GameObject blast;

		private GameObject charge;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CChargeShot_003Ed__39))]
		private IEnumerator ChargeShot()
		{
			return null;
		}

		private void Fire()
		{
		}

		private void AgentInitialization(GameObject go)
		{
		}

		private void HandleBoidLaunch()
		{
		}

		public void BoidDespawned(BehaviourBoidAgent_SlicedInference boid)
		{
		}

		private void BMMSetup()
		{
		}

		public void CommandDeactivate()
		{
		}

		private void OnDestroy()
		{
		}

		public void WarmStartModelManager()
		{
		}

		public void StartBMM()
		{
		}
	}
}
