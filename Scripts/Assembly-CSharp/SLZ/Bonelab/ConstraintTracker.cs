using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ConstraintTracker : MonoBehaviour
	{
		public MarrowJoint joint;

		public ConstraintTracker otherTracker;

		public Transform attachPoint;

		public LineRenderer lineRenderer;

		public bool isHost;

		public void SetupTracker(MarrowJoint j, ConstraintTracker oT, Constrainer s, int i, Constrainer.ConstraintMode m, Transform aP, LineRenderer lR)
		{
		}

		public void DeleteConstraint()
		{
		}

		private void Update()
		{
		}

		public void UpdateLines()
		{
		}
	}
}
