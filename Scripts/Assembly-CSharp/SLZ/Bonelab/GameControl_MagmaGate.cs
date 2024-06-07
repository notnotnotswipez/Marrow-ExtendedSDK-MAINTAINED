using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_MagmaGate : BonelabAvatarLevelGameControl
	{
		public GameObject[] laserBeams;

		public UnityEvent loseEvent;

		public override void DoLevelComplete()
		{
		}

		[ContextMenu("dissolve")]
		public void LoseSequence()
		{
		}

		private void DoorDissolve()
		{
		}
	}
}
