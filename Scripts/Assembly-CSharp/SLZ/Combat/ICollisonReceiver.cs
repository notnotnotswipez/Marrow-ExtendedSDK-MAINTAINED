using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public interface ICollisonReceiver : IEventSystemHandler
	{
		void ReceiveCollison(Collision collison, float relVelocitySqr, bool isStay = false);
	}
}
