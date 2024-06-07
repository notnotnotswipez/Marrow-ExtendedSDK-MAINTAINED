using SLZ.Marrow.Audio;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.VRMK
{
	public class PhysGrounder : MonoBehaviour
	{
		public PhysicsRig physRig;

		public bool isGrounded;

		public bool ungroundedThisFrame;

		public bool ladderCheck;

		public Vector3 groundNormal;

		public Vector3 _totalImpulse;

		public AudioClip feetSkidSlime;

		public AudioClip[] highFallClips;

		public float highFallVolumeMult;

		public PhysicMaterial[] slimeMats;

		private Vector3 _deltaVel;

		private Vector3 _groundVel;

		private Vector3 _lastGroundVel;

		private float _groundMultSum;

		private float _groundAngVel;

		private float _highestImpulse;

		private Collider _groundedCollider;

		private int _count;

		private int _ungroundedFrame;

		private Rigidbody _rb;

		private ManagedAudioPlayer _mapSkid;

		private int collisionLayer;

		public void OnAwake(PhysicsRig phys)
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private void ProcessCollision(Collision c, bool isEnter = false)
		{
		}

		private void HighFallClipSpawn(float volume, float minDistance)
		{
		}

		private void UpdateSkid(float skidMag)
		{
		}

		private bool CheckMat()
		{
			return false;
		}

		public void FeetGrounded(float footballRadius, out Vector3 groundVelocity, out float groundAngVel, out Vector3 skidVelocity, out float skidMag, out Vector3 impulse)
		{
			groundVelocity = default(Vector3);
			groundAngVel = default(float);
			skidVelocity = default(Vector3);
			skidMag = default(float);
			impulse = default(Vector3);
		}
	}
}
