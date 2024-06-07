using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RatchetNode")]
	[Support(SupportFlags.AlphaSupported, "I'm not certain this is the best approach but it's a solution that has been proven to work.")]
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Ratchet")]
	public class RatchetNode : BaseNode
	{
		[SerializeField]
		private float lowThreshold;

		private float _maximumValueEverReached;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}

		public void ResetRatchet()
		{
		}
	}
}
