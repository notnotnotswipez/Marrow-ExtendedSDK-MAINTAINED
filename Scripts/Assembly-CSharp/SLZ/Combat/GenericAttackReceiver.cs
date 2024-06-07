using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class GenericAttackReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[SerializeField]
		public AttackType attackType;

		public UnityEventFloat AttackEvent;

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
