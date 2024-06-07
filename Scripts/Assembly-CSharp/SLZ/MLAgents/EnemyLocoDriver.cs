using PuppetMasta;
using SLZ.Marrow.Mechanics;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class EnemyLocoDriver : MonoBehaviour
	{
		public float moveCooldown;

		public float currentMoveTime;

		public BehaviourPowerLegs powerLegs;

		public LiteLoco loco;

		private LiteLoco.StepGroup stepGroup;

		private int current_gear;

		public GameObject ai_hip;

		public GameObject joint_hip;

		private AnimationCurve muscleCurve;

		public float anim_curve_x_max;

		public float anim_curve_x_min;

		public float anim_curve_y_max;

		public float anim_curve_y_min;

		private void RandomizeAnimationCurve(ref AnimationCurve animCurve, float nb_inds)
		{
		}

		private void Start()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
