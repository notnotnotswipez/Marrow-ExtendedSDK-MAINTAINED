using SLZ.Marrow.Input;
using UnityEngine;

namespace SLZ.Rig
{
	public class OpenController : BaseController
	{
		private const float grabThreshold = 0.99f;

		private const float releaseThreshold = 0.5f;

		private bool _runUpdates;

		private Vector3 _localTrackPos;

		private Quaternion _localTrackRot;

		private bool _noFingies;

		private void DrawSkeletonHand(Vector3[] positions, Quaternion[] rotations)
		{
		}

		public override GesturePose GetGesturePose(out float poseIntensity, bool forceUpdate = false)
		{
			poseIntensity = default(float);
			return default(GesturePose);
		}

		public override void OnUpdate()
		{
		}

		public override void OnVrFixedUpdate(Vector3 headPos, float deltaTime)
		{
		}

		private void CacheInputs()
		{
		}

		private void ProcessFingers()
		{
		}

		private void ProcessHandTrackedFingers(XRController controller, XRHand hand)
		{
		}

		private void ProcessNonHandTrackedFingers(XRController controller)
		{
		}

		private void SolveGrip()
		{
		}

		private void CheckMenuTap()
		{
		}

		public override void HapticAction(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}

		public override bool GetPrimaryInteractionButtonDown()
		{
			return false;
		}

		public override bool GetPrimaryInteractionButtonUp()
		{
			return false;
		}

		public override bool GetPrimaryInteractionButton()
		{
			return false;
		}

		public override float GetPrimaryInteractionButtonAxis()
		{
			return 0f;
		}

		public override bool GetSecondaryInteractionButtonDown()
		{
			return false;
		}

		public override float GetSecondaryInteractionButtonAxis()
		{
			return 0f;
		}

		public override float GetGripVelocity()
		{
			return 0f;
		}

		public override bool GetSecondaryInteractionButtonUp()
		{
			return false;
		}

		public override bool GetSecondaryInteractionButton()
		{
			return false;
		}

		public override bool GetAButtonDown()
		{
			return false;
		}

		public override bool GetAButtonUp()
		{
			return false;
		}

		public override bool GetAButton()
		{
			return false;
		}

		public override bool GetBButtonDown()
		{
			return false;
		}

		public override bool GetBButtonUp()
		{
			return false;
		}

		public override bool GetBButton()
		{
			return false;
		}

		public override Vector2 GetThumbStickAxis()
		{
			return default(Vector2);
		}

		public override bool GetThumbStickDown()
		{
			return false;
		}

		public override bool GetThumbStickUp()
		{
			return false;
		}

		public override bool GetThumbStick()
		{
			return false;
		}

		public override Vector2 GetTouchPadAxis()
		{
			return default(Vector2);
		}

		public override bool GetTouchPadDown()
		{
			return false;
		}

		public override bool GetTouchPadUp()
		{
			return false;
		}

		public override bool GetTouchPad()
		{
			return false;
		}

		public override float GetGripForce()
		{
			return 0f;
		}

		public override float GetIndexCurlAxis()
		{
			return 0f;
		}

		public override float GetMiddleCurlAxis()
		{
			return 0f;
		}

		public override float GetRingCurlAxis()
		{
			return 0f;
		}

		public override float GetPinkyCurlAxis()
		{
			return 0f;
		}

		public override float GetThumbCurlAxis()
		{
			return 0f;
		}

		public override bool HasBeenGrabbed()
		{
			return false;
		}

		public override void ClearHasBeenGrabbed()
		{
		}

		public override bool IsGrabbed()
		{
			return false;
		}

		public override bool IsReleased()
		{
			return false;
		}

		public override bool GetGrabbedState()
		{
			return false;
		}

		public override bool GetReleasedState()
		{
			return false;
		}

		public override bool GetMenuButtonDown()
		{
			return false;
		}

		public override bool GetMenuButtonUp()
		{
			return false;
		}

		public override bool GetMenuButton()
		{
			return false;
		}

		public override bool GetSecondaryMenuButtonDown()
		{
			return false;
		}

		public override bool GetSecondaryMenuButtonUp()
		{
			return false;
		}

		public override bool GetSecondaryMenuButton()
		{
			return false;
		}

		public override bool GetMenuTap()
		{
			return false;
		}

		public override bool GetAppMenuDown()
		{
			return false;
		}

		public override bool GetAppMenuUp()
		{
			return false;
		}

		public override bool GetAppMenu()
		{
			return false;
		}

		public override bool GetThumbStickTouch()
		{
			return false;
		}

		public override bool GetThumbTouch()
		{
			return false;
		}

		public override Vector3 GetRelativeVelocityInWorld()
		{
			return default(Vector3);
		}
	}
}
