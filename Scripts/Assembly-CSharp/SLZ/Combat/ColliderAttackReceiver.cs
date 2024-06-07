using System.Collections.Generic;
using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SLZ.Combat
{
	public class ColliderAttackReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public UnityEvent OnColiderAttackReceived;

		public List<Collider> colliders;

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
