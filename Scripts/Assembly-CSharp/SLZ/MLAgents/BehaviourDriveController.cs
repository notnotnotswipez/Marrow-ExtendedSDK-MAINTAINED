using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BehaviourDriveController : MonoBehaviour
	{
		[Space(10f)]
		[Header("Joint Drive Settings")]
		private float m_FacingDot;

		[HideInInspector]
		public Dictionary<Transform, ArtBodyPart> bodyPartsDict;

		[HideInInspector]
		public List<ArtBodyPart> bodyPartsList;

		private const float k_MaxAngularVelocity = 50f;

		public float maxJointForceLimit;

		public void SetupBodyPart(Transform t)
		{
		}

		public void SetupBodyPart(Transform t, ConfigurableJoint ref_joint)
		{
		}
	}
}
