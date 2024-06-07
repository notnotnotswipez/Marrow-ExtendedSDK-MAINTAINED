using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericOnJointBreak : MonoBehaviour
	{
		public UnityEvent JointBreakEvent;

		private void OnJointBreak(float breakForce)
		{
		}
	}
}
