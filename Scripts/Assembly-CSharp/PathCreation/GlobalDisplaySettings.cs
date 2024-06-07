using UnityEngine;

namespace PathCreation
{
	public class GlobalDisplaySettings : ScriptableObject
	{
		public enum HandleType
		{
			Sphere = 0,
			Circle = 1,
			Square = 2
		}

		[Header("Appearance")]
		public float anchorSize;

		public float controlSize;

		[Tooltip("Should the path still be drawn when behind objects in the scene?")]
		public bool visibleBehindObjects;

		[Tooltip("Should the path be drawn even when the path object is not selected?")]
		public bool visibleWhenNotSelected;

		[Tooltip("If true, control points will be hidden when the control point mode is set to automatic. Otherwise they will inactive, but still visible.")]
		public bool hideAutoControls;

		public HandleType anchorShape;

		public HandleType controlShape;

		[Header("Anchor Colours")]
		public Color anchor;

		public Color anchorHighlighted;

		public Color anchorSelected;

		[Header("Control Colours")]
		public Color control;

		public Color controlHighlighted;

		public Color controlSelected;

		public Color handleDisabled;

		public Color controlLine;

		[Header("Bezier Path Colours")]
		public Color bezierPath;

		public Color highlightedPath;

		public Color bounds;

		public Color segmentBounds;

		[Header("Vertex Path Colours")]
		public Color vertexPath;

		[Header("Normals")]
		public Color normals;

		[Range(0f, 1f)]
		public float normalsLength;
	}
}
