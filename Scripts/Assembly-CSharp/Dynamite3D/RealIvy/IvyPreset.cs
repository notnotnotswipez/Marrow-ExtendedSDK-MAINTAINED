using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyPreset : ScriptableObject
	{
		public string presetName;

		public IvyParameters ivyParameters;

		public void CopyFrom(IvyParametersGUI copyFrom)
		{
		}
	}
}
