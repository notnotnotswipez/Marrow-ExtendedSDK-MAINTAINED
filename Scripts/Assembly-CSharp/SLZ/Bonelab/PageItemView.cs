using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PageItemView : MonoBehaviour, IPopUpElementable
	{
		public enum SegmentType
		{
			WHOLE = 0,
			HALF = 1,
			THIRD = 2,
			QUATER = 3,
			EIGHTH = 4
		}

		[Header("Options")]
		[ColorUsage(true, true)]
		public Color highlightColor1;

		[ColorUsage(true, true)]
		public Color highlightColor2;

		[ColorUsage(true, true)]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		[Header("References")]
		public HighlightUI wholeElement;

		public HighlightUI halfElement;

		public HighlightUI thridElement;

		public HighlightUI quaterElement;

		public HighlightUI eighthElement;

		public HighlightUI lineElement;

		public HighlightUI indicatorElement;

		public HighlightUI arrowReturnElement;

		public HighlightUI arrowSubElement;

		public GameObject icon;

		public TextMeshProUGUI textMesh;

		private SegmentType m_SegmentType;

		private HighlightUI[] m_Elements;

		private HighlightUI[] m_SegmentElements;

		[HideInInspector]
		public MaterialPropertyBlock propBlock;

		private float m_Angle;

		private PageItem m_Data;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		public bool IsSelected(Vector2 direction)
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void EnableCursor()
		{
		}

		public void DisableCursor()
		{
		}

		public void EnableCursor(float duration)
		{
		}

		public void DisableCursor(float duration)
		{
		}

		public void Show()
		{
		}

		public void Show(float duration)
		{
		}

		public void Hide()
		{
		}

		public void Hide(float duration)
		{
		}

		public void Render(PageItem data, SegmentType type)
		{
		}

		public void Trigger()
		{
		}
	}
}
