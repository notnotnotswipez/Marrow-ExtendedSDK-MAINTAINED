using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class AttackReceiver_TimeSlow : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public ChristmasTree controlEnvironment;

		public int targetNumber_Up;

		public int targetNumber_Down;

		private void Start()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
