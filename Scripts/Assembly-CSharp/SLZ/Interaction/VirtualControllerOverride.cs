using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class VirtualControllerOverride : MonoBehaviour
	{
		public IGrippable host;

		public bool allowSingleHandOverride;

		public bool useTheseSettings;

		public VirtualControllerSettings virtualControllerSettings;

		[Tooltip("Grips that trigger the controller (order determines their priority)")]
		public Grip[] primaryGrips;

		[Tooltip("Grips that prevent the virtual controller override (used to yield to other VC overrides)")]
		public Grip[] ignoreGrips;

		public VirtualControlerPayload inputPayload
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public VirtualControlerPayload outputPayload
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public virtual void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public virtual void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public virtual void OnVirtualControllerEnd()
		{
		}
	}
}
