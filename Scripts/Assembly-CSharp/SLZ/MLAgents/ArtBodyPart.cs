using System;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.MLAgents
{
	[Serializable]
	public class ArtBodyPart
	{
		[Space(10f)]
		[Header("Body Part Info")]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		[HideInInspector]
		public Vector3 startingPos;

		[HideInInspector]
		public Quaternion startingRot;

		[Space(10f)]
		[Header("Ground & Target Contact")]
		public GroundContact groundContact;

		public TargetContact targetContact;

		[HideInInspector]
		[FormerlySerializedAs("thisJDController")]
		public BehaviourDriveController thisJdController;

		[Header("Current Joint Settings")]
		[Space(10f)]
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
