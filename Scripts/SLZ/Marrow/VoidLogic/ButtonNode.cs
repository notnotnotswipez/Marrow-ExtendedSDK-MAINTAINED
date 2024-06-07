using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x02000099 RID: 153
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Button")]
	public class ButtonNode : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x00003733 File Offset: 0x00001933
		private new void Awake()
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00003735 File Offset: 0x00001935
		protected override void OnEnable()
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00003737 File Offset: 0x00001937
		 void SLZ.Marrow.VoidLogic.IVoidLogicSensor.ReadSensors(ref NodeState nodeState)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00003739 File Offset: 0x00001939
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000373B File Offset: 0x0000193B
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00006B2C File Offset: 0x00004D2C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002DD RID: 733
		[SerializeField]
		protected float _lowThreshold;

		// Token: 0x040002DE RID: 734
		[SerializeField]
		protected float _highThreshold;

		// Token: 0x040002DF RID: 735
		[SerializeField]
		protected ConfigurableJoint _joint;

		// Token: 0x040002E0 RID: 736
		[SerializeField]
		protected Transform _endTransform;

		// Token: 0x040002E1 RID: 737
		[Header("Audio")]
		[Tooltip("Clip(s) to be played on button press")]
		[SerializeField]
		protected AudioClip[] _pressClips;

		// Token: 0x040002E2 RID: 738
		[Tooltip("Clip(s) to be played on button unpress")]
		[SerializeField]
		protected AudioClip[] _depressClips;

		// Token: 0x040002E3 RID: 739
		[Tooltip("Colliders that the button shaft collider will ignore")]
		[SerializeField]
		protected Collider[] _ignoreColliders;

		// Token: 0x040002E4 RID: 740
		[SerializeField]
		protected Collider _buttonShaftCollider;

		// Token: 0x040002E5 RID: 741
		protected Rigidbody _rigidBody;

		// Token: 0x040002E6 RID: 742
		private Vector3 _initialDisplacement;

		// Token: 0x040002E7 RID: 743
		protected bool _isPressed;

		// Token: 0x040002E8 RID: 744
		private bool _performedInitialRead;

		// Token: 0x040002E9 RID: 745
		private static readonly PortMetadata _portMetadata;
	}
}
