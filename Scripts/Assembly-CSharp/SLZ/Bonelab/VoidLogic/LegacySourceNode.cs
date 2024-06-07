using System;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SourceNode")]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/Source Node (Combined)")]
	[Support(SupportFlags.Unsupported, "Superseded by PowerSource, RemapNode, and AddNode")]
	[Obsolete("Superseded by PowerSource, RemapNode, and AddNode")]
	public class LegacySourceNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Basic additive power (added to sum of previous inputs or 0)")]
		private float _baseValue;

		[SerializeField]
		[Tooltip("Whether to remap the sum of inputs according to the remap curve")]
		private bool _enableRemap;

		[Tooltip("Output response curve (applied to the sum of previous inputs or 0)")]
		[SerializeField]
		private AnimationCurve _remapCurve;

		private static readonly PortMetadata _portMetadata;

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

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
