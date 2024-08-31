using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.CowboySupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic Collision Sensor One-off")]
	public class OneOffCollisionSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
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

		public int OutputCount
		{
			get
			{
				return 0;
			}
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		void IVoidLogicNode.Initialize(NodeState nodeState)
		{
		}

		void IVoidLogicSensor.ReadSensors(NodeState nodeState)
		{
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public OneOffCollisionSensor()
		{
		}

		[HideInInspector]
		[SerializeField]
		private bool _deprecated;

		[SerializeField]
		private bool _negate;

		private Rigidbody _rigidbody;

		private readonly Queue<ValueTuple<Vector3, Vector3>> _impacts;

		private static readonly PortMetadata _portMetadata;
	}
}
