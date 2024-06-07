using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericOnEnable : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent StartEvent;

		private bool _hasEvent;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}
	}
}
