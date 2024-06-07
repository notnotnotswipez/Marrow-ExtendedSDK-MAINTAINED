using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class VRPhysicsRaycaster : BaseRaycaster
	{
		protected const int kNoEventMaskSet = -1;

		[SerializeField]
		protected LayerMask m_EventMask;

		[SerializeField]
		protected int m_MaxRayIntersections;

		protected int m_LastMaxRayIntersections;

		private RaycastHit[] m_Hits;

		public override Camera eventCamera => null;

		public virtual int depth => 0;

		public int finalEventMask => 0;

		public LayerMask eventMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public int maxRayIntersections
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected VRPhysicsRaycaster()
		{
		}

		protected void ComputeRayAndDistance(PointerEventData eventData, out Ray ray, out float distanceToClipPlane)
		{
			ray = default(Ray);
			distanceToClipPlane = default(float);
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
}
