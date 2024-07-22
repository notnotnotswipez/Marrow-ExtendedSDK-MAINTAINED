using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Asymmetric Slider One-off Node")]
	public class OneOffAsymmetricSliderNode : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
	{
		[Tooltip("Output response curve (multiplied by input)")]
		[SerializeField]
		private AnimationCurve _curve;

		[Tooltip("Slider joint that drives the output power value")]
		[SerializeField]
		private ConfigurableJoint _sliderConfigurableJoint;

		[Tooltip("Interactable host i.e. for running haptics")]
		[SerializeField]
		private InteractableHost _interactableHost;

		[SerializeField]
		[Header("Force")]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[SerializeField]
		[Header("Audio")]
		private AudioClip clip_clickOn;

		private Haptor _haptor;

		private bool _canHaptic;

		private bool _sliderThresholdHit;

		private Vector3 _cachedVirtualTargetPosition;

		private bool _performedInitialRead;

		private static readonly PortMetadata _portMetadata;

		public ConfigurableJoint SliderConfigurableJoint
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Rigidbody SliderRigidBody
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

		public Haptor Haptor
		{
			get
			{
				return null;
			}
			set
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
