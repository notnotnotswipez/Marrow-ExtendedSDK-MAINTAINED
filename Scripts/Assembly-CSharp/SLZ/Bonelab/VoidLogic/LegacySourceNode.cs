using System;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Obsolete("Superseded by PowerSource, RemapNode, and AddNode")]
	[Support(SupportFlags.Unsupported, "Superseded by PowerSource, RemapNode, and AddNode")]
	[AddComponentMenu("VoidLogic/Bonelab Internal/Source Node (Combined)")]
	public class LegacySourceNode : BaseNode
	{
		public float BaseValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Initialize(NodeState nodeState)
		{
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public LegacySourceNode()
		{
		}

		[Tooltip("Basic additive power (added to sum of previous inputs or 0)")]
		[SerializeField]
		private float _baseValue;

		[SerializeField]
		[Tooltip("Whether to remap the sum of inputs according to the remap curve")]
		private bool _enableRemap;

		[SerializeField]
		[Tooltip("Output response curve (applied to the sum of previous inputs or 0)")]
		private AnimationCurve _remapCurve;

		private static readonly PortMetadata _portMetadata;
	}
}
