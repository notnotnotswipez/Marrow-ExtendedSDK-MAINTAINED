using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PalletJack : MonoBehaviour
	{
		[SerializeField]
		private ConfigurableJoint _pivotjnt;

		private ConfigurableJoint[] _wheelJnts;

		private float _jackHeight;

		private float _lastLever;

		[SerializeField]
		private AudioClip _soundUp;

		[SerializeField]
		private AudioClip _soundDown;

		private ManagedAudioPlayer _mapUp;

		private ManagedAudioPlayer _mapDown;

		private void Awake()
		{
		}

		public void PumpJack(bool up)
		{
		}

		public void ButtonUp(bool down)
		{
		}

		public void ButtonDown(bool down)
		{
		}
	}
}
