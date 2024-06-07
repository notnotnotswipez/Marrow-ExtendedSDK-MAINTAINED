using SLZ.Interaction;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class GunSFX : MonoBehaviour
	{
		public AudioClip[] fire;

		public AudioClip[] fireSlow;

		public AudioClip[] grab;

		public AudioClip[] secondGrip;

		public AudioClip[] slidePull;

		public AudioClip[] slideRelease;

		public AudioClip[] magazineInsert;

		public AudioClip[] magazineDrop;

		public AudioClip[] dryFire;

		public AudioClip[] dryFireSlow;

		public AudioClip[] slideLockFire;

		public AudioClip[] slideLockFireSlow;

		private InteractableHost _host;

		private ManagedAudioPlayer _gunshotMap;

		private void Start()
		{
		}

		public void GunError()
		{
		}

		public void GunShot()
		{
		}

		public void Grab(Vector3 localPosition = default(Vector3))
		{
		}

		public void SecondGrip(Vector3 localPosition = default(Vector3))
		{
		}

		public void SlidePull()
		{
		}

		public void SlideRelease()
		{
		}

		public void MagazineInsert()
		{
		}

		public void MagazineDrop()
		{
		}

		public void SlideLock()
		{
		}

		public void DryFire()
		{
		}
	}
}
