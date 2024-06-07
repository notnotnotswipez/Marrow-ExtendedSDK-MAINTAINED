using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SLZ.Combat
{
	public class AttackReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public UnityEvent OnAttackReceived;

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
