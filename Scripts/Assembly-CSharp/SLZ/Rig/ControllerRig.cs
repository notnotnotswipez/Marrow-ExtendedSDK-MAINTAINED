using SLZ.Marrow.Interaction;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class ControllerRig : HeptaRig
	{
		[Header("Controller Vars")]
		public BaseController leftController;

		public BaseController rightController;

		public bool IsMenuTapDisabled;

		private static bool _isPaused;

		private bool _isPausedFinal;

		protected Vector2 _axisPrimary;

		protected Vector2 _axisSecondary;

		protected bool _primaryStick;

		protected bool _primaryStickUp;

		protected bool _primaryStickDown;

		protected bool _primaryStickTouch;

		protected bool _secondaryStick;

		protected bool _secondaryStickUp;

		protected bool _secondaryStickDown;

		protected bool _secondaryStickTouch;

		protected bool _axisPrimaryDirty;

		protected bool _primaryAButton;

		protected bool _primaryAButtonUp;

		protected bool _primaryAButtonDown;

		protected bool _secondaryAButton;

		protected bool _secondaryAButtonUp;

		protected bool _secondaryAButtonDown;

		protected float _crouch;

		protected bool _crouchInput;

		protected float _smoothTwist;

		protected BodyPose _lastBodyPose;

		public BodyPose lastBodyPose
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsPaused
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnRigEnable(bool reEnable)
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public BaseController GetController(Handedness handedness)
		{
			return null;
		}

		public override void OnUpdate()
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public float GetCrouch()
		{
			return 0f;
		}

		public bool GetCrouchInput()
		{
			return false;
		}

		public bool GetSecondaryAButtonUp()
		{
			return false;
		}

		public bool GetSecondaryAButton()
		{
			return false;
		}

		public float GetSmoothTwist()
		{
			return 0f;
		}

		public Vector2 GetPrimaryAxis()
		{
			return default(Vector2);
		}

		public bool GetPrimaryAxisDirty()
		{
			return false;
		}
	}
}
