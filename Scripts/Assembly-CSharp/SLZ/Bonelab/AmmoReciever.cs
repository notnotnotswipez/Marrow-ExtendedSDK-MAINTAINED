using System;
using SLZ.Interaction;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AmmoReciever : InteractionReciever
	{
		[Header("References")]
		public Transform startInsertTarget;

		public Transform endInsertTarget;

		public AudioClip[] insertClips;

		public AudioClip[] ejectClips;

		[HideInInspector]
		public Action<Magazine> OnInserted;

		public override void OnInteractableHostEnter(InteractableHost host)
		{
		}
	}
}
