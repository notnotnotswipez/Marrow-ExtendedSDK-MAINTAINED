using UnityEngine;

namespace Ara
{
	[RequireComponent(typeof(AraTrail))]
	public class TireTrack : MonoBehaviour
	{
		private AraTrail trail;

		public float offset;

		public float maxDist;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ProjectToGround()
		{
		}
	}
}
