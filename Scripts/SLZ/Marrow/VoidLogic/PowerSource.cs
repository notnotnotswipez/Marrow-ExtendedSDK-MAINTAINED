using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B3 RID: 179
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/PowerSource")]
	[AddComponentMenu("VoidLogic/Sources/VoidLogic Power")]
	[Support(SupportFlags.Supported, null)]
	public class PowerSource : MonoBehaviour, IVoidLogicSource, IVoidLogicNode
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0000399B File Offset: 0x00001B9B
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0000399E File Offset: 0x00001B9E
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000039A0 File Offset: 0x00001BA0
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x000039A7 File Offset: 0x00001BA7
		public float OutputValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000039A9 File Offset: 0x00001BA9
		private void Awake()
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000039AB File Offset: 0x00001BAB
		private void OnEnable()
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000039AD File Offset: 0x00001BAD
		private void OnDisable()
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000039AF File Offset: 0x00001BAF
		private void OnDestroy()
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000039B1 File Offset: 0x00001BB1
		 void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00006D84 File Offset: 0x00004F84
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x0400036A RID: 874
		[SerializeField]
		[Tooltip("Amount of power supplied by this source")]
		private float _value;

		// Token: 0x0400036B RID: 875
		private static readonly PortMetadata _portMetadata;
	}
}
