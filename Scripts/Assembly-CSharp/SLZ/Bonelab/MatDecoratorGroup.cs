using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class MatDecoratorGroup
	{
		[Tooltip("Does nothing, just for organization")]
		public string label;

		public Material[] materials;
	}
}
