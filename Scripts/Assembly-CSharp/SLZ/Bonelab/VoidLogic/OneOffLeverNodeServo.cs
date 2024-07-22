using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Lever Servo One-off Node")]
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	[RequireComponent(typeof(Servo))]
	public class OneOffLeverNodeServo : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
	{
		public Servo servo;

		[Tooltip("Output response curve (multiplied by input)")]
		[SerializeField]
		private AnimationCurve _curve;

		[Min(0f)]
		[Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		[SerializeField]
		private int _steps;

		[Tooltip("Lever joint that drives the output power value")]
		[SerializeField]
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

		[SerializeField]
		[Header("Audio")]
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

		public override PortMetadata PortMetadata => default(PortMetadata);

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSensor_002EReadSensors(ref NodeState nodeState)
		{
		}

		public override void Calculate(ref NodeState nodeState)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicActuator_002EActuate(ref NodeState nodeState)
		{
		}

        public void ReadSensors(ref NodeState nodeState)
        {
            throw new System.NotImplementedException();
        }

        public void Actuate(ref NodeState nodeState)
        {
            throw new System.NotImplementedException();
        }
    }
}
