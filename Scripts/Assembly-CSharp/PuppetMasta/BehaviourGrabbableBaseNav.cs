using SLZ.Marrow;
using SLZ.Marrow.PuppetMasta;

namespace PuppetMasta
{
	public abstract class BehaviourGrabbableBaseNav : BehaviourBaseNav
	{
		public InteractableHostManager hostManager;

		public int handCount;

		protected override void OnInitiate()
		{
		}

		protected virtual void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		protected virtual void OnHandDetached(InteractableHost host, Hand hand)
		{
		}
	}
}
