namespace SLZ.Interaction
{
	public interface IInteractionReceivable
	{
		void OnInteractableHostDrop(InteractableHost host);

		void OnInteractableHostEnter(InteractableHost host);

		void OnInteractableHostExit(InteractableHost host);

		void OnInteractableHostStay(InteractableHost host);
	}
}
