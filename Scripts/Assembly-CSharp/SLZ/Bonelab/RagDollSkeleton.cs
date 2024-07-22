using System;
using System.Collections.Generic;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RagDollSkeleton : MonoBehaviour
	{
		[SerializeField]
		private List<ConfigurableJointInfo> _skeleJointInfos;

		[SerializeField]
		private List<MarrowBody> _skeleBodyAs;

		[SerializeField]
		private List<MarrowBody> _skeleBodyBs;

		[SerializeField]
		private EntityPoseData data;

		public MarrowBody[] _allBodies;

		[SerializeField]
		private bool _isPoseMode;

		public Action<MarrowJoint, int> onJointBreak;

		public Action<GameObject> onBoneBreak;

		private Dictionary<MarrowJoint, int> _jointIndex;

		public List<MarrowJoint> builtJoints;

		private Action<ObjectDestructible> _onDestroy;

		public Action onJointsBuilt;

		private void Start()
		{
		}

		private void BuildJoints()
		{
		}

		private void OnMarrowJointBreak(MarrowJoint joint)
		{
		}

		private void OnBoneDestruction(ObjectDestructible destructible)
		{
		}
	}
}
