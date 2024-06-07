using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000B4 RID: 180
	public static class VL
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x000039BD File Offset: 0x00001BBD
		[MethodImpl(256)]
		public static void AddNode(IVoidLogicNode node)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000039BF File Offset: 0x00001BBF
		[MethodImpl(256)]
		public static void RemoveNode(IVoidLogicNode node)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000039C1 File Offset: 0x00001BC1
		[MethodImpl(256)]
		public static void EnableNode(IVoidLogicNode node)
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000039C3 File Offset: 0x00001BC3
		[MethodImpl(256)]
		public static void DisableNode(IVoidLogicNode node)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000039C5 File Offset: 0x00001BC5
		[MethodImpl(256)]
		public static void UpdateInput(IVoidLogicSink sink, uint index, IVoidLogicSource source)
		{
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000039C7 File Offset: 0x00001BC7
		public static float GetValue(MonoBehaviour sourceMb, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000039CE File Offset: 0x00001BCE
		public static bool TryGetInputValueAtIndex(this IVoidLogicSink sink, uint index, out float value)
		{
			value = 0f;
			return false;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000039D8 File Offset: 0x00001BD8
		[MethodImpl(256)]
		public static float InputValueOrDefault(this IVoidLogicSink sink, uint index, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000039DF File Offset: 0x00001BDF
		public static NodeState State(MonoBehaviour sourceMb)
		{
			return default(NodeState);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000039E3 File Offset: 0x00001BE3
		public static NodeState State(this IVoidLogicSource source)
		{
			return default(NodeState);
		}

		// Token: 0x0400036C RID: 876
		private static NodeState _badState;
	}
}
