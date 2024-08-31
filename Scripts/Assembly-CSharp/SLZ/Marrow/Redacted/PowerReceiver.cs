using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Marrow.Redacted
{
	public sealed class PowerReceiver : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource, ISocketable
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

		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		public int OutputCount
		{
			get
			{
				return 0;
			}
		}

		void IVoidLogicNode.Initialize(NodeState nodeState)
		{
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public bool TryGetInputConnection(uint inputIndex, [Out] OutputPortReference connectedPort)
		{
			return default(bool);
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return default(bool);
		}

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public Socket Socket
		{
			get
			{
				return null;
			}
		}

		public void OnPlugAttached(Plug plug)
		{
		}

		public void OnPlugDetached(Plug plug)
		{
		}

		public PowerReceiver()
		{
		}

		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Tooltip("Previous node in the chain")]
		[SerializeField]
		[ReadOnly(false)]
		private OutputPortReference _previousConnection;

		private static readonly PortMetadata _portMetadata;

		[SerializeField]
		private Socket _socket;

		private PowerSender _powerPlug;
	}
}
