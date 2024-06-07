using System;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.VFX
{
	[Serializable]
	public class DestructableLootSpawnEvent : UnityEvent<ObjectDestructible, Spawnable, GameObject>
	{
		public DestructableLootSpawnEvent()
		{

		}
	}
}
