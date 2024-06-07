using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(RectTransform))]
	public class VRUIItem : MonoBehaviour
	{
		private Collider boxCollider;

		private RectTransform rectTransform;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void ValidateCollider()
		{
		}
	}
}
