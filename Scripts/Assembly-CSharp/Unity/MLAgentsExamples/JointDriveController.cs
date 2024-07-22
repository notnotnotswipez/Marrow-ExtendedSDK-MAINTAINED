using System.Collections.Generic;
using UnityEngine;

namespace Unity.MLAgentsExamples
{
	public class JointDriveController : MonoBehaviour
	{
		[Header("Joint Drive Settings")]
		[Space(10f)]
		public float maxJointSpring;

		public float jointDampen;

		public float maxJointForceLimit;

		private float m_FacingDot;

		[HideInInspector]
		public Dictionary<Transform, BodyPart> bodyPartsDict;

		[HideInInspector]
		public List<BodyPart> bodyPartsList;

		private const float k_MaxAngularVelocity = 50f;

		public void SetupBodyPart(Transform t)
		{
		}

		public void GetCurrentJointForces()
		{
		}
	}
}
