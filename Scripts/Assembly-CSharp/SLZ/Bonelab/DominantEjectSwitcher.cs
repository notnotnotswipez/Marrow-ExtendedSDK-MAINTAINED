using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DominantEjectSwitcher : MonoBehaviour
	{
		public Grip grip;

		public Gun gun;

		public Transform rightEject;

		public Transform leftEject;

		private void Start()
		{
		}

		private void OnGrip(Hand hand)
		{
		}
	}
}
