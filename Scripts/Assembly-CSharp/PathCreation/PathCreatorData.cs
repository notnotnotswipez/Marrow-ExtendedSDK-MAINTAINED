using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation
{
	[Serializable]
	public class PathCreatorData
	{
		[SerializeField]
		private BezierPath _bezierPath;

		private VertexPath _vertexPath;

		[SerializeField]
		private bool vertexPathUpToDate;

		public float vertexPathMaxAngleError;

		public float vertexPathMinVertexSpacing;

		public bool showTransformTool;

		public bool showPathBounds;

		public bool showPerSegmentBounds;

		public bool displayAnchorPoints;

		public bool displayControlPoints;

		public float bezierHandleScale;

		public bool globalDisplaySettingsFoldout;

		public bool keepConstantHandleSize;

		public bool showNormalsInVertexMode;

		public bool showBezierPathInVertexMode;

		public bool showDisplayOptions;

		public bool showPathOptions;

		public bool showVertexPathDisplayOptions;

		public bool showVertexPathOptions;

		public bool showNormals;

		public bool showNormalsHelpInfo;

		public int tabIndex;

		public VertexPath Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BezierPath BezPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BezierPath bezierPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action bezierOrVertexPathModified
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

		public event Action bezierCreated
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

		public void Initialize(bool defaultIs2D)
		{
		}

		public void ResetBezierPath(Vector3 centre, bool defaultIs2D = false)
		{
		}

		private void CreateBezier(Vector3 centre, bool defaultIs2D = false)
		{
		}

		public VertexPath GetVertexPath(Transform transform)
		{
			return null;
		}

		public void PathTransformed()
		{
		}

		public void VertexPathSettingsChanged()
		{
		}

		public void PathModifiedByUndo()
		{
		}

		private void BezierPathEdited()
		{
		}
	}
}
