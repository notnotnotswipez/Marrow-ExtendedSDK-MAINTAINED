using System;
using System.Collections;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Void : BonelabInternalGameControl
	{
		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		private void OnLevelLoad()
		{
		}

		[ContextMenu("StartMoveSequence")]
		public void StartMoveSequence()
		{
		}

		private IEnumerator MoveFloorSequence()
		{
			return null;
		}

		private IEnumerator Accelerate(AnimationCurve curve)
		{
			return null;
		}

		private IEnumerator Decelerate(AnimationCurve curve)
		{
			return null;
		}

		private Vector3 CalcuateStoppingPoint(AnimationCurve curve)
		{
			return default(Vector3);
		}

		private IEnumerator EnviormentTreadmill()
		{
			return null;
		}

		private IEnumerator TreadmillMatchSeams()
		{
			return null;
		}

		public GameControl_Void()
		{
		}

		public MarrowEntity TaxiEntity;

		public Rigidbody taxiRb;

		public ConfigurableJoint taxiConfigJoint;

		public ConfigurableJoint rearLeftWheelConfigJoint;

		public ConfigurableJoint rearRightWheelConfigJoint;

		public float maxThrottle;

		public float startLength;

		public float driveLength;

		public float endLength;

		public AnimationCurve taxiStartCurve;

		public AnimationCurve taxiEndCurve;

		public AnimationCurve linearStartCurve;

		public AnimationCurve linearEndCurve;

		public AnimationCurve matLerpCurve;

		public Vector2 directionTile;

		public Renderer[] floorTiles;

		private Material[] floorMats;

		private Vector3 cabStartPos;

		private IEnumerator moveCoroutine;

		private IEnumerator throttleCoroutine;

		private IEnumerator treadmillCoroutine;

		private float topVelocity;

		public LayerMask teleportLayers;

		public GameObject staticLampRoot;

		public GameObject forwardLampRoot;

		public GameObject rearLampRoot;

		public GameObject lampPost;

		public int numberOfLampPosts;

		public float minMaxPost;

		public float interval;

		public List<GameObject> spawnedPosts;

		public List<GameObject> spawnedPostsFront;

		public List<GameObject> spawnedPostsRear;

		private int loopCount;
	}
}
