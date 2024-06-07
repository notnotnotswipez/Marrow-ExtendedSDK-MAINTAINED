using System;
using UnityEngine;

namespace SLZ.Combat
{
	[Serializable]
	public struct MuzzleBreakVariables
	{
		[Tooltip("Muzzle type")]
		public MuzzleBreakType muzzleBreakType;

		[Tooltip("Amount of recoil suppression")]
		[Range(0f, 1f)]
		public float RecoilCompensation;

		[Tooltip("Amount of Muzzle Rise suppression")]
		[Range(0f, 1f)]
		public float MuzzleRiseCompensation;
	}
}
