using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ParticleSystem))]
	public class PlatformParticleLight : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem ps;

		private void Awake()
		{
		}

		private void Reset()
		{
		}
	}
}
