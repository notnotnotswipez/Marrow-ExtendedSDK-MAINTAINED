using SLZ.Marrow;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	[AddComponentMenu("Event/Interactable Input Module")]
	public class InteractableInputModule : VRStandaloneInputModule
	{
		private VRInput m_Input;

		protected override void Awake()
		{
		}

		private bool GetInput(Hand hand, out int index)
		{
			index = default(int);
			return false;
		}

		protected PointerEventData ModifiedGetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			pressed = default(bool);
			released = default(bool);
			return null;
		}

		public void SetTrackedInput(Hand hand)
		{
		}

		public void RemoveTrackedInput(Hand hand)
		{
		}

		protected virtual void ModifiedProcessMove(PointerEventData pointerEvent)
		{
		}

		protected void ModifiedHandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}
	}
}
