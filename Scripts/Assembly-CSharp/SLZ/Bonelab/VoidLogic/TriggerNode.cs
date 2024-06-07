using System.Collections.Generic;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Trigger")]
	[Support(SupportFlags.BetaSupported, "This works, but should use Marrow primitives.")]
	[RequireComponent(typeof(Collider))]
	public class TriggerNode : BaseNode
	{
		public enum TriggerBehavior
		{
			Always = 0,
			Once = 1,
			Pinned = 2
		}

		[Tooltip("Trigger Behavior:\nAlways => Enter and Exit\nOnce => Enter and Exit, once\nPinned => Enter (pin to \"on\" state)")]
		[SerializeField]
		private TriggerBehavior _triggerBehavior;

		[Tooltip("Limit trigger to a specific Layer. Ignored by Player or Npc Only")]
		[SerializeField]
		private LayerMask _layerFilter;

		private LayerMask _playerLayerMask;

		private LayerMask _npcLayerMask;

		[SerializeField]
		[Tooltip("Limit trigger to player only")]
		private bool _playerOnly;

		[Tooltip("Limit trigger to player or NPC only")]
		[SerializeField]
		private bool _playerOrNpcOnly;

		[Tooltip("Limit trigger to a specific object collision. CONFLICTS WITH: Player Only")]
		[SerializeField]
		private GameObject _triggerObject;

		private bool _isTriggered;

		private bool _hasBeenTriggered;

		private float _multiplier;

		private readonly HashSet<Rigidbody> _playerRigidbodies;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		protected override void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
