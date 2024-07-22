using System.Collections.Generic;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[RequireComponent(typeof(Collider))]
	[Support(SupportFlags.BetaSupported, "This works, but should use Marrow primitives.")]
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Trigger")]
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

		[SerializeField]
		[Tooltip("Limit trigger to a specific Layer. Ignored by Player or Npc Only")]
		private LayerMask _layerFilter;

		private LayerMask _playerLayerMask;

		private LayerMask _npcLayerMask;

		[Tooltip("Limit trigger to player only")]
		[SerializeField]
		private bool _playerOnly;

		[SerializeField]
		[Tooltip("Limit trigger to player or NPC only")]
		private bool _playerOrNpcOnly;

		[SerializeField]
		[Tooltip("Limit trigger to a specific object collision. CONFLICTS WITH: Player Only")]
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
