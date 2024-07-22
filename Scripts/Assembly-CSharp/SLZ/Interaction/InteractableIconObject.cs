using SLZ.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	[CreateAssetMenu(fileName = "New Icon Asset", menuName = "Variables/Icon Asset", order = 5)]
	public class InteractableIconObject : SingletonScriptableObject<InteractableIconObject>
	{
		public Material material;

		public Texture2DArray IconTextureArray;

		[Tooltip("Size of an icon in world units")]
		public float GeneralScale;

		[Tooltip("Time in seconds for an icon to scale up / down")]
		public float AnimationDuration;

		public InteractableIconObject()
		{
			
		}
	}
}
