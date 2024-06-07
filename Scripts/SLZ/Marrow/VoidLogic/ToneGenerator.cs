using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B2 RID: 178
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/ToneGenerator")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Tone Generator")]
	[Support(SupportFlags.AlphaSupported, "This is intended mainly for debugging, and as such its serialization compatibility is not guaranteed.")]
	public class ToneGenerator : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00003969 File Offset: 0x00001B69
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0000396C File Offset: 0x00001B6C
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0000396E File Offset: 0x00001B6E
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00003975 File Offset: 0x00001B75
		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00003977 File Offset: 0x00001B77
		private void Awake()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00003979 File Offset: 0x00001B79
		private void OnEnable()
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000397B File Offset: 0x00001B7B
		private void OnDisable()
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000397D File Offset: 0x00001B7D
		private void OnDestroy()
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000397F File Offset: 0x00001B7F
		private void Start()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00003981 File Offset: 0x00001B81
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00003983 File Offset: 0x00001B83
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00003985 File Offset: 0x00001B85
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00003988 File Offset: 0x00001B88
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000398E File Offset: 0x00001B8E
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00006D6C File Offset: 0x00004F6C
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000361 RID: 865
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		protected internal MonoBehaviour[] _previous;

		// Token: 0x04000362 RID: 866
		[Range(0f, 1f)]
		[SerializeField]
		private float _volume;

		// Token: 0x04000363 RID: 867
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04000364 RID: 868
		private float _frequency;

		// Token: 0x04000365 RID: 869
		private int _sampleRate;

		// Token: 0x04000366 RID: 870
		private float _phase;

		// Token: 0x04000367 RID: 871
		private bool _running;

		// Token: 0x04000368 RID: 872
		private static readonly PortMetadata _portMetadata;
	}
}
