using System;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class PrismaticSFX : MonoBehaviour
	{
		[Serializable]
		public class AudioEvent
		{
			[HideInInspector]
			public bool eventEnabled;

			public Transform eventTran;

			public AudioClip[] eventClip;

			public float minSpeed;

			public float maxSpeed;

			public float triggerDistance;
		}

		[Tooltip("Measures velocity relative to this, use this to prevent sound from world velocity on multi-body entities.")]
		[Header("PROPERTIES")]
		public Rigidbody rb_parent;

		[Tooltip("Location of velocity measurement.")]
		public Transform velocityTran;

		[Tooltip("Location of audio playback.")]
		public Transform sourceTran;

		[Header("MODULATED AUDIO")]
		[Tooltip("Zero volume at lower speeds.")]
		public float minSpeed;

		[Tooltip("Higher speeds won't result in more volume.")]
		public float maxSpeed;

		public float sourceMinDistance;

		public float pitchMod;

		public bool loopClips;

		public AudioClip[] modulatedClips;

		[Space(10f)]
		public AudioEvent[] audioEvents;

		[Range(0f, 1f)]
		public float SpatialBlend;

		[SerializeField]
		private bool _blockJointBreakStop;

		private ManagedAudioPlayer _mapLoop;

		private InteractableHost _host;

		private Rigidbody _rigidbody;

		private bool _canPlay;

		private float _lastSpeed;

		private Vector3 _lastVel;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}
	}
}
