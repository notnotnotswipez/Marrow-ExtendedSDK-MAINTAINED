using SLZ.Interaction;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class Powerable_PalletJack : Powerable
	{
		[SerializeField]
		private ConfigurableJoint _pivotjnt;

		[SerializeField]
		private ConfigurableJoint[] _wheelJnts;

		[SerializeField]
		private Grip _handleGrip;

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

		public override void VoltageToObject(float voltage, int id = 0)
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
