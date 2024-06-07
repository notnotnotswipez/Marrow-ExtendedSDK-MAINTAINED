using System;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourFaceanim : SubBehaviourBase
	{
		[Serializable]
		public class FaceEvent
		{
			public enum TriggerIndex
			{
				Greeting = 0,
				UnAgro = 1,
				PainSmall = 2,
				PainBig = 3,
				Death = 4,
				EventLine = 5
			}

			public AudioClip clip;

			public TriggerIndex triggerIndex;

			public int animIndex;
		}

		public bool faceAnimEnabled;

		public Transform mouthTran;

		[SerializeField]
		private FaceEvent[] greetings;

		[SerializeField]
		private FaceEvent[] agros;

		[SerializeField]
		private FaceEvent[] unAgros;

		[SerializeField]
		private FaceEvent[] deaths;

		[SerializeField]
		private FaceEvent[] painSmalls;

		[SerializeField]
		private FaceEvent[] painBigs;

		[SerializeField]
		private FaceEvent[] attack1s;

		[SerializeField]
		private FaceEvent[] efforts;

		[SerializeField]
		private FaceEvent[] eventLines;

		private AudioSource _mouthSource;

		private Animator _animator;

		private int _speechRandom;

		private int _painSmall;

		private int _painBig;

		private int _deathFace;

		private int _greetingSub;

		private int _unAgro;

		private int _faceAnimNorm;

		private int _eventLine;

		private int _idleFace;

		private float _cooldownTime;

		private bool _faceAnimActive;

		private int GetTriggerIndex(FaceEvent.TriggerIndex triggerIndex)
		{
			return 0;
		}

		public void Initiate(BehaviourBase b)
		{
		}

		public void SetCooldown(float time)
		{
		}

		public void Reset()
		{
		}

		public void UpdateFaceAnim()
		{
		}

		private void FaceSetup(int i, float cooldown, FaceEvent faceEvent)
		{
		}

		public void Greeting(int i = -1)
		{
		}

		public void Agro(int i = -1)
		{
		}

		public void UnAgro(int i = -1)
		{
		}

		public void JumpCharge()
		{
		}

		public void Jump(float jumpCharge)
		{
		}

		public void Pain(float magnitude)
		{
		}

		public void Death(int i = -1)
		{
		}

		public void Attack1(int i = -1, float odds = 1f)
		{
		}

		public void EventLine(int i = -1)
		{
		}

		public void EventLine(FaceEvent faceEvent, float volume = 1f)
		{
		}

		public void SetEventLines(FaceEvent[] fEvents)
		{
		}
	}
}
