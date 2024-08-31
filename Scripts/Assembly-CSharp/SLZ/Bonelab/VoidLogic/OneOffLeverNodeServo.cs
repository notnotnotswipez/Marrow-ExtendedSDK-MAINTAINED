using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic Lever Servo One-off Node")]
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	[RequireComponent(typeof(Servo))]
	public class OneOffLeverNodeServo : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
	{
		public ConfigurableJoint LeverConfigurableJoint
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Rigidbody LeverRigidBody
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

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public override void Initialize(NodeState nodeState)
		{
		}

		void IVoidLogicSensor.ReadSensors(NodeState nodeState)
		{
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		void IVoidLogicActuator.Actuate(NodeState nodeState)
		{
		}

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public OneOffLeverNodeServo()
		{
		}

		public Servo servo;

		[Tooltip("Output response curve (multiplied by input)")]
		[SerializeField]
		private AnimationCurve _curve;

		[Min(0f)]
		[SerializeField]
		[Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		private int _steps;

		[SerializeField]
		[Tooltip("Lever joint that drives the output power value")]
		private ConfigurableJoint _leverConfigurableJoint;

		[Tooltip("Interactable host i.e. for running haptics")]
		[SerializeField]
		private InteractableHost _interactableHost;

		[Header("Force")]
		[SerializeField]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[Header("Audio")]
		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		[SerializeField]
		private AudioClip clip_clickEnd;

		private bool _canHaptic;

		private bool _leverThresholdHit;

		public Transform warpOnStart;

		private bool leverCycle;

		private bool _performedInitialRead;

		private static readonly PortMetadata _portMetadata;
	}
}
