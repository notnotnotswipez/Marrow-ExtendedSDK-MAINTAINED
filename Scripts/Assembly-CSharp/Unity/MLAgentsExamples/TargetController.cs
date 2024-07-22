using System;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.MLAgentsExamples
{
	public class TargetController : MonoBehaviour
	{
		[Serializable]
		public class TriggerEvent : UnityEvent<Collider>
		{
			public TriggerEvent()
			{
				
			}
		}

		[Serializable]
		public class CollisionEvent : UnityEvent<Collision>
		{
			public CollisionEvent()
			{
				
			}
		}

		[Header("Collider Tag To Detect")]
		public string tagToDetect;

		[Header("Target Placement")]
		public float spawnRadius;

		public bool respawnIfTouched;

		[Header("Target Fell Protection")]
		public bool respawnIfFallsOffPlatform;

		public float fallDistance;

		private Vector3 m_startingPos;

		private Agent m_agentTouching;

		public float targetHeight;

		[Header("Trigger Callbacks")]
		public TriggerEvent onTriggerEnterEvent;

		public TriggerEvent onTriggerStayEvent;

		public TriggerEvent onTriggerExitEvent;

		[Header("Collision Callbacks")]
		public CollisionEvent onCollisionEnterEvent;

		public CollisionEvent onCollisionStayEvent;

		public CollisionEvent onCollisionExitEvent;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void MoveTargetToRandomPosition()
		{
		}

		private void OnCollisionEnter(Collision col)
		{
		}

		private void OnCollisionStay(Collision col)
		{
		}

		private void OnCollisionExit(Collision col)
		{
		}

		private void OnTriggerEnter(Collider col)
		{
		}

		private void OnTriggerStay(Collider col)
		{
		}

		private void OnTriggerExit(Collider col)
		{
		}
	}
}
