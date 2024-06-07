using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableHostManager : MonoBehaviour
	{
		public InteractableHost[] hosts;

		public Action<InteractableHost, Hand> onHandAttached;

		public Action<InteractableHost, Hand> onHandDetached;

		[HideInInspector]
		public List<InteractableHost> grabbedHosts;

		public float TotalMass
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Reset()
		{
		}

		private void Start()
		{
		}

		public void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		public void OnDetachedHand(InteractableHost host, Hand hand)
		{
		}

		public void ForceDetachAll()
		{
		}

		public void EnableCollisonAll()
		{
		}

		public void DisableCollisionAll()
		{
		}

		public void EnableInteractionAll()
		{
		}

		public void DisableInteractionAll()
		{
		}
	}
}
