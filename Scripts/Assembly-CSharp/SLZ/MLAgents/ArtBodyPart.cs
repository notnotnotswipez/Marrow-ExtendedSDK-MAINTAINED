using System;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.MLAgents
{
	[Serializable]
	public class ArtBodyPart
	{
		[Header("Body Part Info")]
		[Space(10f)]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		[HideInInspector]
		public Vector3 startingPos;

		[HideInInspector]
		public Quaternion startingRot;

		[Header("Ground & Target Contact")]
		[Space(10f)]
		public GroundContact groundContact;

		public TargetContact targetContact;

		[HideInInspector]
		[FormerlySerializedAs("thisJDController")]
		public BehaviourDriveController thisJdController;

		[Space(10f)]
		[Header("Current Joint Settings")]
		public Vector3 currentEularJointRotation;

		[HideInInspector]
		public float currentStrength;

		public float currentXNormalizedRot;

		public float currentYNormalizedRot;

		public float currentZNormalizedRot;

		public void Reset(ArtBodyPart bp)
		{
		}

		public void SetArtTargetRotation(ref Transform transform, float x, float y, float z, float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
		{
		}
	}
}
