using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Event/vR Graphic Raycaster")]
	public class VRGraphicRaycaster : BaseRaycaster
	{
		public enum BlockingObjects
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}

		public Camera eventCameraOverride;

		protected const int kNoEventMaskSet = -1;

		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics;

		[SerializeField]
		[FormerlySerializedAs("blockingObjects")]
		private BlockingObjects m_BlockingObjects;

		[SerializeField]
		protected LayerMask m_BlockingMask;

		private Canvas m_Canvas;

		private RectTransform m_CanvasRect;

		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		public override int sortOrderPriority => 0;

		public override int renderOrderPriority => 0;

		public bool ignoreReversedGraphics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BlockingObjects blockingObjects
		{
			get
			{
				return default(BlockingObjects);
			}
			set
			{
			}
		}

		private Canvas canvas => null;

		private RectTransform canvasRect => null;

		public override Camera eventCamera => null;

		protected VRGraphicRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}
	}
}
