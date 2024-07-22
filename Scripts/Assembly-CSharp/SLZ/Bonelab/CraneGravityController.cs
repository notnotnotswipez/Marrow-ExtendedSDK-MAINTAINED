using SLZ.Marrow;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CraneGravityController : MonoBehaviour
	{
		public GravityManipulatorJob gravityManipulator;

		public Transform uiGravityManipulator;

		private bool flop;

		public GameObject greenLight;

		public GameObject redLight;

		private ManagedAudioPlayer _mapSmall;

		private ManagedAudioPlayer _mapBig;

		public AudioClip[] gravityManipulatorSmallSounds;

		public AudioClip[] gravityManipulatorBigSounds;

		public PrismaticSFX[] prismaticSfx;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void EnablePrismatics()
		{
		}

		public void ForceGavityManipState(bool onOff)
		{
		}

		public void FlopCraneGravity(bool isStart = false)
		{
		}
	}
}
