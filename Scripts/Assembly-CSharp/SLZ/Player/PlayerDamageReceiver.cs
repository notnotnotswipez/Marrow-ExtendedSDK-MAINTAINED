using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Player
{
	public class PlayerDamageReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public enum BodyPart
		{
			Head = 0,
			Neck = 1,
			Chest = 2,
			Spine = 3,
			Pelvis = 4,
			ArmUpperLf = 5,
			ArmLowerLf = 6,
			HandLf = 7,
			ArmUpperRt = 8,
			ArmLowerRt = 9,
			HandRt = 10,
			LegUpperLf = 11,
			LegLowerLf = 12,
			FootLf = 13,
			LegUpperRt = 14,
			LegLowerRt = 15,
			FootRt = 16
		}

		public BodyPart bodyPart;

		[HideInInspector]
		public Health health;

		public void ReceiveAttack(Attack attack)
		{
		}

		public virtual void OnCollisionEnter(Collision collision)
		{
		}
	}
}
