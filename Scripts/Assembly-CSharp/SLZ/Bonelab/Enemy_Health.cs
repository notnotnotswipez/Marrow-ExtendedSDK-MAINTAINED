using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Enemy_Health : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRegenerate_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Enemy_Health _003C_003E4__this;

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
			public _003CRegenerate_003Ed__50(int _003C_003E1__state)
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

		[Space(2f)]
		[Header("IMPACT")]
		[Tooltip("Can be damaged by physical impacts")]
		public bool damageFromImpact;

		[Tooltip("Modifier multiplier to collision")]
		public float mod_Impact;

		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thr_Impact;

		[Tooltip("Can this use a mask to ignore damage")]
		public bool useMask;

		[Tooltip("Layer to Minimal Hit")]
		public LayerMask msk_Impact;

		[Tooltip("Amount of Minimal Mod")]
		public float mod_Minimal;

		[Space(10f)]
		[Header("ATTACKED")]
		[Tooltip("Can be damaged by attacks")]
		public bool damageFromAttack;

		[Tooltip("Modifier multiplier to attack damage")]
		public float mod_Attack;

		[Tooltip("Can this use an attackType to adjust damage")]
		public bool useType;

		[Tooltip("Attack type high damage")]
		public AttackType mod_Type;

		[Tooltip("Modifier multiplier to attack type")]
		public float mod_TypeDamage;

		[Space(10f)]
		[Header("CRITICAL HIT")]
		[Tooltip("Colliders for critical hits")]
		public Collider[] col_crit;

		[Tooltip("Critical hit modifier percent")]
		public float mod_crit;

		[Tooltip("FX for crit hit")]
		public GameObject fx_crit;

		[Tooltip("Invulnerable, probably temp")]
		[Space(10f)]
		[Header("HEALTH")]
		public bool invulnerable;

		[Tooltip("Enemy maximum health")]
		public float max_Health;

		[SerializeField]
		public float cur_Health;

		[Tooltip("Required hits to kill, 1 = default")]
		public int req_hit_count;

		[HideInInspector]
		public int hits;

		[HideInInspector]
		public bool bloodied;

		[Tooltip("0-1 as percent for when bloodied effects 0 = no effect")]
		public float per_Bloodied;

		[Tooltip("Is Death certain when bloodied?")]
		public float imm_death_t;

		[Tooltip("FX for bloodied hits")]
		public GameObject fx_bloodied;

		[Header("HEALTH REGEN")]
		[Space(10f)]
		[Tooltip("Health to regen per frequency")]
		public float amt_Regen;

		[Tooltip("Time until regen starts after hit")]
		public float wait_Regen_t;

		[Tooltip("Frequency of regen in seconds")]
		public float freq_Regen_t;

		[Tooltip("Currently regening")]
		public bool regenerating;

		[Tooltip("FX for regenerating")]
		public GameObject fx_regen;

		[Tooltip("Threshold of damage to cause a reaction")]
		[Space(5f)]
		[Header("REACTION")]
		public float thr_React;

		private bool reacting;

		[Space(5f)]
		[Header("DEATH / SPAWN")]
		public bool DestroyOnDeath;

		[Tooltip("Spawn hero props?")]
		public bool spawnHeroProps;

		[HideInInspector]
		public bool alive;

		public bool Pooled;

		public Transform[] spawn_points;

		public bool autoRespawn;

		[Tooltip("FX for death")]
		public GameObject fx_death;

		[Space(10f)]
		[Header("BODY STRUCTURE")]
		private Rigidbody rb_enemyBody;

		private EnemyTurret _enemyAiRig;

		private Vector3 vel;

		private Vector3 ang_vel;

		[Tooltip("Spawnable hero props")]
		public GameObject[] prop_Hero;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void OnReceivedCollison(Collision collison, float relVelocitySqr, EnemyCollisonRelay.BodyPart part, bool isStay = false)
		{
		}

		public void OnReceivedDamage(Attack attack, EnemyDamageReceiver.BodyPart part)
		{
		}

		public void ReceiveHeal(float health)
		{
		}

		public void TAKEDAMAGE(float damage, bool crit = false)
		{
		}

		public void StartRegen()
		{
		}

		[IteratorStateMachine(typeof(_003CRegenerate_003Ed__50))]
		private IEnumerator Regenerate()
		{
			return null;
		}

		public void DIE()
		{
		}

		public void SPAWNSTART()
		{
		}

		private void EffectsCritHit()
		{
		}

		private void EffectsRegen(bool regeneration = true)
		{
		}

		private void EffectsBloodied()
		{
		}

		public void EffectsDeath()
		{
		}

		public void Reaction(float damage)
		{
		}

		public void SpawnProps()
		{
		}

		public void STARTDATA()
		{
		}
	}
}
