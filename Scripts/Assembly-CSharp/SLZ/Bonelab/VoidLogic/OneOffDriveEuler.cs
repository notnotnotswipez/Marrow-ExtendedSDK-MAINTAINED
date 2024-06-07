using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, "This is a one-off for testing.")]
	[AddComponentMenu(null)]
	public sealed class OneOffDriveEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		internal MonoBehaviour[] _previous;

		[SerializeField]
		private ConfigurableJoint target;

		private static readonly PortMetadata _portMetadata;

		public PortMetadata PortMetadata { get; }

		public VoidLogicSubgraph Subgraph
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

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Actuate(ref NodeState nodeState)
		{
		}

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}
	}
}
