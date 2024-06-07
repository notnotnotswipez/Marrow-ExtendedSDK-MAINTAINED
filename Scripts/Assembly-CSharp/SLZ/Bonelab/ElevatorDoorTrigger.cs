using System.Collections.Generic;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ElevatorDoorTrigger : MonoBehaviour
	{
		[SerializeField]
		private bool isExitTrigger;

		[SerializeField]
		private TutorialElevator elevator;

		[SerializeField]
		private List<ObjectDestructible> destObjList;

		private HashSet<GameObject> containedObjHash;

		public void OnDoorClose()
		{
		}

		public void OnTriggerEnter(Collider col)
		{
		}

		public void OnTriggerExit(Collider col)
		{
		}
	}
}
