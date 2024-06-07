using System;
using UnityEngine;

namespace SLZ.Combat
{
	public class CollisionCollector : MonoBehaviour
	{
		[Serializable]
		public class RelevantCollision
		{
			public Vector3 totalImpulse;

			public Rigidbody rigidbody;

			public float separation;

			public Vector3 relativeVelocity;

			public Vector3 point;

			public Vector3 normal;

			public Collider collider;

			public Collider colliderSelf;

			public ImpactProperties iP;
		}

		public float impactVelocityThresh;

		[SerializeField]
		private CollisionStay _collisionStay;

		private bool _stayEnabled;

		private bool _isEnter;

		private bool _collisionWithImpulse;

		private RelevantCollision _relCol;

		private float _highestImpulseSqrMag;

		public Action<RelevantCollision> OnSignificantCollisionEnter;

		public Action<RelevantCollision> OnSignificantCollisionStay;

		private void Reset()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		public void CollectCollision(Collision c, ImpactProperties iP, bool isEnter)
		{
		}

		public void ProcessCollisionHaul(float fixedDeltaTime)
		{
		}

		private void PrepCollisionEnter(RelevantCollision c, float fixedDeltaTime)
		{
		}

		private void PrepCollisionStay(RelevantCollision c, float fixedDeltaTime)
		{
		}

		public bool CheckImpact(float impulse, float duration, float time, ref float lastImpulse, ref float nextTime)
		{
			return false;
		}
	}
}
