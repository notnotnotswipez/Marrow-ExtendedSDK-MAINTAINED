using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class EntityPoseData : ScriptableObject
	{
		[SerializeField]
		public SimpleTransform[] bodyPoses;
	}
}
