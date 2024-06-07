using UnityEngine;

namespace SLZ.MLAgents
{
	public class PatrolObjective : TaskObjective
	{
		public SphereCollider triggerCollider;

		private float forward_align;

		private GameObject currentObj;

		public override void Init()
		{
		}

		private void MakeTriggerZone()
		{
		}

		private new void Awake()
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected override void SubmitTaskInfo(GameObject gameObj)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private new void HandleAttemptTimer()
		{
		}

		protected override void FixedUpdate()
		{
		}
	}
}
