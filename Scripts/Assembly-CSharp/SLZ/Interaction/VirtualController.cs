using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	[Serializable]
	public class VirtualController
	{
		private const float softLimitArmLengths = 0.18f;

		private const float hardLimitArmLengths = 0.58f;

		private const float softLimitDegrees = 16f;

		private const float hardLimitDegrees = 142f;

		private float _twistWindup;

		[Header("Virtual Controller Settings")]
		public VirtualControllerSettings defaultSettings;

		private SimpleTransform _hostOffset;

		private float _artificialDelta;

		private float _artDelVelocity;

		private float _artificialDeltaAng;

		private float _artDelAngVelocity;

		[HideInInspector]
		public SimpleTransform overrideVCTransform;

		public Action<SimpleTransform> OnVirtualControllerSolve;

		private static float targRotDeltaSpeed;

		private Quaternion _priLastTargRotDelta;

		private Quaternion _secLastTargRotDelta;

		private bool _priSnapshot;

		private bool _secSnapshot;

		private bool _isDoubleVCFirstPass;

		private bool _isSingleVCFirstPass;

		private HandGripPair _priPair;

		private HandGripPair _secPair;

		private bool _hasDoubleVCBeenCalled;

		private bool _hasSingleVCBeenCalled;

		private VirtualControlerPayload _vcPayload;

		private Dictionary<Grip, VirtualControllerOverride> _vcOverrides;

		private VirtualControllerOverride _staticVCOverride;

		private VirtualControllerOverride _lastVCOverride;

		private SimpleTransform _lastBlendTransform;

		private Dictionary<Hand, float> _desyncTime;

		private Quaternion _priLocalDelta;

		private Quaternion _secLocalDelta;

		private Quaternion _lastPriContHandleRot;

		private Quaternion _lastSecContHandle;

		private SimpleTransform _lastVCTransform;

		private bool _twistInverted;

		public VirtualControllerSettings Settings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<HandGripPair> HandGripPairs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public void AttachPair(Hand hand, Grip grip)
		{
		}

		public void DetachPair(Hand hand)
		{
		}

		private bool CheckHandDesync(HandGripPair pair, SimpleTransform contHandle, SimpleTransform rigHandle)
		{
			return false;
		}

		public bool FetchGrips(out HandGripPair primary)
		{
			primary = default(HandGripPair);
			return false;
		}

		public bool FetchGrips(out HandGripPair primary, out HandGripPair secondary)
		{
			primary = default(HandGripPair);
			secondary = default(HandGripPair);
			return false;
		}

		public void AddVCOverride(Grip grip, VirtualControllerOverride vcOverride)
		{
		}

		public void RemoveVCOverride(Grip grip, VirtualControllerOverride vcOverride)
		{
		}

		private bool GetVirtualControllerOverride(Grip primary, Grip secondary, out VirtualControllerOverride vcOverride)
		{
			vcOverride = null;
			return false;
		}

		private bool ContainsVirtualControllerOverride(Grip primary)
		{
			return false;
		}

		private bool GetVirtualControllerOverride(Grip primary, out VirtualControllerOverride vcOverride)
		{
			vcOverride = null;
			return false;
		}

		public void CalcBlendOffset(HandGripPair pair)
		{
		}

		public SimpleTransform HandleBlendOffset(bool isFirstPass, bool isSingleHanded, SimpleTransform vcInWorld, SimpleTransform rigInHost, out float rotDelta)
		{
			rotDelta = default(float);
			return default(SimpleTransform);
		}

		public void BlendTargetRotationOffset(bool isOverrideBlend = false, float overrideRotDelta = 0f)
		{
		}

		public static Quaternion SynthesizeRotation(Vector3 right, Vector3 up)
		{
			return default(Quaternion);
		}

		private void DrawVC(SimpleTransform rigTransform, SimpleTransform priTarget, SimpleTransform secTarget, Color color, string text, int offset)
		{
		}

		public void Solve()
		{
		}
	}
}
