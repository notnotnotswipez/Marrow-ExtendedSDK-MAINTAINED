using UnityEngine;
using UnityEngine.Events;

namespace SLZ.VFX
{
	public class GenericFrameTimer : MonoBehaviour
	{
		private enum FrameType
		{
			FixedUpdate = 0,
			EndOfFrame = 1
		}

		[SerializeField]
		[Tooltip("Which update to use for timing. Can't be changed in playtime")]
		private FrameType CountingType;

		[SerializeField]
		public int FramesToCount;

		[SerializeField]
		public UnityEvent TimerUp;

		private GenericFrameTimerBase timer;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}
	}
}
