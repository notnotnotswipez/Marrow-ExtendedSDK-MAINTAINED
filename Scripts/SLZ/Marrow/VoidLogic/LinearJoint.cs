using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AF RID: 175
	[Support(SupportFlags.BetaSupported, "This works, but uses ConfigurableJoint instead of Marrow primitives.")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LinearJoint")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Linear Joint (Sliding)")]
	public sealed class LinearJoint : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000038EC File Offset: 0x00001AEC
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x000038EF File Offset: 0x00001AEF
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

		// Token: 0x06000625 RID: 1573 RVA: 0x000038F1 File Offset: 0x00001AF1
		private void Awake()
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000038F3 File Offset: 0x00001AF3
		private void OnEnable()
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000038F5 File Offset: 0x00001AF5
		private void OnDisable()
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000038F7 File Offset: 0x00001AF7
		private void OnDestroy()
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000038F9 File Offset: 0x00001AF9
		private void Start()
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000038FB File Offset: 0x00001AFB
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000038FD File Offset: 0x00001AFD
		private void SETJOINT(float voltage = 1f)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000038FF File Offset: 0x00001AFF
		private void WarpJoint()
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00003901 File Offset: 0x00001B01
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00003904 File Offset: 0x00001B04
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000390A File Offset: 0x00001B0A
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00006D24 File Offset: 0x00004F24
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000331 RID: 817
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		// Token: 0x04000332 RID: 818
		private float? _priorValue;

		// Token: 0x04000333 RID: 819
		[SerializeField]
		private bool _warpOnStart;

		// Token: 0x04000334 RID: 820
		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		// Token: 0x04000335 RID: 821
		private Rigidbody _rigidBody;

		// Token: 0x04000336 RID: 822
		[Header("Joint Control")]
		[SerializeField]
		private bool _varyTargetPosition;

		// Token: 0x04000337 RID: 823
		[SerializeField]
		private Vector3 _minPosition;

		// Token: 0x04000338 RID: 824
		[SerializeField]
		private Vector3 _maxPosition;

		// Token: 0x04000339 RID: 825
		[SerializeField]
		private bool _varyTargetVelocity;

		// Token: 0x0400033A RID: 826
		[SerializeField]
		private Vector3 _minVelocity;

		// Token: 0x0400033B RID: 827
		[SerializeField]
		private Vector3 _maxVelocity;

		// Token: 0x0400033C RID: 828
		[SerializeField]
		private bool _varyPrismaticDrive;

		// Token: 0x0400033D RID: 829
		[SerializeField]
		private Vector3 _xMinSpringDamperForce;

		// Token: 0x0400033E RID: 830
		[SerializeField]
		private Vector3 _xMaxSpringDamperForce;

		// Token: 0x0400033F RID: 831
		[SerializeField]
		private bool _varyPrismaticY;

		// Token: 0x04000340 RID: 832
		[SerializeField]
		private Vector3 _yMinSpringDamperForce;

		// Token: 0x04000341 RID: 833
		[SerializeField]
		private Vector3 _yMaxSpringDamperForce;

		// Token: 0x04000342 RID: 834
		[SerializeField]
		private bool _varyPrismaticZ;

		// Token: 0x04000343 RID: 835
		[SerializeField]
		private Vector3 _zMinSpringDamperForce;

		// Token: 0x04000344 RID: 836
		[SerializeField]
		private Vector3 _zMaxSpringDamperForce;

		// Token: 0x04000345 RID: 837
		private static readonly PortMetadata _portMetadata;
	}
}
