using System;
using UnityEngine.EventSystems;

namespace SLZ.Marrow.Combat
{
	// Token: 0x020001AD RID: 429
	public interface IAttackReceiver : IEventSystemHandler
	{
		// Token: 0x06000F02 RID: 3842
		void ReceiveAttack(Attack attack);
	}
}
