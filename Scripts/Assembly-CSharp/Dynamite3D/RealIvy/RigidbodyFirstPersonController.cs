using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		public class MovementSettings
		{
			public float ForwardSpeed;

			public float BackwardSpeed;

			public float StrafeSpeed;

			public float RunMultiplier;

			public KeyCode RunKey;

			public float JumpForce;

			public AnimationCurve SlopeCurveModifier;

			[HideInInspector]
			public float CurrentTargetSpeed;

			private bool m_Running;

			public bool Running => false;

			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}
		}

		[Serializable]
		public class AdvancedSettings
		{
			public float groundCheckDistance;

			public float stickToGroundHelperDistance;

			public float slowDownRate;

			public bool airControl;

			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;
		}

		public Camera cam;

		public MovementSettings movementSettings;

		public MouseLook mouseLook;

		public AdvancedSettings advancedSettings;

		private Rigidbody m_RigidBody;

		private CapsuleCollider m_Capsule;

		private float m_YRotation;

		private Vector3 m_GroundContactNormal;

		private bool m_Jump;

		private bool m_PreviouslyGrounded;

		private bool m_Jumping;

		private bool m_IsGrounded;

		public Vector3 Velocity => default(Vector3);

		public bool Grounded => false;

		public bool Jumping => false;

		public bool Running => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private float SlopeMultiplier()
		{
			return 0f;
		}

		private void StickToGroundHelper()
		{
		}

		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		private void RotateView()
		{
		}

		private void GroundCheck()
		{
		}
	}
}
