using System.Runtime.CompilerServices;
using SLZ.Marrow.Input;
using SLZ.Marrow.Interaction;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Rig
{
	public class BaseController : MonoBehaviour
	{
		public enum GesturePose
		{
			OpenHand = 0,
			IndexPoint = 1,
			MiddleFinger = 2,
			PeaceSign = 3,
			ThumbsUp = 4,
			ThumbsDown = 5,
			Fist = 6
		}

		public Handedness handedness;

		[HideInInspector]
		public ControllerRig contRig;

		[SerializeField]
		private Haptor _haptor;

		protected GesturePose _gesturePose;

		protected float _nextGestureUpdateTime;

		protected float _gesturePoseIntensity;

		protected bool isBelowGripThreshold;

		protected bool isGrabInputPressedFinal;

		protected bool isGrabInputReleasedFinal;

		protected bool _isGrabInputPressedState;

		protected bool _isGrabInputReleasedState;

		protected float _simGripAxisVive;

		protected float _simIndexTouch;

		protected float _simThumbAxis;

		protected float _simGripAxisHolo;

		protected float _processedIndex;

		protected float _processedMiddle;

		protected float _processedRing;

		protected float _processedPinky;

		protected float _processedThumb;

		protected float _solvedGrip;

		protected float _solvedGripVelocity;

		protected float _lastTimeGrabbed;

		protected Vector3 _localVelocity;

		protected Vector3 _lastHandHeadPos;

		protected float _primaryAxis;

		protected float _gripForce;

		protected float _menuTapTimer;

		protected Vector2 _thumbstickAxis;

		protected Vector2 _touchPadAxis;

		protected bool _primaryInteractionButton;

		protected bool _primaryInteractionButtonUp;

		protected bool _primaryInteractionButtonDown;

		protected bool _secondaryInteractionButton;

		protected bool _secondaryInteractionButtonUp;

		protected bool _secondaryInteractionButtonDown;

		protected bool _thumbstick;

		protected bool _thumbstickUp;

		protected bool _thumbstickDown;

		protected bool _thumbstickTouch;

		protected bool _touchPad;

		protected bool _touchPadUp;

		protected bool _touchPadDown;

		protected bool _touchPadTouch;

		protected bool _aButton;

		protected bool _aButtonUp;

		protected bool _aButtonDown;

		protected bool _bButton;

		protected bool _bButtonUp;

		protected bool _bButtonDown;

		protected bool _menuTap;

		protected bool _isThumbTouch;

		protected bool _appMenuUp;

		protected bool _appMenuDown;

		protected bool _appMenu;

		public XRControllerType Type
		{
			[CompilerGenerated]
			get
			{
				return default(XRControllerType);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Haptor haptor => null;

		public virtual GesturePose GetGesturePose(out float poseIntensity, bool forceUpdate = false)
		{
			poseIntensity = default(float);
			return default(GesturePose);
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnFixedUpdate(float secFromNow = 0f)
		{
		}

		public virtual void OnVrFixedUpdate(Vector3 headPos, float deltaTime)
		{
		}

		public virtual bool GetPrimaryInteractionButtonDown()
		{
			return false;
		}

		public virtual bool GetPrimaryInteractionButtonUp()
		{
			return false;
		}

		public virtual bool GetPrimaryInteractionButton()
		{
			return false;
		}

		public virtual float GetPrimaryInteractionButtonAxis()
		{
			return 0f;
		}

		public virtual bool GetSecondaryInteractionButtonDown()
		{
			return false;
		}

		public virtual float GetSecondaryInteractionButtonAxis()
		{
			return 0f;
		}

		public virtual bool GetSecondaryInteractionButtonUp()
		{
			return false;
		}

		public virtual bool GetSecondaryInteractionButton()
		{
			return false;
		}

		public virtual float GetGripForce()
		{
			return 0f;
		}

		public virtual float GetIndexCurlAxis()
		{
			return 0f;
		}

		public virtual float GetMiddleCurlAxis()
		{
			return 0f;
		}

		public virtual float GetRingCurlAxis()
		{
			return 0f;
		}

		public virtual float GetPinkyCurlAxis()
		{
			return 0f;
		}

		public virtual float GetThumbCurlAxis()
		{
			return 0f;
		}

		public virtual bool HasBeenGrabbed()
		{
			return false;
		}

		public virtual void ClearHasBeenGrabbed()
		{
		}

		public virtual float GetLastTimeGrabbed()
		{
			return 0f;
		}

		public virtual bool IsGrabbed()
		{
			return false;
		}

		public virtual bool IsReleased()
		{
			return false;
		}

		public virtual bool GetGrabbedState()
		{
			return false;
		}

		public virtual bool GetReleasedState()
		{
			return false;
		}

		public virtual bool GetSecondaryMenuButtonDown()
		{
			return false;
		}

		public virtual bool GetSecondaryMenuButtonUp()
		{
			return false;
		}

		public virtual bool GetSecondaryMenuButton()
		{
			return false;
		}

		public virtual bool GetMenuTap()
		{
			return false;
		}

		public virtual bool GetAppMenuDown()
		{
			return false;
		}

		public virtual bool GetAppMenuUp()
		{
			return false;
		}

		public virtual bool GetAppMenu()
		{
			return false;
		}

		public virtual bool GetMenuButtonDown()
		{
			return false;
		}

		public virtual bool GetMenuButtonUp()
		{
			return false;
		}

		public virtual bool GetMenuButton()
		{
			return false;
		}

		public virtual float GetGripVelocity()
		{
			return 0f;
		}

		public virtual void HapticAction(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}

		public virtual void Haptic(float microFloat)
		{
		}

		public virtual bool GetAButtonDown()
		{
			return false;
		}

		public virtual bool GetAButtonUp()
		{
			return false;
		}

		public virtual bool GetAButton()
		{
			return false;
		}

		public virtual bool GetBButtonDown()
		{
			return false;
		}

		public virtual bool GetBButtonUp()
		{
			return false;
		}

		public virtual bool GetBButton()
		{
			return false;
		}

		public virtual Vector2 GetThumbStickAxis()
		{
			return default(Vector2);
		}

		public virtual bool GetThumbStickDown()
		{
			return false;
		}

		public virtual bool GetThumbStickUp()
		{
			return false;
		}

		public virtual bool GetThumbStick()
		{
			return false;
		}

		public virtual bool GetThumbStickTouch()
		{
			return false;
		}

		public virtual Vector2 GetTouchPadAxis()
		{
			return default(Vector2);
		}

		public virtual bool GetTouchPadDown()
		{
			return false;
		}

		public virtual bool GetTouchPadUp()
		{
			return false;
		}

		public virtual bool GetTouchPad()
		{
			return false;
		}

		public virtual bool GetTouchPadTouch()
		{
			return false;
		}

		public virtual bool GetThumbTouch()
		{
			return false;
		}

		public virtual Vector3 GetRelativeVelocityInWorld()
		{
			return default(Vector3);
		}

		public void StampController(BaseController fromController)
		{
		}
	}
}
