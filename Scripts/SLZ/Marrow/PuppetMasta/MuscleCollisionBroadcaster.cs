using System;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E2 RID: 226
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00003ECE File Offset: 0x000020CE
		public static ComponentCache<MuscleCollisionBroadcaster> Cache
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00003ED1 File Offset: 0x000020D1
		private void Awake()
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00003ED3 File Offset: 0x000020D3
		private void OnDestroy()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00003ED5 File Offset: 0x000020D5
		public void Hit(Attack attack)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00003ED7 File Offset: 0x000020D7
		public void ReceiveAttack(Attack attack)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00003ED9 File Offset: 0x000020D9
		public virtual void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0400054C RID: 1356
		private static ComponentCache<MuscleCollisionBroadcaster> _cache;

		// Token: 0x0400054D RID: 1357
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		// Token: 0x0400054E RID: 1358
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		// Token: 0x0400054F RID: 1359
		private const string onMuscleHit = "OnMuscleHit";

		// Token: 0x04000550 RID: 1360
		private const string onMuscleCollision = "OnMuscleCollision";

		// Token: 0x04000551 RID: 1361
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		// Token: 0x04000552 RID: 1362
		private MuscleCollisionBroadcaster otherBroadcaster;
	}
}
