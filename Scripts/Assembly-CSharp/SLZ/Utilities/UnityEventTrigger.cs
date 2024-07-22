using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	[Serializable]
	public class UnityEventTrigger : UnityEvent<Collider>
	{
		public UnityEventTrigger()
		{
			
		}
	}
}
