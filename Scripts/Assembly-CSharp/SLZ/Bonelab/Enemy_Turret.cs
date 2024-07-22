using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Enemy_Turret : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckHealth_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Enemy_Turret _003C_003E4__this;

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
			public _003CCheckHealth_003Ed__73(int _003C_003E1__state)
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

		[Header("SETTINGS")]
		public bool packed;

		public float alert_t;

		public float dodge_t;

		public bool canFlip;

		public bool flipWhileFolded;

		public float force_jump;

		[HideInInspector]
		public bool patrolling;

		[HideInInspector]
		public bool alert;

		[HideInInspector]
		public bool tipped;

		[HideInInspector]
		public bool dead;

		[Range(0f, 1f)]
		[Space(10f)]
		[Header("HEALTH")]
		public float mod_targetForce;

		public float gun_targetForce;

		public float body_targetForce;

		private float cur_Health;

		private float max_Health;

		public float health_check_t;

		public GameObject fx_Death;

		[Space(10f)]
		[Header("BODY REFERENCES")]
		public GameObject gun;

		public GameObject body;

		public ConfigurableJoint jnt_leg_l;

		public ConfigurableJoint jnt_leg_r;

		public ConfigurableJoint jnt_legHinge_l;

		public ConfigurableJoint jnt_legHinge_r;

		private ConfigurableJoint jnt_gun;

		private ConfigurableJoint jnt_body;

		public ConfigurableJoint jnt_spine_slide;

		public ConfigurableJoint jnt_leg_rear;

		private Vector3 jnt_leg_rotTarget;

		private Quaternion rot_body_initialize;

		private Quaternion offset_body_JointSpace;

		private Quaternion rot_gun_initialize;

		private Quaternion offset_gun_JointSpace;

		private bool jointSpaceSet;

		[Space(10f)]
		[Header("CENTER OF MASS")]
		public Vector3 com_packed;

		public Vector3 com_unpacked;

		public Vector3 com_unFlip;

		private RigidbodySettings centerSetter;

		private Transform centerOfMass;

		private Rigidbody rb_this;

		private bool flipMass;

		public float stability;

		public float stability_speed;

		public float MaxFlippedTime;

		private float m_LastTimeUp;

		private bool immediateFlip;

		[Space(10f)]
		[Header("TARGET ACQUISITION")]
		public Collider coneOfVision;

		public Transform target;

		[HideInInspector]
		public bool aggro;

		public Transform dummyTarget;

		public float patrol_speed;

		public float patrol_spread;

		public Transform laserSight;

		private List<Rigidbody> possibleTargets;

		private List<Rigidbody> visibleTargets;

		private float closestDist;

		public float max_sightRange;

		private bool can_Target;

		[Space(10f)]
		[Header("AUDIO")]
		public AudioClip[] clips_idle;

		public AudioClip[] clips_alert;

		public AudioClip[] clips_patrol;

		public AudioClip[] clips_unPack;

		public AudioClip[] clips_pack;

		public AudioClip[] clips_speak;

		public AudioClip[] clips_death;

		private AudioSource src_Audio;

		private void Start()
		{
		}

		private void SetJointSpace()
		{
		}

		private void IgnoreCollisions()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void STABILIZE()
		{
		}

		private void LOOKATBODY()
		{
		}

		private void LOOKATGUN()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckHealth_003Ed__73))]
		private IEnumerator CheckHealth()
		{
			return null;
		}

		public void TargetList(Rigidbody possible)
		{
		}

		public void DEATH()
		{
		}

		public void Pack()
		{
		}

		public void UnPack()
		{
		}

		public void Patrol()
		{
		}

		private void StartState(bool packed)
		{
		}

		public void DumpPossibleList()
		{
		}

		public void DumpVisibleList()
		{
		}

		private void TARGETER()
		{
		}

		private void CheckTargetVisibility()
		{
		}

		private void PickTarget(RaycastHit hit)
		{
		}

		private void HealthToSprings()
		{
		}

		private void PackSprings()
		{
		}

		private void Alert(bool woke = true)
		{
		}

		private void PlayAudio(AudioClip clip, float volume = 1f)
		{
		}

		private void SpringUp()
		{
		}

		private void SpringDip(bool down = false)
		{
		}

		private void SetJoint_SpineSlide()
		{
		}

		private void SetJoint_RearLeg()
		{
		}

		private void SetJoint_HingeLegs()
		{
		}

		private void HingeDelay()
		{
		}

		private void SetMassCenter(Vector3 centerPoint)
		{
		}
	}
}
