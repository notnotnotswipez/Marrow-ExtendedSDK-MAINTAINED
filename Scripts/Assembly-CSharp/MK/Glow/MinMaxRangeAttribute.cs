using UnityEngine;

namespace MK.Glow
{
	public sealed class MinMaxRangeAttribute : PropertyAttribute
	{
		public float minLimit;

		public float maxLimit;

		public MinMaxRangeAttribute(float minLimit, float maxLimit)
		{
		}
	}
}
