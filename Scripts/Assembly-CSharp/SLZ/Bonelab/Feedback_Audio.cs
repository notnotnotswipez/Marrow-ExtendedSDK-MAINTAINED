using UnityEngine;

namespace SLZ.Bonelab
{
	public class Feedback_Audio : MonoBehaviour
	{
		public enum Confirm
		{
			random = 0,
			order = 1,
			single = 2
		}

		public enum Deny
		{
			random = 0,
			order = 1,
			single = 2
		}

		public enum Click
		{
			random = 0,
			order = 1,
			single = 2
		}

		public enum Hover
		{
			random = 0,
			order = 1,
			single = 2
		}

		public enum Activate
		{
			random = 0,
			order = 1,
			single = 2
		}

		public enum Deactivate
		{
			random = 0,
			order = 1,
			single = 2
		}

		[Header("Clip Play Order")]
		public Confirm confirmMode;

		public Deny denyMode;

		public Click clickMode;

		public Hover hoverMode;

		public Activate activateMode;

		public Deactivate deactivateMode;

		private int _last_confirm;

		private int _last_deny;

		private int _last_click;

		private int _last_hover;

		private int _last_activate;

		private int _last_deactivate;

		[Tooltip("Is the sound 2d or 3d?")]
		[Header("AudioSettings")]
		[Range(0f, 1f)]
		public float spatialBlend;

		[Range(0f, 1f)]
		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		public float _sourceVolume;

		[Range(0.1f, 10f)]
		public float _sourceRadius;

		public GameObject audioPlacementOverride;

		[Space(10f)]
		[Header("AudioClips")]
		public AudioClip[] clips_Confirm;

		public AudioClip[] clips_Deny;

		public AudioClip[] clips_Click;

		public AudioClip[] clips_Hover;

		public AudioClip[] clips_Activate;

		public AudioClip[] clips_Deactivate;

		private void Start()
		{
		}

		public void AUDIOCONFIRM(int clip = 0, AudioClip clipOverride = null, Transform location = null)
		{
		}

		public void AUDIODENY(int clip = 0, AudioClip clipOverride = null, Transform location = null)
		{
		}

		public void AUDIOCLICK(int clip = 0, AudioClip clipOverride = null, Transform location = null)
		{
		}

		public void AUDIOHOVER(int clip = 0, AudioClip clipOverride = null, Transform location = null)
		{
		}

		public void AUDIOACTIVATE(int clip = 0, Transform location = null)
		{
		}

		public void AUDIODEACTIVATE(int clip = 0, Transform location = null)
		{
		}

		private void PlayAudio(AudioClip clipToPlay, Transform location = null, bool following = false)
		{
		}
	}
}
