using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B1 RID: 177
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RotatingJoint")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Rotating Joint")]
	[Support(SupportFlags.BetaSupported, "This works, but uses ConfigurableJoint instead of Marrow primitives.")]
	public sealed class RotatingJoint : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00003940 File Offset: 0x00001B40
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00003943 File Offset: 0x00001B43
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

		// Token: 0x06000644 RID: 1604 RVA: 0x00003945 File Offset: 0x00001B45
		private void Awake()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00003947 File Offset: 0x00001B47
		private void OnEnable()
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00003949 File Offset: 0x00001B49
		private void OnDisable()
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000394B File Offset: 0x00001B4B
		private void OnDestroy()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000394D File Offset: 0x00001B4D
		private void Start()
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000394F File Offset: 0x00001B4F
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00003951 File Offset: 0x00001B51
		private void SETJOINT(float voltage = 1f)
		{
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00003953 File Offset: 0x00001B53
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00003956 File Offset: 0x00001B56
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000395C File Offset: 0x00001B5C
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00006D54 File Offset: 0x00004F54
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000352 RID: 850
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		// Token: 0x04000353 RID: 851
		private float? _priorValue;

		// Token: 0x04000354 RID: 852
		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		// Token: 0x04000355 RID: 853
		private Rigidbody _rigidBody;

		// Token: 0x04000356 RID: 854
		[Header("Joint Control")]
		[SerializeField]
		private bool _varyTargetRotation;

		// Token: 0x04000357 RID: 855
		[SerializeField]
		private float _minDegreesX;

		// Token: 0x04000358 RID: 856
		[SerializeField]
		private float _maxDegreesX;

		// Token: 0x04000359 RID: 857
		[SerializeField]
		private bool _varyTargetAngVelocity;

		// Token: 0x0400035A RID: 858
		[SerializeField]
		private Vector3 _minAngVelocity;

		// Token: 0x0400035B RID: 859
		[SerializeField]
		private Vector3 _maxAngVelocity;

		// Token: 0x0400035C RID: 860
		[SerializeField]
		private bool _varyAngularDrive;

		// Token: 0x0400035D RID: 861
		[SerializeField]
		private Vector3 _xAngMinSpringDamperForce;

		// Token: 0x0400035E RID: 862
		[SerializeField]
		private Vector3 _xAngMaxSpringDamperForce;

		// Token: 0x0400035F RID: 863
		private static readonly PortMetadata _portMetadata;
	}
}
