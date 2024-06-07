using SLZ.Combat;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class CollisionSFX : MonoBehaviour
	{
		public AudioClip[] impactSoft;

		public AudioClip[] impactHard;

		public AudioClip[] slideSoft;

		public AudioClip[] slideHard;

		private ManagedAudioPlayer _mapImpact;

		private ManagedAudioPlayer _mapSlide;

		private float _nextImpactTime;

		private float _lastImpulse;

		private float _nextSlideTime;

		private Vector3 _lastRelVelPlane;

		[SerializeField]
		private Rigidbody _body;

		[SerializeField]
		private CollisionCollector _collisionCollector;

		[HideInInspector]
		public CollisionSfxManager manager;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSignificantCollisionEnter(CollisionCollector.RelevantCollision c)
		{
		}

		private void OnSignificantCollisionStay(CollisionCollector.RelevantCollision c)
		{
		}

		private void Slide(float speed, float impulse, float relAccelSqMg)
		{
		}
	}
}
