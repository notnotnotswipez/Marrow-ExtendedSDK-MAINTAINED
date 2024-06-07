using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B0 RID: 176
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Material Switcher")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MaterialSwitcher")]
	public class MaterialSwitcher : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00003917 File Offset: 0x00001B17
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0000391A File Offset: 0x00001B1A
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

		// Token: 0x06000635 RID: 1589 RVA: 0x0000391C File Offset: 0x00001B1C
		private void Awake()
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000391E File Offset: 0x00001B1E
		private void OnEnable()
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00003920 File Offset: 0x00001B20
		private void OnDisable()
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00003922 File Offset: 0x00001B22
		private void OnDestroy()
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00003924 File Offset: 0x00001B24
		private void Start()
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00003926 File Offset: 0x00001B26
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00003928 File Offset: 0x00001B28
		private void UpdateMats(Material mat)
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0000392A File Offset: 0x00001B2A
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000392D File Offset: 0x00001B2D
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00003933 File Offset: 0x00001B33
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00006D3C File Offset: 0x00004F3C
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000347 RID: 839
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node in the chain")]
		private MonoBehaviour _previousNode;

		// Token: 0x04000348 RID: 840
		private float _priorValue;

		// Token: 0x04000349 RID: 841
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x0400034A RID: 842
		[SerializeField]
		private int[] _materialIndex;

		// Token: 0x0400034B RID: 843
		[SerializeField]
		private Material _offMat;

		// Token: 0x0400034C RID: 844
		[SerializeField]
		private Material _onMat;

		// Token: 0x0400034D RID: 845
		[SerializeField]
		private float lowThreshold;

		// Token: 0x0400034E RID: 846
		[SerializeField]
		private float highThreshold;

		// Token: 0x0400034F RID: 847
		private bool _isHigh;

		// Token: 0x04000350 RID: 848
		private static readonly PortMetadata _portMetadata;
	}
}
