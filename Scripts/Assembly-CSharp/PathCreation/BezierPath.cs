using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation
{
	[Serializable]
	[DefaultMember("Item")]
	public class BezierPath
	{
		public enum ControlMode
		{
			Aligned = 0,
			Mirrored = 1,
			Free = 2,
			Automatic = 3
		}

		[HideInInspector]
		[SerializeField]
		private List<Vector3> points;

		[HideInInspector]
		[SerializeField]
		private bool isClosed;

		[HideInInspector]
		[SerializeField]
		private PathSpace space;

		[HideInInspector]
		[SerializeField]
		private ControlMode controlMode;

		[HideInInspector]
		[SerializeField]
		private float autoControlLength;

		[HideInInspector]
		[SerializeField]
		private bool boundsUpToDate;

		[HideInInspector]
		[SerializeField]
		private Bounds bounds;

		[SerializeField]
		[HideInInspector]
		private List<float> perAnchorNormalsAngle;

		[HideInInspector]
		[SerializeField]
		private float globalNormalsAngle;

		[HideInInspector]
		[SerializeField]
		private bool flipNormals;

		public Vector3 Item => default(Vector3);

		public int NumPoints => 0;

		public int NumAnchorPoints => 0;

		public int NumSegments => 0;

		public PathSpace Space
		{
			get
			{
				return default(PathSpace);
			}
			set
			{
			}
		}

		public bool IsClosed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ControlMode ControlPointMode
		{
			get
			{
				return default(ControlMode);
			}
			set
			{
			}
		}

		public float AutoControlLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool FlipNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float GlobalNormalsAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Bounds PathBounds => default(Bounds);

		public event Action OnModified
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public BezierPath(Vector3 centre, bool isClosed = false, PathSpace space = PathSpace.xyz)
		{
		}

		public BezierPath(IEnumerable<Vector3> points, bool isClosed = false, PathSpace space = PathSpace.xyz)
		{
		}

		public BezierPath(IEnumerable<Vector2> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
		{
		}

		public BezierPath(IEnumerable<Transform> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
		{
		}

		public BezierPath(IEnumerable<Vector2> points, PathSpace space = PathSpace.xyz, bool isClosed = false)
		{
		}

		public Vector3 GetPoint(int i)
		{
			return default(Vector3);
		}

		public void SetPoint(int i, Vector3 localPosition, bool suppressPathModifiedEvent = false)
		{
		}

		public void AddSegmentToEnd(Vector3 anchorPos)
		{
		}

		public void AddSegmentToStart(Vector3 anchorPos)
		{
		}

		public void SplitSegment(Vector3 anchorPos, int segmentIndex, float splitTime)
		{
		}

		public void DeleteAllOtherAnchors(int keepIndex)
		{
		}

		public void DeleteSegment(int anchorIndex)
		{
		}

		public Vector3[] GetPointsInSegment(int segmentIndex)
		{
			return null;
		}

		public void MovePoint(int i, Vector3 pointPos, bool suppressPathModifiedEvent = false)
		{
		}

		public Bounds CalculateBoundsWithTransform(Transform transform)
		{
			return default(Bounds);
		}

		public float GetAnchorNormalAngle(int anchorIndex)
		{
			return 0f;
		}

		public void SetAnchorNormalAngle(int anchorIndex, float angle)
		{
		}

		public void ResetNormalAngles()
		{
		}

		private void UpdateBounds()
		{
		}

		private void AutoSetAllAffectedControlPoints(int updatedAnchorIndex)
		{
		}

		private void AutoSetAllControlPoints()
		{
		}

		private void AutoSetAnchorControlPoints(int anchorIndex)
		{
		}

		private void AutoSetStartAndEndControls()
		{
		}

		private void UpdateToNewPathSpace(PathSpace previousSpace)
		{
		}

		private void UpdateClosedState()
		{
		}

		private int LoopIndex(int i)
		{
			return 0;
		}

		public void NotifyPathModified()
		{
		}
	}
}
