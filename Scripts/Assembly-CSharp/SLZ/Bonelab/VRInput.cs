using System.Collections.Generic;
using SLZ.Marrow;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class VRInput : BaseInput
	{
		public struct TrackedInput
		{
			public int id;

			public TouchPhase phase;

			public bool isPressed;

			public bool isReleased;

			public Vector2 position;

			public Hand hand;

		}

		public List<TrackedInput> trackedInputs;

		public override string compositionString => null;

		public override IMECompositionMode imeCompositionMode
		{
			get
			{
				return default(IMECompositionMode);
			}
			set
			{
			}
		}

		public override Vector2 compositionCursorPos
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public override bool mousePresent => false;

		public override Vector2 mousePosition => default(Vector2);

		public override Vector2 mouseScrollDelta => default(Vector2);

		public override bool touchSupported => false;

		public override int touchCount => 0;

		public override bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public override bool GetMouseButtonUp(int button)
		{
			return false;
		}

		public override bool GetMouseButton(int button)
		{
			return false;
		}

		public override Touch GetTouch(int index)
		{
			return default(Touch);
		}

		public override float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		public override bool GetButtonDown(string buttonName)
		{
			return false;
		}
	}
}
