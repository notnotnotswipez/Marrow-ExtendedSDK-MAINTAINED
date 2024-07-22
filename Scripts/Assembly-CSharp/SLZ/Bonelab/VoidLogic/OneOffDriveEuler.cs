using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu(null)]
	[Support(SupportFlags.Unsupported, "This is a one-off for testing.")]
	public sealed class OneOffDriveEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver, IVoidLogicActuator
	{
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		[Obsolete("Replace with `_previousConnections`")]
		private MonoBehaviour[] _previous;

		[SerializeField]
		private ConfigurableJoint target;

		private static readonly PortMetadata _portMetadata;

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

        int IVoidLogicSink.InputCount => throw new NotImplementedException();

        PortMetadata IVoidLogicNode.PortMetadata => throw new NotImplementedException();

        VoidLogicSubgraph IVoidLogicNode.Subgraph { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

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

        bool IVoidLogicSink.TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
        {
            throw new NotImplementedException();
        }

        public void OnBeforeSerialize()
        {
            
        }

        public void OnAfterDeserialize()
        {
            
        }
    }
}
