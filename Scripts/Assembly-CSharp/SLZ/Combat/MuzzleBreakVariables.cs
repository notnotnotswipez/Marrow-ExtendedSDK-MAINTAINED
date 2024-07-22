using System;
using UnityEngine;

namespace SLZ.Combat
{
	[Serializable]
	public struct MuzzleBreakVariables
	{
		[Tooltip("Muzzle type")]
		public MuzzleBreakType muzzleBreakType;

		[Range(0f, 1f)]
		[Tooltip("Amount of recoil suppression")]
		public float RecoilCompensation;

		[Tooltip("Amount of Muzzle Rise suppression")]
		[Range(0f, 1f)]
		public float MuzzleRiseCompensation;
	}
}
