using System;
using SLZ.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class EnemyCollisonRelay : MonoBehaviour, ICollisonReceiver, IEventSystemHandler
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

		public void ReceiveCollison(Collision collison, float relVelocitySqr, bool isStay = false)
		{
		}
	}
}
