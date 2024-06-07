using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Animation))]
	public class playanimation : MonoBehaviour
	{
		public Animation animation;

		public float RandomizeSpeed;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}
	}
}
