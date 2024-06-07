using System;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	[Serializable]
	public class ActionDirector
	{
		public string actionKey;

		public PlayableDirector director;

		public bool wasTriggered;
	}
}
