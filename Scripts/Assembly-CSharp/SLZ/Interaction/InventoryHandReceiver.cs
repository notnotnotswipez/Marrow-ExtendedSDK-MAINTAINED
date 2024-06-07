using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class InventoryHandReceiver : MonoBehaviour
	{
		public UnityEvent OnHover;

		public UnityEvent OnHoverBegin;

		public UnityEvent OnHoverEnd;

		public UnityEvent OnDrop;

		public UnityEvent OnGrab;

		public virtual void OnHandDrop(IGrippable host)
		{
		}

		public virtual void OnHandGrab(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnHandHover(Hand hand)
		{
		}

		public virtual float Validate(Hand hand)
		{
			return 0f;
		}
	}
}
