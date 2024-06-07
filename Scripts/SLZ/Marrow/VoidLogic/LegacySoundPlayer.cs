using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AE RID: 174
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Legacy Sound Player")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This probably isn't it, but it's supported for now.")]
	public class LegacySoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000038C7 File Offset: 0x00001AC7
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000038CA File Offset: 0x00001ACA
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

		// Token: 0x06000618 RID: 1560 RVA: 0x000038CC File Offset: 0x00001ACC
		private void Awake()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000038CE File Offset: 0x00001ACE
		private void OnEnable()
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000038D0 File Offset: 0x00001AD0
		private void OnDisable()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000038D2 File Offset: 0x00001AD2
		private void OnDestroy()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000038D4 File Offset: 0x00001AD4
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000038D6 File Offset: 0x00001AD6
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000038D9 File Offset: 0x00001AD9
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000038DF File Offset: 0x00001ADF
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00006D0C File Offset: 0x00004F0C
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000329 RID: 809
		[Tooltip("Previous node in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		// Token: 0x0400032A RID: 810
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x0400032B RID: 811
		private float _priorValue;

		// Token: 0x0400032C RID: 812
		protected bool _wasOn;

		// Token: 0x0400032D RID: 813
		[Header("Audio")]
		[SerializeField]
		private AudioClip _onSound;

		// Token: 0x0400032E RID: 814
		[SerializeField]
		private AudioClip _offSound;

		// Token: 0x0400032F RID: 815
		private static readonly PortMetadata _portMetadata;
	}
}
