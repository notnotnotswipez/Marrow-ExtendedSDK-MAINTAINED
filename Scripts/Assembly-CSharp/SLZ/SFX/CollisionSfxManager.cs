using UnityEngine;

namespace SLZ.SFX
{
	public class CollisionSfxManager : MonoBehaviour
	{
		public CollisionSFX[] collisionSfxes;

		private float _impactCooldownTime;

		private float _lastImpactImpulse;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public bool CheckImpact(float impulse, CollisionSFX impact)
		{
			return false;
		}
	}
}
