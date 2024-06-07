using RootMotion.FinalIK;
using SLZ.Bonelab.Obsolete;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RunOffDoorControl : MonoBehaviour
	{
		[SerializeField]
		private LimbIK _limbIkRightArm;

		[SerializeField]
		private LookAtIK _lookAtIk;

		public float rightArmPositionWeight;

		public float lookAtWeight;

		public bool pressButton;

		public DisableDelay disableDelay;

		public GameObject brett;

		public Rigidbody gun;

		public float timeDelayFromButton;

		public Vector3 gunVelocity;

		public Vector3 gunAngVelocity;

		public GarageDoor_Phys_Powerable garageDoor;

		private bool _buttonPressedOneTime;

		private bool _gunPushedOneTime;

		private float _timer;

		private void Update()
		{
		}
	}
}
