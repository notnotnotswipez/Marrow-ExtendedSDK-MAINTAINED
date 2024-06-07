using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow
{
	// Token: 0x02000019 RID: 25
	public interface IResumePoint
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001B0 RID: 432
		Transform SpawnLocation { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B1 RID: 433
		UnityEvent OnReachedResumePoint { get; }
	}
}
