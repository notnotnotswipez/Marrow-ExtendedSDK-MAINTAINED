using SLZ.Marrow;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BalloonGun : MonoBehaviour
	{
		public Grip triggerGrip;

		public Balloon.BalloonColor nextBalloonColor;

		public Balloon.BalloonColor balloonColor0;

		public Balloon.BalloonColor balloonColor1;

		public Balloon.BalloonColor balloonColor2;

		public Balloon.BalloonColor balloonColor3;

		public GameObject balloonRoot;

		public MeshRenderer[] balloonMesh;

		public Spawnable balloonSpawnable;

		public Spawnable vfxFlareSpawnable;

		public Transform firePointTransform;

		public float balloonJitterDelta;

		public float meshSpinSpeed;

		private Vector3[] balloonMeshOrigin;

		public GunSFX gunSFX;

		public float smoothTime;

		public float minUpdateInterval;

		public float maxUpdateInterval;

		private Vector3[] velocity;

		private Vector3[] targetPos;

		private float[] nextTargetTime;

		[Header("Options")]
		public LayerMask collisionLayers;

		[Tooltip("Effective Range of Raycast")]
		public float effectiveRange;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private Vector3 RandomVector3(float delta)
		{
			return default(Vector3);
		}

		private void Start()
		{
		}

		private void SetBalloonColor()
		{
		}

		private void Fire()
		{
		}
	}
}
