using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(InteractableHost))]
	public class InteractableEvents : MonoBehaviour
	{
		public UnityEvent OnGrab;

		public UnityEvent OnRelease;

		[Tooltip("Only trigger the event when both hands let go of the object")]
		public bool CompleteRelease;

		private InteractableHost host;

		private void Awake()
		{
		}

		public void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		public void OnDetachedHand(InteractableHost host, Hand hand)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
