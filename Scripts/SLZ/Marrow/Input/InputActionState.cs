using System;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000154 RID: 340
	public class InputActionState
	{
		// Token: 0x0400089E RID: 2206
		public bool isDeviceConnectedHmd;

		// Token: 0x0400089F RID: 2207
		public bool isDeviceTrackingHmd;

		// Token: 0x040008A0 RID: 2208
		public Vector3 devicePositionHmd;

		// Token: 0x040008A1 RID: 2209
		public Quaternion deviceRotationHmd;

		// Token: 0x040008A2 RID: 2210
		public Vector3 deviceVelocityHmd;

		// Token: 0x040008A3 RID: 2211
		public Vector3 deviceAngularVelocityHmd;

		// Token: 0x040008A4 RID: 2212
		public double deviceUpdateTimeHmd;

		// Token: 0x040008A5 RID: 2213
		public double lastDeviceUpdateTimeHmd;

		// Token: 0x040008A6 RID: 2214
		public bool isDeviceConnectedL;

		// Token: 0x040008A7 RID: 2215
		public bool isDeviceTrackingL;

		// Token: 0x040008A8 RID: 2216
		public Vector3 devicePositionL;

		// Token: 0x040008A9 RID: 2217
		public Quaternion deviceRotationL;

		// Token: 0x040008AA RID: 2218
		public Vector3 deviceVelocityL;

		// Token: 0x040008AB RID: 2219
		public Vector3 deviceAngularVelocityL;

		// Token: 0x040008AC RID: 2220
		public double deviceUpdateTimeL;

		// Token: 0x040008AD RID: 2221
		public double lastDeviceUpdateTimeL;

		// Token: 0x040008AE RID: 2222
		public bool isDeviceConnectedR;

		// Token: 0x040008AF RID: 2223
		public bool isDeviceTrackingR;

		// Token: 0x040008B0 RID: 2224
		public Vector3 devicePositionR;

		// Token: 0x040008B1 RID: 2225
		public Quaternion deviceRotationR;

		// Token: 0x040008B2 RID: 2226
		public Vector3 deviceVelocityR;

		// Token: 0x040008B3 RID: 2227
		public Vector3 deviceAngularVelocityR;

		// Token: 0x040008B4 RID: 2228
		public double deviceUpdateTimeR;

		// Token: 0x040008B5 RID: 2229
		public double lastDeviceUpdateTimeR;

		// Token: 0x040008B6 RID: 2230
		public Vector2 joystick2DAxisL;

		// Token: 0x040008B7 RID: 2231
		public Vector2 joystick2DAxisR;

		// Token: 0x040008B8 RID: 2232
		public bool joystickButtonL;

		// Token: 0x040008B9 RID: 2233
		public bool joystickButtonUpL;

		// Token: 0x040008BA RID: 2234
		public bool joystickButtonDownL;

		// Token: 0x040008BB RID: 2235
		public bool joystickButtonR;

		// Token: 0x040008BC RID: 2236
		public bool joystickButtonUpR;

		// Token: 0x040008BD RID: 2237
		public bool joystickButtonDownR;

		// Token: 0x040008BE RID: 2238
		public bool joystickTouchL;

		// Token: 0x040008BF RID: 2239
		public bool joystickTouchR;

		// Token: 0x040008C0 RID: 2240
		public float triggerL;

		// Token: 0x040008C1 RID: 2241
		public float triggerR;

		// Token: 0x040008C2 RID: 2242
		public bool triggerButtonL;

		// Token: 0x040008C3 RID: 2243
		public bool triggerButtonUpL;

		// Token: 0x040008C4 RID: 2244
		public bool triggerButtonDownL;

		// Token: 0x040008C5 RID: 2245
		public bool triggerButtonR;

		// Token: 0x040008C6 RID: 2246
		public bool triggerButtonUpR;

		// Token: 0x040008C7 RID: 2247
		public bool triggerButtonDownR;

		// Token: 0x040008C8 RID: 2248
		public bool triggerTouchedL;

		// Token: 0x040008C9 RID: 2249
		public bool triggerTouchedR;

		// Token: 0x040008CA RID: 2250
		public bool gripButtonL;

		// Token: 0x040008CB RID: 2251
		public bool gripButtonUpL;

		// Token: 0x040008CC RID: 2252
		public bool gripButtonDownL;

		// Token: 0x040008CD RID: 2253
		public bool gripButtonR;

		// Token: 0x040008CE RID: 2254
		public bool gripButtonUpR;

		// Token: 0x040008CF RID: 2255
		public bool gripButtonDownR;

		// Token: 0x040008D0 RID: 2256
		public float gripL;

		// Token: 0x040008D1 RID: 2257
		public float gripForceL;

		// Token: 0x040008D2 RID: 2258
		public float gripVelocityL;

		// Token: 0x040008D3 RID: 2259
		public float gripR;

		// Token: 0x040008D4 RID: 2260
		public float gripForceR;

		// Token: 0x040008D5 RID: 2261
		public float gripVelocityR;

		// Token: 0x040008D6 RID: 2262
		public bool primaryButtonL;

		// Token: 0x040008D7 RID: 2263
		public bool primaryButtonR;

		// Token: 0x040008D8 RID: 2264
		public bool primaryButtonUpL;

		// Token: 0x040008D9 RID: 2265
		public bool primaryButtonUpR;

		// Token: 0x040008DA RID: 2266
		public bool primaryButtonDownL;

		// Token: 0x040008DB RID: 2267
		public bool primaryButtonDownR;

		// Token: 0x040008DC RID: 2268
		public bool primaryTouchL;

		// Token: 0x040008DD RID: 2269
		public bool primaryTouchR;

		// Token: 0x040008DE RID: 2270
		public bool secondaryButtonL;

		// Token: 0x040008DF RID: 2271
		public bool secondaryButtonR;

		// Token: 0x040008E0 RID: 2272
		public bool secondaryButtonUpL;

		// Token: 0x040008E1 RID: 2273
		public bool secondaryButtonUpR;

		// Token: 0x040008E2 RID: 2274
		public bool secondaryButtonDownL;

		// Token: 0x040008E3 RID: 2275
		public bool secondaryButtonDownR;

		// Token: 0x040008E4 RID: 2276
		public bool secondaryTouchL;

		// Token: 0x040008E5 RID: 2277
		public bool secondaryTouchR;

		// Token: 0x040008E6 RID: 2278
		public bool thumbTouchL;

		// Token: 0x040008E7 RID: 2279
		public bool thumbTouchR;

		// Token: 0x040008E8 RID: 2280
		public float ringFingerL;

		// Token: 0x040008E9 RID: 2281
		public float indexFingerL;

		// Token: 0x040008EA RID: 2282
		public float pinkyFingerL;

		// Token: 0x040008EB RID: 2283
		public float middleFingerL;

		// Token: 0x040008EC RID: 2284
		public float thumbFingerL;

		// Token: 0x040008ED RID: 2285
		public float ringFingerR;

		// Token: 0x040008EE RID: 2286
		public float indexFingerR;

		// Token: 0x040008EF RID: 2287
		public float pinkyFingerR;

		// Token: 0x040008F0 RID: 2288
		public float middleFingerR;

		// Token: 0x040008F1 RID: 2289
		public float thumbFingerR;
	}
}
