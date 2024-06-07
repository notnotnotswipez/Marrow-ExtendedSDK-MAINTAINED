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

		[Tooltip("Which update to use for timing. Can't be changed in playtime")]
		[SerializeField]
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
