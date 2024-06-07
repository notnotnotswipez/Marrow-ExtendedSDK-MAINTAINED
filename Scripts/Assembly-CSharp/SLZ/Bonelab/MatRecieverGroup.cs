using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class MatRecieverGroup
	{
		[Tooltip("Does nothing, just for organization")]
		public string label;

		public List<MeshRenderer> meshRenderers;
	}
}
