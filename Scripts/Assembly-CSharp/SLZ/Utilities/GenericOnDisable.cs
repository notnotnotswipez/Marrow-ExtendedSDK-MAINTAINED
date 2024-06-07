using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericOnDisable : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent DisableEvent;

		private void OnDisable()
		{
		}
	}
}
