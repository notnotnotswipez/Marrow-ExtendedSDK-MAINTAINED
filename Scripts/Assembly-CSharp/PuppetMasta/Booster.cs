using System;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class Booster
	{
		[Tooltip("If true, all the muscles will be boosted and the 'Muscles' and 'Groups' properties below will be ignored.")]
		public bool fullBody;

		[Tooltip("Muscles to boost. Used only when 'Full Body' is false.")]
		public ConfigurableJoint[] muscles;

		[Tooltip("Muscle groups to boost. Used only when 'Full Body' is false.")]
		public Muscle.Group[] groups;

		[Tooltip("Immunity to apply to the muscles. If muscle immunity is 1, it can not be damaged.")]
		[Range(0f, 1f)]
		public float immunity;

		[Tooltip("Impulse multiplier to be applied to the muscles. This makes them deal more damage to other puppets.")]
		public float impulseMlp;

		[Tooltip("Falloff for parent muscles (power of kinship degree).")]
		public float boostParents;

		[Tooltip("Falloff for child muscles (power of kinship degree).")]
		public float boostChildren;

		[Tooltip("This does nothing on it's own, you can use it in a 'yield return new WaitForseconds(delay);' call.")]
		public float delay;
	}
}
