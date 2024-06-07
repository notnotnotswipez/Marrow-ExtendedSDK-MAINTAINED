using System;
using UnityEngine.Events;

namespace SLZ.Player
{
	[Serializable]
	public class NearEvents
	{
		public UnityEvent OnHandHoverBeginEvent;

		public UnityEvent OnHandHoverEndEvent;

		public UnityEvent OnHandHoverUpdateEvent;
	}
}
