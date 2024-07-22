using SLZ.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class KeyDecorator : SpawnDecorator
	{
		[Tooltip("this overrides the key code in the prefab asset")]
		public KeyReceiver.Code code;

	}
}
