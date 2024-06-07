using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SlideVirtualController : VirtualControllerOverride, IGunSlideable
	{
		public float pullDistance;

		protected float speedLimit;

		[Header("Transform that is used as a guide for the slide (this transform shouldn't move inside the host)")]
		public Transform trackTransform;

		public Vector3 slideDirectionInTrack;

		protected bool _isFrozen;

		protected float _slideDistance;

		protected Vector3 _lastContDisp;

		protected Vector3 _slideDirectionInSecGripHandle;

		protected bool _slideIsPulled;

		protected float _lastDeltaMag;

		public Action OnSlideGrabbed
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnSlideReleased
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<float> OnSlideUpdate
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnSlidePulled
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnSlideReturned
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected void Reset()
		{
		}

		public void Freeze()
		{
		}

		public void UnFreeze()
		{
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload p)
		{
		}

		public override void OnVirtualControllerEnd()
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload p)
		{
		}
	}
}
