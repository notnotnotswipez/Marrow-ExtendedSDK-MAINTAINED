using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractionReciever : MonoBehaviour, IInteractionReceivable
	{
		public enum GrabbedOptions
		{
			EITHER = 0,
			GRABBED = 1,
			FREE = 2
		}

		[Flags]
		public enum Options
		{
			ONE_AT_A_TIME = 2
		}

		private delegate void EnterDelegate(InteractableHost host);

		private delegate void ExitDelegate(InteractableHost host);

		private delegate void StayDelegate(InteractableHost host);

		private delegate void DropDelegate(InteractableHost host);

		private class HoveringCounts
		{
			public int contacts;

			public int stays;

			public int drops;

			public bool attached;

			public HoveringCounts(int c, int s, int d, bool a)
			{
			}
		}

		public GrabbedOptions grabbedOptions;

		[EnumFlags]
		public Options options;

		private HashSet<InteractableHost> _hoveredHostSet;

		private Dictionary<InteractableHost, HoveringCounts> _hoveringCounts;

		private List<InteractableHost> _hoveredHosts;

		private EnterDelegate _enterDelegate;

		private ExitDelegate _exitDelegate;

		private StayDelegate _stayDelegate;

		private DropDelegate _dropDelegate;

		public bool IsOptionsSet(Options flags)
		{
			return false;
		}

		public bool IsOptionsNotSet(Options flags)
		{
			return false;
		}

		public Options SetOptions(Options flags)
		{
			return default(Options);
		}

		public Options ClearOptions(Options flags)
		{
			return default(Options);
		}

		protected virtual void Awake()
		{
		}

		protected void ClearHost(InteractableHost host)
		{
		}

		public virtual void OnInteractableHostDrop(InteractableHost host)
		{
		}

		public virtual void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public virtual void OnInteractableHostExit(InteractableHost host)
		{
		}

		public virtual void OnInteractableHostStay(InteractableHost host)
		{
		}

		private bool AddHoveredHost(InteractableHost host)
		{
			return false;
		}

		private bool RemoveHoveredHost(InteractableHost host)
		{
			return false;
		}

		private bool IsHoveredHost(InteractableHost host)
		{
			return false;
		}

		private bool CanCallDelegate(InteractableHost host)
		{
			return false;
		}

		private bool CanCallDelegateDrop(InteractableHost host)
		{
			return false;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
