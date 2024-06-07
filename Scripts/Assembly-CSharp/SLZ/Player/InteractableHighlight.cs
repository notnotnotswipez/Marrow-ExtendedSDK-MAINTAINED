using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Player
{
	public class InteractableHighlight : MonoBehaviour
	{
		[Tooltip("Clone near settings to far settings")]
		[SerializeField]
		public bool CloneSettings;

		[SerializeField]
		private NearEvents nearEvents;

		[SerializeField]
		private FarEvents farEvents;

		private int hoveredCount;

		private int farHoveredCount;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void OnHandHoverBegin(Hand hand)
		{
		}

		public void OnHandHoverEnd(Hand hand)
		{
		}

		public void OnHandHoverUpdate(Hand hand)
		{
		}

		public void OnFarHandHoverBegin(Hand hand)
		{
		}

		public void OnFarHandHoverEnd(Hand hand)
		{
		}

		public void OnFarHandHoverUpdate(Hand hand)
		{
		}
	}
}
