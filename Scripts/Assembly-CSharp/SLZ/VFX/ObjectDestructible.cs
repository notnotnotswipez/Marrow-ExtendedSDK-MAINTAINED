using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.VFX
{
	public class ObjectDestructible : SpawnEvents, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ObjectDestructible> _cache;

		[SerializeField]
		private Rigidbody _rb;

		private LootTableData _defaultLootTable;

		public LootTableData lootTable;

		public DestructableLootSpawnEvent OnLootSpawn;

		public Transform spawnTarget;

		public float minVelocityDeltaSqr;

		public bool damageFromImpact;

		public SpawnFragmentArray[] spawnFragments;

		public GameObject[] CustomFragmentObjects;

		[Header("HEALTH")]
		[Tooltip("Prop's maximum health")]
		[Space(10f)]
		public float maxHealth;

		[Tooltip("Required hits to break, 1 = default")]
		public int reqHitCount;

		[Tooltip("0-1 as percent for when bloodied effects 0 = no effect")]
		[Range(0f, 1f)]
		public float perBloodied;

		public float explosiveForceOnDestruct;

		[Header("ATTACKED")]
		[Space(10f)]
		[Tooltip("Can be damaged by attacks")]
		public bool damageFromAttack;

		[Tooltip("Modifier multiplier to attack damage")]
		public float attackMod;

		[Tooltip("Attack type high damage")]
		[EnumFlags]
		public AttackType attackType;

		[Tooltip("Modifier multiplier to attack type")]
		public float modTypeDamage;

		[Space(10f)]
		[Header("CRITICAL HIT")]
		[Tooltip("Colliders for critical hits")]
		public Collider[] colCrit;

		[Tooltip("Critical hit modifier percent")]
		public float modCrit;

		[Tooltip("Modifier multiplier to collision")]
		public float modImpact;

		[FormerlySerializedAs("thrNewtons")]
		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thrImpact;

		public float feetDamageMult;

		[SerializeField]
		private ImpactSFX _impactSfx;

		private bool _isDead;

		private int _hits;

		private int _feetLayer;

		private bool _bloodied;

		private float _health;

		private float _thrImpCache;

		private List<int> _fragmentIndexBuffer;

		private int[] _randomFragmentIndices;

		public Action<ObjectDestructible> OnDestruction;

		public UnityEvent OnDestruct;

		[Space(10f)]
		[Header("DEPENDENCIES")]
		[SerializeField]
		private Spawnable blasterDustSpawnable;

		[SerializeField]
		private Vector3 blasterScale;

		[Tooltip("not being used any more, will depricate")]
		[SerializeField]
		private Vector3 BlasterPosition;

		public Color BlasterTint;

		[SerializeField]
		private Spawnable impactSmokerSpawnable;

		[SerializeField]
		private Spawnable breakEffectSpawnable;

		public static ComponentCache<ObjectDestructible> Cache => null;

		public static event Action<ObjectDestructible> OnStatDestruction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		[ContextMenu("Fix References")]
		public void GetRigidBody()
		{
		}

		protected override void Reset()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnSignificantCollision(Collision c, float impactionVelocity)
		{
		}

		public void DestroyNoDebris()
		{
		}

		public void SendDamage(float damage)
		{
		}

		private void TakeDamage(Vector3 normal, float damage, bool crit = false, AttackType attackType = AttackType.None)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
