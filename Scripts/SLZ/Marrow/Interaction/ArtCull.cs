using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200012D RID: 301
	public class ArtCull : MarrowBehaviour
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x000044BA File Offset: 0x000026BA
		private void OnEnable()
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000044BC File Offset: 0x000026BC
		private void OnDisable()
		{
		}

		// Token: 0x04000668 RID: 1640
		[SerializeField]
		private LODGroup[] _lodGroups;

		// Token: 0x04000669 RID: 1641
		[SerializeField]
		private Renderer[] _renderers;
	}
}
