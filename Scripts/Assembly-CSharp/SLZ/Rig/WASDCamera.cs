using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Rig
{
	public class WASDCamera : MonoBehaviour
	{
		[Header("Framing")]
		public Camera Camera;

		public Transform c1Vert;

		public Transform t1Vert;

		public Transform sacrum;

		public Transform fpsFollowPoint;

		public Transform tpsFollowPoint;

		public Vector2 FollowTransformFraming;

		public float FollowingSharpness;

		public float centerOfMassMult;

		[Header("Distance")]
		public float DefaultDistance;

		public float MinDistance;

		public float MaxDistance;

		public float DistanceMovementSpeed;

		public float DistanceMovementSharpness;

		[Header("Rotation")]
		public float MouseSensitivity;

		public bool InvertX;

		public bool InvertY;

		[Range(-90f, 90f)]
		public float DefaultVerticalAngle;

		[Range(-120f, 120f)]
		public float MinVerticalAngle;

		[Range(-120f, 120f)]
		public float MaxVerticalAngle;

		public float RotationSpeed;

		public float RotationSharpness;

		[Header("Crouch")]
		public float crouchDefault;

		public float crouchMin;

		public float crouchMax;

		public float crouchMovementSpeed;

		public float crouchMovementSharpness;

		[Header("Obstruction")]
		public float ObstructionCheckRadius;

		public LayerMask ObstructionLayers;

		public float ObstructionSharpness;

		private Transform _followTransform;

		private Vector3 _lookInputVector;

		private Vector3 _rotationInput;

		private bool _distanceIsObstructed;

		private float _zoomInput;

		private float _crouchInput;

		private float _currentCrouch;

		private float _currentDistance;

		private float _targetVerticalAngle;

		private RaycastHit _obstructionHit;

		private int _obstructionCount;

		private RaycastHit[] _obstructions;

		private float _obstructionTime;

		private Vector3 _currentFollowPosition;

		private const int MaxObstructions = 32;

		public Transform Transform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 PlanarDirection
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform FollowTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Collider[] IgnoredColliders
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float TargetDistance
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float TargetCrouch
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetFollowTransform(Transform followTransform)
		{
		}

		public void SetInputs(float zoomInput, float crouchInput, Vector3 rotationInput)
		{
		}

		private void Update()
		{
		}

		public void WasdFixedUpdate(SLZ.Marrow.Rig rig)
		{
		}
	}
}
