using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x02000098 RID: 152
	public abstract class BaseNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000370F File Offset: 0x0000190F
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00003712 File Offset: 0x00001912
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

		// Token: 0x0600057B RID: 1403 RVA: 0x00003714 File Offset: 0x00001914
		protected virtual void Awake()
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00003716 File Offset: 0x00001916
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00003718 File Offset: 0x00001918
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000371A File Offset: 0x0000191A
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600057F RID: 1407
		public abstract PortMetadata PortMetadata { get; }

		// Token: 0x06000580 RID: 1408 RVA: 0x0000371C File Offset: 0x0000191C
		[MethodImpl(256)]
		protected static bool EqualWithTolerance(float term1, float term2, float tolerance)
		{
			return false;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000371F File Offset: 0x0000191F
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00003722 File Offset: 0x00001922
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00003728 File Offset: 0x00001928
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x06000584 RID: 1412
		public abstract void Calculate(ref NodeState nodeState);

		// Token: 0x040002DC RID: 732
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		protected internal MonoBehaviour[] _previous;
	}
}
