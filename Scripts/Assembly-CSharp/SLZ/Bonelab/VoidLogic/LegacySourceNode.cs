using System;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, "Superseded by PowerSource, RemapNode, and AddNode")]
	[Obsolete("Superseded by PowerSource, RemapNode, and AddNode")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SourceNode")]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/Source Node (Combined)")]
	public class LegacySourceNode : BaseNode
	{
		[Tooltip("Basic additive power (added to sum of previous inputs or 0)")]
		[SerializeField]
		private float _baseValue;

		[Tooltip("Whether to remap the sum of inputs according to the remap curve")]
		[SerializeField]
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
