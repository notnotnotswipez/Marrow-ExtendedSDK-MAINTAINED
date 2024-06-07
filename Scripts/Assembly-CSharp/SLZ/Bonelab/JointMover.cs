using UnityEngine;

namespace SLZ.Bonelab
{
	public class JointMover : MonoBehaviour
	{
		[SerializeField]
		private Transform startTrans;

		[SerializeField]
		private Transform endTrans;

		[SerializeField]
		private float duration;

		[SerializeField]
		private float lerpVal;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private GameObject anchorObj;

		public bool isMovingOut;

		public float maxTime;

		private float lastSwitchTime;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CreateAnchorObject()
		{
		}
	}
}
