using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AD RID: 173
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/EventAdapter")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Event Adapter")]
	[Support(SupportFlags.Supported, "<b>Reminder</b>: Is there a better way to do this?")]
	public sealed class EventAdapter : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00003896 File Offset: 0x00001A96
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00003899 File Offset: 0x00001A99
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

		// Token: 0x06000605 RID: 1541 RVA: 0x0000389B File Offset: 0x00001A9B
		private void Awake()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000389D File Offset: 0x00001A9D
		private void OnEnable()
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000389F File Offset: 0x00001A9F
		private void OnDisable()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000038A1 File Offset: 0x00001AA1
		private void OnDestroy()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000038A3 File Offset: 0x00001AA3
		private void Start()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000038A5 File Offset: 0x00001AA5
		 void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000038A7 File Offset: 0x00001AA7
		private void _invokeInputUpdated(IVoidLogicSource source, float f)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000038A9 File Offset: 0x00001AA9
		private void _invokeInputRose(IVoidLogicSource source, float f)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000038AB File Offset: 0x00001AAB
		private void _invokeInputRoseOneShot(IVoidLogicSource source, float f)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000038AD File Offset: 0x00001AAD
		private void _invokeInputFell(IVoidLogicSource source, float f)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000038AF File Offset: 0x00001AAF
		private void _invokeInputHeld(IVoidLogicSource source, float f)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000038B1 File Offset: 0x00001AB1
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000038B4 File Offset: 0x00001AB4
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000038BA File Offset: 0x00001ABA
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x0400031C RID: 796
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour _previousNode;

		// Token: 0x0400031D RID: 797
		[SerializeField]
		private float lowThreshold;

		// Token: 0x0400031E RID: 798
		[SerializeField]
		private float highThreshold;

		// Token: 0x0400031F RID: 799
		[Tooltip("When the input value changes (EXPENSIVE, runs all callbacks on every value update)")]
		[Header("Events")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputUpdated;

		// Token: 0x04000320 RID: 800
		[Tooltip("When the input value rises above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRose;

		// Token: 0x04000321 RID: 801
		[Tooltip("When the input value holds above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputHeld;

		// Token: 0x04000322 RID: 802
		[Tooltip("When the input value lowers beneath the low threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputFell;

		// Token: 0x04000323 RID: 803
		[Tooltip("When the input value rises above the high threshold (for the first time only)")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRoseOneShot;

		// Token: 0x04000324 RID: 804
		private float _priorValue;

		// Token: 0x04000325 RID: 805
		private bool _isHigh;

		// Token: 0x04000326 RID: 806
		private bool _hasBeenHigh;

		// Token: 0x04000327 RID: 807
		private static readonly PortMetadata _portMetadata;
	}
}
