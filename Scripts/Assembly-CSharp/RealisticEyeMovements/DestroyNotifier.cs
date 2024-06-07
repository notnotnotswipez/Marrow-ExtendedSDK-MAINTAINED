using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RealisticEyeMovements
{
	public class DestroyNotifier : MonoBehaviour
	{
		public event Action<DestroyNotifier> OnDestroyedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDestroyed()
		{
		}
	}
}
