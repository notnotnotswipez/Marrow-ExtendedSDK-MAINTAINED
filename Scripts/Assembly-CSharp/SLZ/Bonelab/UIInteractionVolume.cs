using System.Collections.Generic;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIInteractionVolume : Grip
	{
		private bool m_IsActivated;

		private Transform m_CursorTransform;

		public PreferencesPanelView preferencesPanelView;

		public PageElementView cursorStart;

		public PageElementView cursorEnd;

		public PageElementView cursorMid;

		private Vector3 m_StartCursorVel;

		private Vector3 m_EndCursorVel;

		private Vector3 m_MidCursorVel;

		private Vector3 m_RayLookDir;

		private Vector3 m_RayLookVel;

		private Vector3 m_CursorHeight;

		private Plane m_StartUIPlane;

		private int m_HandCount;

		private Hand m_Hand;

		private List<Hand> m_Hands;

		private bool m_IsTriggeredDown;

		private bool m_IsTrigger;

		private void Activate(Hand hand)
		{
		}

		private void Deactivate()
		{
		}

		protected override void Awake()
		{
		}

		public void ShowCursor()
		{
		}

		public void HideCursor()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		protected void Update()
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnDetachedFromHand(Hand hand)
		{
		}

		public override void OnFarHandHoverBegin(Hand hand)
		{
		}

		public override void OnFarHandHoverEnd(Hand hand)
		{
		}

		public override void OnFarHandHoverUpdate(Hand hand)
		{
		}
	}
}
