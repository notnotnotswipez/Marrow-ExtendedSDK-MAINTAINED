using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.VoidLogic;
using SLZ.Player;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Sinks/VoidLogic Damage Volume")]
	[Support(SupportFlags.AlphaSupported, "This works, but should use Marrow primitives.")]
	public class DamageVolume : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		[Header("Damage")]
		[Range(0.25f, 10f)]
		[SerializeField]
		private float _tickFrequency;

		[Tooltip("Base damage - This can get modified by Velocity or Distance")]
		[SerializeField]
		private float _damage;

		[Tooltip("Damage Type for modfying receiver behavior")]
		[SerializeField]
		private AttackType _damageType;

		[Header("Source / Range")]
		[Tooltip("Determines attack origin location")]
		[SerializeField]
		private Transform _damageSourceTransform;

		[Tooltip("Setting 0 will make damage always be at an effective distance. NOTE: This should likely be greater than the trigger volume")]
		[SerializeField]
		private float _effectiveDistance;

		[SerializeField]
		private float _mapLow;

		[SerializeField]
		private float _mapHigh;

		[Header("Velocity Damage")]
		[Tooltip("Damage modifier for Velocity")]
		public bool staticVelocityDamage;

		public bool invertVelocity;

		[Tooltip("You may want a train or fast moving object to apply damage")]
		public Rigidbody associatedRb;

		public float velocityMinimum;

		public float velocityMaximum;

		[Header("Distance Settings")]
		public bool scaleDamageWithDistance;

		public float distanceMinimum;

		public float distanceMaximum;

		private Dictionary<GameObject, Rigidbody> _gameObjectToRigidbodyMap;

		private Dictionary<Rigidbody, int> _rigidbodyRefcounts;

		private Dictionary<GameObject, MuscleCollisionBroadcaster> _rootToTriggerRefProxy;

		private List<PlayerDamageReceiver> _playerDamageRecievers;

		private List<ObjectDestructible> _objectDamageRecievers;

		private float _damageScale;

		private float _lastTickTime;

		private List<Rigidbody> _rigidbodiesToRemove;

		private static readonly PortMetadata _portMetadata;

		public PortMetadata PortMetadata { get; }

		public VoidLogicSubgraph Subgraph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private int _AffectedProxiesCount => 0;

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private bool OnFirstRigidbodyAdded(Rigidbody rb)
		{
			return false;
		}

		private bool AddDamageReceiverInformation(Rigidbody rb)
		{
			return false;
		}

		private void OnLastRigidbodyRemoved(Rigidbody rb, int removedCount)
		{
		}

		private bool RemoveDamageReceiverInformation(Rigidbody rb)
		{
			return false;
		}

		private void OnDespawn(GameObject go)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void ProcessDamage(Rigidbody rb, float mult)
		{
		}

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}
	}
}
