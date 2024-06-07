using System.Collections.Generic;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourVoidWatcher : BehaviourBase
	{
		public enum VoidWatcherState
		{
			Emerge = 0,
			Watch = 1,
			Submerge = 2
		}

		public SubBehaviourSfx sfx;

		public VoidWatcherState watcherState;

		public float emergeTime;

		public float submergeTime;

		public Vector3 emergeLocalDisplace;

		public bool playAgroSound;

		public float loopVolume;

		private HashSet<Rigidbody> _selfRbs;

		private Quaternion _localAnimatedRoot;

		private float _blockCollisionsUntil;

		private int _flinchAnim;

		private int _clipIntAnim;

		private bool _disableOnUpdate;

		private Vector3 _currentVel;

		private Vector3 _initialConnectedAnchor;

		private Vector3 _targetConnectedAnchor;

		private Vector3 _animatedRoot;

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		public void SubmergeVoidWatcher()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return 0f;
		}

		private void ResetAnimator()
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		public void SwitchWatcherState(VoidWatcherState goToState)
		{
		}
	}
}
