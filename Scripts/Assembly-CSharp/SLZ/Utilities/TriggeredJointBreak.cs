using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class TriggeredJointBreak : MonoBehaviour
	{
		public UnityEvent OnConfigurableJointBreak;

		private void OnJointBreak(float breakForce)
		{
		}
	}
}
