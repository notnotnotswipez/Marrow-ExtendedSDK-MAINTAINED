using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InventoryHand : OverlapTrigger
	{
		private readonly HashSet<InventoryHandReceiver> _receivers;

		[SerializeField]
		private Hand _hand;

		private bool _hasBeenLockedByMe;

		private InventoryHandReceiver _activeReceiver;

		private bool _isDropping;

		private bool _isGrabbing;

		private bool _isGrabInput;

		private HandReciever _lastDetachedReceiver;

		private bool _isDropInput;

		private float _startSmearTime;

		private float _smearDuration;

		public bool HasAttachedHost => false;

		public IGrippable Host => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		private void OnReceiverAttached(HandReciever receiver)
		{
		}

		private void OnReceiverDetached(HandReciever receiver)
		{
		}

		public override void OnOverlapEnter(GameObject other)
		{
		}

		public override void OnOverlapExit(GameObject other)
		{
		}

		public void IgnoreUnlock()
		{
		}

		private void MarrowUpdate()
		{
		}
	}
}
