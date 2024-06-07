using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ReflectionProbe))]
	public class SetDoorWindowRefraction : MonoBehaviour
	{
		[Serializable]
		public struct TargetMaterial
		{
			public Renderer renderer;

			public int matNumber;
		}

		public ReflectionProbe rp;

		public TargetMaterial[] targetMaterials;

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		public void APPLY()
		{
		}
	}
}
