using System;
using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class EnemyDamageReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[Flags]
		public enum BodyPart
		{
			Head = 1,
			Chest = 2,
			Pelvis = 4,
			LeftArm = 8,
			LeftLeg = 0x10,
			RightArm = 0x20,
			RightLeg = 0x40
		}

		public BodyPart bodyPart;

		public Enemy_Health e_health;

		private void Reset()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
