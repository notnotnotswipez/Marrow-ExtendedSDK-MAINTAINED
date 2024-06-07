using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class RuntimeGrowthParameters
	{
		public float growthSpeed;

		public float lifetime;

		public bool speedOverLifetimeEnabled;

		public AnimationCurve speedOverLifetimeCurve;

		public float delay;

		public bool startGrowthOnAwake;
	}
}
