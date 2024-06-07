using System;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class FollowObjective : TaskObjective
	{
		public SphereCollider triggerCollider;

		public FollowTaskMover taskMover;

		public float startDelay;

		private GameObject currentObj;

		public bool slowdownHelper;

		public float slowdownRate;

		public bool isSlowing;

		private StatsRecorder statsRecorder;

		public bool trackParentObject;

		private Rigidbody parentRb;

		private Vector3 lastParentPos;

		private bool hasLookedForParent;

		private float parentSpeed;

		public event Action<float> UpdateSpeed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<float> UpdateGoalRadius
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<float> UpdateProxRadius
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void SetEnvParams()
		{
		}

		public override void Init()
		{
		}

		private void MakeTriggerZone()
		{
		}

		protected new void Awake()
		{
		}

		protected override void SubmitTaskInfo(GameObject gameObj)
		{
		}

		public void UpdateSpeedExternal(float speed)
		{
		}

		[ContextMenu("Goal Radius Test")]
		public void GoalRadiusTest()
		{
		}

		[ContextMenu("Prox Radius Test")]
		public void ProxRadiusTest()
		{
		}

		public void SetGoalRadius(float newGoalRadius)
		{
		}

		public void SetProxRadius(float newProxRadius)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void HandleSlowing()
		{
		}

		private void TrackParentObject()
		{
		}

		protected override void FixedUpdate()
		{
		}
	}
}
