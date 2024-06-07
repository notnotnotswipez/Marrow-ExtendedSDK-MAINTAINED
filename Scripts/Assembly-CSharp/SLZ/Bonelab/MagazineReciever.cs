using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MagazineReciever : InteractionReciever
	{
		[Range(0f, 10f)]
		public float priority;

		[Header("References")]
		public AudioClip[] grabClips;

		public override void OnInteractableHostDrop(InteractableHost host)
		{
		}
	}
}
