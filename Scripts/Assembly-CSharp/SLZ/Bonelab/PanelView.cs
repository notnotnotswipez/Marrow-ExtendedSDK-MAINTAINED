using UnityEngine;

namespace SLZ.Bonelab
{
	public class PanelView : MonoBehaviour
	{
		public PopUpMenuView popUpMenu;

		protected bool m_isActive;

		private bool m_IsActiveThisFrame;

		private VRStandaloneInputModule _module;

		public bool IsActive => false;

		private VRStandaloneInputModule module => null;

		public virtual void CloseMenu()
		{
		}

		public virtual void Activate()
		{
		}

		public virtual void Deactivate()
		{
		}

		public virtual bool Trigger()
		{
			return false;
		}

		public void UpdateCursor(Vector3 origin, Vector3 forward, bool isPressed)
		{
		}

		public void Clear()
		{
		}
	}
}
