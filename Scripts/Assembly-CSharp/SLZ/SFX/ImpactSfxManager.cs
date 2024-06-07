using UnityEngine;

namespace SLZ.SFX
{
	public class ImpactSfxManager : MonoBehaviour
	{
		public ImpactSFX[] impactSfxes;

		private float _impactCooldownTime;

		private float _lastImpactImpulse;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		public bool CheckImpact(float impulse, ImpactSFX impact)
		{
			return false;
		}
	}
}
