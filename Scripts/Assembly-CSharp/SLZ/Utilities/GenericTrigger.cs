using UnityEngine;

namespace SLZ.Utilities
{
	public class GenericTrigger : MonoBehaviour
	{
		[SerializeField]
		private LayerMask LayerFilter;

		[SerializeField]
		private string Tag;

		[SerializeField]
		private UnityEventTrigger OnTriggerEnterEvent;

		[SerializeField]
		private UnityEventTrigger OnTriggerExitEvent;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
