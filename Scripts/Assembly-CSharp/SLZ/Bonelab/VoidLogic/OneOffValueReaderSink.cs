using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, "Replaced by TextAdapter.")]
	[Obsolete("Replaced by TextAdapter.")]
	[AddComponentMenu(null)]
	public sealed class OneOffValueReaderSink : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
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

		public bool Deprecated
		{
			get
			{
				return default(bool);
			}
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

		private void Update()
		{
		}

		private void UpdateText()
		{
		}

		void IVoidLogicNode.Initialize(NodeState nodeState)
		{
		}

		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		public bool TryGetInputConnection(uint inputIndex, [Out] OutputPortReference connectedPort)
		{
			return default(bool);
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return default(bool);
		}

		PortMetadata IVoidLogicNode.PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public OneOffValueReaderSink()
		{
		}

		[Tooltip("Dead Field: Please remove")]
		[SerializeField]
		[Obsolete("Dead Field: Please remove")]
		[NonReorderable]
		protected internal MonoBehaviour _previousNode;

		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private OutputPortReference _previousConnection;

		private float _priorValue;

		public TextMeshPro tmp;

		public string labelText;

		private static readonly PortMetadata _portMetadata;
	}
}
