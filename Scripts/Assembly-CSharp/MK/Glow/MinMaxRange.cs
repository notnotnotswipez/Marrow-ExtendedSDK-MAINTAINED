using System;

namespace MK.Glow
{
	[Serializable]
	public struct MinMaxRange
	{
		public float minValue;

		public float maxValue;

		public MinMaxRange(float minValue, float maxValue)
		{
			this.minValue = 0f;
			this.maxValue = 0f;
		}
	}
}
