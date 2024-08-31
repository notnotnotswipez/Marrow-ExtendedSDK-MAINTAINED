using System;
using System.Collections.Generic;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic Trigger")]
	[Support(SupportFlags.Deprecated, "This has been replaced by ZoneTriggerSource.")]
	[RequireComponent(typeof(Collider))]
	[Obsolete("This has been replaced by ZoneTriggerSource.")]
	public class TriggerNode : BaseNode
	{
		protected override void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public override void Initialize(NodeState nodeState)
		{
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public TriggerNode()
		{
		}

		[Tooltip("Trigger Behavior:\nAlways => Enter and Exit\nOnce => Enter and Exit, once\nPinned => Enter (pin to \"on\" state)")]
		[SerializeField]
		private TriggerNode.TriggerBehavior _triggerBehavior;

		[Tooltip("Limit trigger to a specific Layer. Ignored by Player or Npc Only")]
		[SerializeField]
		private LayerMask _layerFilter;

		private LayerMask _playerLayerMask;

		private LayerMask _npcLayerMask;

		[Tooltip("Limit trigger to player only")]
		[SerializeField]
		private bool _playerOnly;

		[SerializeField]
		[Tooltip("Limit trigger to player or NPC only")]
		private bool _playerOrNpcOnly;

		[Tooltip("Limit trigger to a specific object collision. CONFLICTS WITH: Player Only")]
		[SerializeField]
		private GameObject _triggerObject;

		private bool _isTriggered;

		private bool _hasBeenTriggered;

		private float _multiplier;

		private readonly HashSet<Rigidbody> _playerRigidbodies;

		private static readonly PortMetadata _portMetadata;

		public enum TriggerBehavior
		{
			Always,
			Once,
			Pinned
		}
	}
}
