using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace SLZ.VRMK
{
	[Serializable]
	public class IKSolverTrigonometricSlz : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : Bone
		{
			private Quaternion targetToLocalSpace;

			private Vector3 defaultLocalBendNormal;

			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}
		}

		public Transform target;

		[Range(0f, 1f)]
		public float IKRotationWeight;

		public Quaternion IKRotation;

		public Vector3 bendNormal;

		public TrigonometricBone bone1;

		public TrigonometricBone bone2;

		public TrigonometricBone bone3;

		protected Vector3 weightIKPosition;

		protected bool directHierarchy;

		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		public void SetBendPlaneToCurrent()
		{
		}

		public void SetIKRotation(Quaternion rotation)
		{
		}

		public void SetIKRotationWeight(float weight)
		{
		}

		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		public float GetIKRotationWeight()
		{
			return 0f;
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		public override bool IsValid(ref string message)
		{
			return false;
		}

		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return false;
		}

		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		protected override void OnInitiate()
		{
		}

		private bool IsDirectHierarchy()
		{
			return false;
		}

		private void InitiateBones()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected virtual void OnInitiateVirtual()
		{
		}

		protected virtual void OnUpdateVirtual()
		{
		}

		protected virtual void OnPostSolveVirtual()
		{
		}

		protected Vector3 GetBendDirection(Vector3 direction, Vector3 bendNormal)
		{
			return default(Vector3);
		}
	}
}
