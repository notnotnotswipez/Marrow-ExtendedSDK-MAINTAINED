using System;
using UnityEngine;

namespace SLZ.Marrow.Input.Oculus
{
	// Token: 0x0200016C RID: 364
	[CreateAssetMenu(fileName = "OculusXRConfiguration", menuName = "Marrow/Config/OculusXRConfiguration")]
	public class OculusXRConfiguration : ScriptableObject
	{
		// Token: 0x040009DE RID: 2526
		[Tooltip("Defines the current tracking origin type.")]
		[Header("Tracking")]
		public OculusXRConfiguration.TrackingOrigin trackingOriginType;

		// Token: 0x040009DF RID: 2527
		[Tooltip("If true, the distance between the user's eyes will affect the position of each OVRCameraRig's cameras.")]
		public bool useIPDInPositionTracking;

		// Token: 0x040009E0 RID: 2528
		[Tooltip("If true, each scene load will cause the head pose to reset. This function only works on Rift.")]
		public bool resetTrackerOnLoad;

		// Token: 0x040009E1 RID: 2529
		[Tooltip("If true, the Reset View in the universal menu will cause the pose to be reset in PC VR. This should generally be enabled for applications with a stationary position in the virtual world and will allow the View Reset command to place the person back to a predefined location (such as a cockpit seat). Set this to false if you have a locomotion system because resetting the view would effectively teleport the player to potentially invalid locations.")]
		public bool allowRecenter;

		// Token: 0x040009E2 RID: 2530
		[Tooltip("Late latching is a feature that can reduce rendered head/controller latency by a substantial amount. Before enabling, be sure to go over the documentation to ensure that the feature is used correctly. This feature must also be enabled through the Oculus XR Plugin settings.")]
		public bool lateLatching;

		// Token: 0x040009E3 RID: 2531
		[Tooltip("The target display frequency to set")]
		[Header("Display")]
		public OculusXRConfiguration.DisplayFrequencies targetDisplayFrequency;

		// Token: 0x0200028B RID: 651
		public enum TrackingOrigin
		{
			// Token: 0x04000FF1 RID: 4081
			EyeLevel,
			// Token: 0x04000FF2 RID: 4082
			FloorLevel = 0,
			// Token: 0x04000FF3 RID: 4083
			Stage = 0
		}

		// Token: 0x0200028C RID: 652
		public enum DisplayFrequencies
		{
			// Token: 0x04000FF5 RID: 4085
			F72 = 72,
			// Token: 0x04000FF6 RID: 4086
			F80 = 80,
			// Token: 0x04000FF7 RID: 4087
			F90 = 90,
			// Token: 0x04000FF8 RID: 4088
			F120 = 120
		}
	}
}
