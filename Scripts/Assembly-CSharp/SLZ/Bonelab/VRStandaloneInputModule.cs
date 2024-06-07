using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	[AddComponentMenu("Event/Standalone Input Module")]
	public class VRStandaloneInputModule : VRInputModule
	{
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			Mouse = 0,
			Buttons = 1
		}

		private float m_NextAction;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		public static bool hasHitUIElement;

		[SerializeField]
		private string m_HorizontalAxis;

		[SerializeField]
		private string m_VerticalAxis;

		[SerializeField]
		private string m_SubmitButton;

		[SerializeField]
		private string m_CancelButton;

		[SerializeField]
		private float m_InputActionsPerSecond;

		[SerializeField]
		private bool m_AllowActivationOnMobileDevice;

		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public InputMode inputMode => default(InputMode);

		public bool allowActivationOnMobileDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float inputActionsPerSecond
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected VRStandaloneInputModule()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		public override void Process()
		{
		}

		private bool SendSubmitEventToSelectedObject()
		{
			return false;
		}

		private bool AllowMoveEventProcessing(float time)
		{
			return false;
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		private bool SendMoveEventToSelectedObject()
		{
			return false;
		}

		private void ProcessMouseEvent()
		{
		}

		private static bool UseMouse(bool pressed, bool released, PointerEventData pointerData)
		{
			return false;
		}

		private bool SendUpdateEventToSelectedObject()
		{
			return false;
		}

		private void ProcessMousePress(MouseButtonEventData data)
		{
		}
	}
}
