using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Interaction
{
	public class HandInteractionReceiver : HandReciever
	{
		private static List<HandInteractionReceiver> _interactionReceivers;

		private HashSet<Hand> _hoveredHands;

		private Dictionary<Hand, IGrippable> _hoveredHosts;

		private List<Hand> _exitHands;

		private List<Hand> _stayHands;

		private bool _isActive;

		protected override void Awake()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		protected virtual bool IsValid(IGrippable host)
		{
			return false;
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		protected virtual void OnInteractableHostDrop(IGrippable host)
		{
		}

		protected virtual void OnInteractableHostEnter(IGrippable host)
		{
		}

		protected virtual void OnInteractableHostExit(IGrippable host)
		{
		}

		protected virtual void OnInteractableHostStay(IGrippable host)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnHandEnter(Hand hand)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnHandExit(Hand hand)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		protected virtual void Update()
		{
		}
	}
}
