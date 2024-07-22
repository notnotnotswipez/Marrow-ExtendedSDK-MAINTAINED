using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ResetLadder : MonoBehaviour
	{
		public GameObject obj;

		public Rigidbody rb;

		public TimedJointEvents trigger;

		public InteractableHost host;

		private Vector3 objPos;

		private Quaternion objRot;

		public ConfigurableJoint joint;

		public SoftJointLimit lowAngularXLimit;

		public SoftJointLimit highAngularXLimit;

		public Vector3 connectedAnch;

		private ConfigurableJoint newJoint;

		private void Awake()
		{
		}

		[ContextMenu("ResetLadder")]
		public void LadderReset()
		{
		}
	}
}
