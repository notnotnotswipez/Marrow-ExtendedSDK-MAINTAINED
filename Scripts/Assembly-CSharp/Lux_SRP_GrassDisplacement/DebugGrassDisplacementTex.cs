using System;
using UnityEngine;

namespace Lux_SRP_GrassDisplacement
{
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		public enum DebugSize
		{
			_128 = 0x80,
			_256 = 0x100,
			_512 = 0x200,
			_1024 = 0x400
		}

		public bool m_EnableDebug;

		public DebugSize currentDebugSize;
	}
}
