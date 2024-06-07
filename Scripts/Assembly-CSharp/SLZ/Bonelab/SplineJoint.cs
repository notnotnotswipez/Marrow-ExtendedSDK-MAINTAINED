using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SplineMesh;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineJoint : MonoBehaviour
	{
		public Dictionary<int, Action<SplineBody>> _segmentCollisionEvents;

		public List<SplineEntity> entities;

		private List<SplineBody> _bodies;

		private HashSet<SplineEntity> _addedEntities;

		public Spline spline;

		public int samplesPerSegment;

		public float minimumUpdateMovement;

		private float _minimumUpdateMovementSqr;

		private List<CurveSample> _samples;

		private List<CurveSegment> _segments;

		private bool _isLoop;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public void AddSegmentEventTrigger(int segmentIndex, Action<SplineBody> callback)
		{
		}

		public void RemoveSegmentEventTrigger(int segmentIndex, Action<SplineBody> callback)
		{
		}

		public CurveSample GetSample(int idx)
		{
			return default(CurveSample);
		}

		public int GetSampleIdxByDistance(float distance)
		{
			return 0;
		}

		public static float GetSphereIntersection(Vector3 point, Vector3 ray, Vector3 spherePoint, float radius)
		{
			return 0f;
		}

		public void AddEntity(SplineEntity entity)
		{
		}

		public void RemoveEntity(SplineEntity entity)
		{
		}

		public void UpdatePath()
		{
		}

		public float GetDistanceInSpline(SplineBody sBody)
		{
			return 0f;
		}

		public void BuildPolyPath()
		{
		}

		private int Mod(int i, int max)
		{
			return 0;
		}

		public SimpleTransform GetSegmentTransformAtIndex(int segmentIndex)
		{
			return default(SimpleTransform);
		}

		public int GetNearestSegmentIndex(Vector3 worldPosition)
		{
			return 0;
		}

		private (Vector3, Vector3) GetClosestSegmentFrom(Vector3 position, Vector3 disp, float distance, int lastIdx)
		{
			return default((Vector3, Vector3));
		}

		private int GetDirection(Vector3 direction, int lastIdx)
		{
			return 0;
		}

		private CurveSample GetSample(Vector3 position, ref int lastIdx, Vector3? direction = null)
		{
			return default(CurveSample);
		}

		private void ConfigureJoint(ConfigurableJoint joint, SplineBody sBody, Vector3 anchor, Vector3 connectedAnchor)
		{
		}
	}
}
